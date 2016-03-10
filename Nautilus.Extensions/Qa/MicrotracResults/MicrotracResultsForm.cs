using Nautilus.Data;
using Nautilus.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nautilus.Extensions.Qa.MicrotracResults
{
    public partial class MicrotracResultsForm : Form
    {
        private ExtensionContext _ctx;
        private string _parsingLocation;
        private AliquotRepo _aliquotRepo;
        private IEnumerable<Aliquot> _aliquots;

        public MicrotracResultsForm(ExtensionContext ctx)
        {
            _ctx = ctx;
            InitializeComponent();
        }

        private void MicrotracResultsForm_Load(object sender, EventArgs e)
        {
            _aliquotRepo = new AliquotRepo(_ctx.ServerInfo, _ctx.Username, _ctx.Password);
            _aliquots = _aliquotRepo.GetParticleSizeAliquotsHavingAvailableTests();

            foreach (var aliquot in _aliquots)
            {
                lvAliquots.Items.Add(new ListViewItem(new string[] { aliquot.Name, aliquot.Storage, aliquot.Description, aliquot.Status }));
            }

            PopulateComboBoxWithSystemDSNs();
        }


        private void PopulateComboBoxWithSystemDSNs()
        {
            try
            {
                var reg = (Microsoft.Win32.Registry.LocalMachine).OpenSubKey(@"Software\ODBC\ODBC.INI");

                if (reg != null)
                {
                    // Get all DSN entries defined in DSN_LOC_IN_REGISTRY.
                    foreach (string dataSourceName in reg.GetSubKeyNames())
                    {
                        if (dataSourceName.ToLower().StartsWith("microtrac"))
                        {
                            DBaseRegEntry dbreg = new DBaseRegEntry();
                            dbreg.Name = dataSourceName;
                            dbreg.Directory = reg.OpenSubKey(dataSourceName).GetValue("DefaultDir").ToString();
                            try
                            {
                                dbreg.SlNumbers = reg.OpenSubKey(dataSourceName).GetValue("Description").ToString();
                            }
                            catch
                            {
                                dbreg.SlNumbers = string.Empty;
                            }

                            cmbDataSource.Items.Add(dbreg);
                        }
                    }
                }
                reg.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing ODBC registry entries:\r\n" + ex.Message);
            }
        }


        private void cmbDataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFileName.Items.Clear();
            cmbFileName.Enabled = true;

            // get the object out of the combobox, get a list of .dbf files in the DSNs directory
            var dbreg = (DBaseRegEntry)cmbDataSource.SelectedItem;
            if (dbreg == null) return;

            txtSlNumbers.Text = dbreg.SlNumbers;

            try
            {
                var di = new DirectoryInfo(dbreg.Directory);
                var files = di.GetFiles("*.dbf");

                foreach (FileInfo fi in files)
                {
                    cmbFileName.Items.Add(fi.Name.Replace(".dbf", string.Empty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting file list in selected data source:\r\n" + ex.Message);
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDataSource.Text) || string.IsNullOrEmpty(cmbFileName.Text))
            {
                MessageBox.Show("You must make a selection for Data Source and File Name.");
                return;
            }

            if (lvAliquots.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select at least one aliquot.");
                return;
            }

            _parsingLocation = GetFileParsingPath();
            if (string.IsNullOrEmpty(_parsingLocation)) return;

            GetDataFromDsn();
        }


        string GetFileParsingPath()
        {
            var instrumentName = "Microtrac";
            string path = string.Empty;
            try
            {
                var instrument = _aliquotRepo.Get<Instrument>("name", instrumentName).Single();
                var instrCtrl = _aliquotRepo.Get<Instrument_Control>("instrument_id", instrument.Instrument_Control_Id).Single();
                path = instrCtrl.Input_File_Directory;
            }
            catch
            {
                MessageBox.Show($"Could not determine the '{instrumentName}' instrument parsing directory location.");
            }

            return path;
        }


        /// <summary>
        /// Populates Results property with microtrac results for selected aliquot from 
        /// selected data source and selected file name
        /// </summary>
        /// <returns></returns>
        private void GetDataFromDsn()
        {

            using (var connectionMicrotrac = new OdbcConnection(string.Format("DSN={0}", cmbDataSource.Text)))
            {
                try
                {
                    connectionMicrotrac.Open();
                }
                catch (OdbcException)
                {
                    MessageBox.Show("To use this extension, you must have an ODBC DSN to the Microtrac database file location.\r\n" +
                        "Please contact the Nautilus admin for assistance with this setup.");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to Microtrac dBASE files:\r\n" + ex.Message);
                    return;
                }

                var results = new List<MicrotracResult>();
                MicrotracResult result;

                foreach (ListViewItem lvi in lvAliquots.SelectedItems)
                {

                    string sqlString = $"select * from {cmbFileName.Text} where samid1 = ? order by samid2 asc, runnumber desc";

                    var command = new OdbcCommand(sqlString, connectionMicrotrac);
                    command.Parameters.AddWithValue("ID", lvi.SubItems[0].Text);
                    OdbcDataReader reader;

                    try
                    {
                        reader = command.ExecuteReader();
                        List<string> sampIdsToIgnore = new List<string>();

                        if (!reader.HasRows)
                        {
                            MessageBox.Show(string.Format("Selected aliquot '{0}' has no data in file '{1}' of data source '{2}'.",
                                lvi.SubItems[0].Text, cmbFileName.Text, cmbDataSource.Text));
                            continue;
                        }

                        while (reader.Read())
                        {

                            // if the result set contains a "run 100", it is the average of replicate runs and should
                            // be used as the actual result, and any other run numbers for the same samid2 value should be ignored.
                            // if there is no "run 100", there will be only a "run 1", in which case it should be used as the actual.
                            if (!sampIdsToIgnore.Contains(reader["SAMID2"].ToString()))
                            {
                                result = new MicrotracResult();
                                result.AliquotName = lvi.SubItems[1].Text;
                                result.DbTag1 = reader["DBTAG1"].ToString();
                                result.DbTag2 = reader["DBTAG2"].ToString();
                                result.DbTag3 = reader["DBTAG3"].ToString();
                                result.MeanVolume = reader["STDMV"].ToString();
                                result.Note = reader["NOTE1"].ToString();
                                result.ResultName = "Actual " + reader["SAMID2"].ToString().Substring(reader["SAMID2"].ToString().Length - 1);

                                for (int i = 0; i < 10; i++)
                                {
                                    result.PercentileValues[i] = reader["PTILVL" + (i + 1)].ToString();
                                }

                                for (int i = 0; i < 10; i++)
                                {
                                    result.Percentiles[i] = reader["PTILES" + (i + 1)].ToString();
                                }

                                if (reader["RUNNUMBER"].ToString().Equals("100"))
                                {
                                    sampIdsToIgnore.Add(reader["SAMID2"].ToString());
                                }

                                results.Add(result);
                            }

                        }

                        reader.Close();

                        WriteResultFile(lvi.SubItems[0].Text, results, _parsingLocation, _ctx.OperatorId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Error retrieving Microtrac results from table '{0}' for ID '{1}':\r\n{2}",
                                cmbFileName.Text, lvi.SubItems[0].Text, ex.Message));
                    }
                }
            }
        }


        private void WriteResultFile(string aliquotName, List<MicrotracResult> results, string fileLocation, decimal operatorId)
        {
            List<string> resultLines = new List<string>();

            foreach (MicrotracResult r in results)
            {
                for (int i = 0; i < r.Percentiles.Length; i++)
                {
                    resultLines.Add(string.Format("Particle Size - {0}%,{1},{2}", r.Percentiles[i], r.ResultName, r.PercentileValues[i]));
                }
                resultLines.Add(string.Format("Particle Size - Mean of Volume,{0},{1}", r.ResultName, r.MeanVolume));
            }

            // sort the list of results, then iterate back through, adding strings for averages and medians, also SL Numbers
            resultLines.Sort();

            List<string> resultLinesAvgAndMed = new List<string>();
            List<double> resultListForMedian = new List<double>();
            string previousTestName = string.Empty;
            string thisTestName;
            double sum = 0, parsedValue;
            int count = 0;

            foreach (string resultLine in resultLines)
            {
                thisTestName = resultLine.Split(",".ToCharArray())[0];

                // when encountering a new test name, add text rows for median and mean.
                if (!string.IsNullOrEmpty(previousTestName) && !thisTestName.Equals(previousTestName))
                {
                    resultListForMedian.Sort();
                    if (!string.IsNullOrEmpty(txtSlNumbers.Text))
                    {
                        resultLinesAvgAndMed.Add(string.Format("{0},SL Numbers,{1}", previousTestName, txtSlNumbers.Text));
                    }
                    resultLinesAvgAndMed.Add(string.Format("{0},Average,{1}", previousTestName, sum / (double)count));
                    resultLinesAvgAndMed.Add(string.Format("{0},Median,{1}", previousTestName,
                        count % 2 == 0 ? (resultListForMedian[(count / 2) - 1] + resultListForMedian[count / 2]) / 2.0 : resultListForMedian[count / 2]));
                    resultListForMedian.Clear();
                    count = 0;
                    sum = 0.0;
                }

                count++;
                if (double.TryParse(resultLine.Split(",".ToCharArray())[2], out parsedValue))
                {
                    sum += parsedValue;
                    resultListForMedian.Add(parsedValue);
                }
                else
                {
                    MessageBox.Show(string.Format("A non-numeric value was encountered for {0}.  Parsing file cannot be written.", aliquotName));
                    return;
                }

                previousTestName = thisTestName;
            }

            if (count > 0 && resultListForMedian.Count > 0)
            {
                resultListForMedian.Sort();
                if (!string.IsNullOrEmpty(txtSlNumbers.Text))
                {
                    resultLinesAvgAndMed.Add(string.Format("{0},SL Numbers,{1}", previousTestName, txtSlNumbers.Text));
                }
                resultLinesAvgAndMed.Add(string.Format("{0},Average,{1}", previousTestName, sum / (double)count));
                resultLinesAvgAndMed.Add(string.Format("{0},Median,{1}", previousTestName,
                    count % 2 == 0 ? (resultListForMedian[(count / 2) - 1] + resultListForMedian[count / 2]) / 2.0 : resultListForMedian[count / 2]));
            }

            // add averages, medians, and SL numbers to result lines, then sort it again so the averages and medians are placed with the actuals
            resultLines.AddRange(resultLinesAvgAndMed);
            resultLines.Sort();

            StringBuilder sb = new StringBuilder("Aliquot Name," + aliquotName + Environment.NewLine);
            sb.Append("Operator," + operatorId + Environment.NewLine);

            foreach (string resultLine in resultLines)
            {
                sb.AppendLine(resultLine);
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(fileLocation, aliquotName + " (Particle Size).csv")))
                {
                    sw.Write(sb.ToString());
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing parsing file:\r\n" + ex.Message);
            }

            if (chkShowFiles.Checked)
            {
                try
                {
                    string tempFile = Path.Combine("C:\\temp", aliquotName + " (Particle Size).csv");
                    using (StreamWriter swCopy = new StreamWriter(tempFile))
                    {
                        swCopy.Write(sb.ToString());
                        swCopy.Close();
                        System.Diagnostics.Process.Start(tempFile);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing temp file copy:\r\n" + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
