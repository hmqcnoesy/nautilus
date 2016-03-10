using MockNautilus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockNautilus
{
    public partial class MockNautilus : Form
    {
        private List<Type> _extensionTypes;
        private const string _methodNameEntity = "LSEXT.IEntityExtension.Execute";
        private const string _methodNameGeneric = "LSEXT.IGenericExtension.Execute";
        private const string _methodNameWorkflow = "LSEXT.IWorkflowExtension.Execute";
        private const string _methodNameVersion = "LSEXT.IVersion.GetVersion";
        private const BindingFlags _flags = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static;

        public MockNautilus()
        {
            InitializeComponent();
            LoadExtensions();
            SetupParameterDefaults();
        }


        private void LoadExtensions()
        {
            var assembly = Assembly.LoadFrom("Nautilus.Extensions.dll");

            _extensionTypes = (from t in assembly.GetTypes()
                               where t.GetMethod(_methodNameEntity, _flags) != null
                               || t.GetMethod(_methodNameGeneric, _flags) != null
                               || t.GetMethod(_methodNameWorkflow, _flags) != null
                               || t.GetMethod(_methodNameVersion, _flags) != null
                               orderby t.FullName
                               select t).ToList();

            foreach (var ex in _extensionTypes)
            {
                listExtensions.Items.Add(ex);
            }
        }


        private void SetupParameterDefaults()
        {
            txtProduct.Text = Settings.Default.Product;
            txtVersion.Text = Settings.Default.Version;
            txtServer.Text = Settings.Default.Server;
            txtComputerName.Text = Settings.Default.ComputerName;
            txtHKeyCurrentUser.Text = Settings.Default.HKeyCurrentUser;
            txtHKeyLocalMachine.Text = Settings.Default.HKeyLocalMachine;
            txtOperatorName.Text = Settings.Default.OperatorName;
            txtRoleName.Text = Settings.Default.RoleName;
            txtOperatorId.Text = Settings.Default.OperatorId.ToString();
            txtRoleId.Text = Settings.Default.RoleId.ToString();
            txtWorkstationId.Text = Settings.Default.WorkstationId.ToString();
            txtSessionId.Text = Settings.Default.SessionId.ToString();
            txtUsername.Text = Settings.Default.Username;
            txtPassword.Text = Settings.Default.Password;
            txtServerInfo.Text = Settings.Default.ServerInfo;

            txtEntityId.Text = Settings.Default.EntityId.ToString();
            txtEntityRecords.Text = Settings.Default.EntityRecords;

            txtWorkflowId.Text = Settings.Default.WorkflowId.ToString();
            txtWorkflowNodeId.Text = Settings.Default.WorkflowNodeId.ToString();
            txtWorkflowTableName.Text = Settings.Default.WorkflowTableName;
            txtWorkflowPrimaryKey.Text = Settings.Default.WorkflowPrimaryKey;
            chkWorkflowIsInteractive.Checked = Settings.Default.WorkflowIsInteractive;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveParametersToSettings();
            }
            catch
            {
                MessageBox.Show("Check that all numeric parameters have numeric values.");
                e.Cancel = true;
            }
        }


        private void SaveParametersToSettings()
        {
            Settings.Default.Product = txtProduct.Text;
            Settings.Default.Version = txtVersion.Text;
            Settings.Default.Server = txtServer.Text;
            Settings.Default.ComputerName = txtComputerName.Text;
            Settings.Default.HKeyCurrentUser = txtHKeyCurrentUser.Text;
            Settings.Default.HKeyLocalMachine = txtHKeyLocalMachine.Text;
            Settings.Default.OperatorName = txtOperatorName.Text;
            Settings.Default.RoleName = txtRoleName.Text;
            Settings.Default.OperatorId = decimal.Parse(txtOperatorId.Text);
            Settings.Default.RoleId = decimal.Parse(txtRoleId.Text);
            Settings.Default.WorkstationId = decimal.Parse(txtWorkstationId.Text);
            Settings.Default.SessionId = decimal.Parse(txtSessionId.Text);
            Settings.Default.Username = txtUsername.Text;
            Settings.Default.Password = txtPassword.Text;
            Settings.Default.ServerInfo = txtServerInfo.Text;

            Settings.Default.EntityId = decimal.Parse(txtEntityId.Text);
            Settings.Default.EntityRecords = txtEntityRecords.Text;

            Settings.Default.WorkflowId = decimal.Parse(txtWorkflowId.Text);
            Settings.Default.WorkflowNodeId = decimal.Parse(txtWorkflowNodeId.Text);
            Settings.Default.WorkflowTableName = txtWorkflowTableName.Text;
            Settings.Default.WorkflowPrimaryKey = txtWorkflowPrimaryKey.Text;
            Settings.Default.WorkflowIsInteractive = chkWorkflowIsInteractive.Checked;

            Settings.Default.Save();
        }


        private void listExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = (Type)(listExtensions.SelectedItem ?? typeof(object));

            btnEntityExecute.Enabled = selectedType.GetMethod(_methodNameEntity, _flags) != null;
            btnGenericExecute.Enabled = selectedType.GetMethod(_methodNameGeneric, _flags) != null;
            btnGetVersion.Enabled = selectedType.GetMethod(_methodNameVersion, _flags) != null;
            btnWorkflowExecute.Enabled = selectedType.GetMethod(_methodNameWorkflow, _flags) != null;
        }


        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                var methodNameToInvoke = ((Button)sender).Tag.ToString();
                var selectedType = (Type)listExtensions.SelectedItem;
                var methodToInvoke = selectedType.GetMethod(methodNameToInvoke, _flags);
                var instance = Activator.CreateInstance(selectedType);

                if (methodNameToInvoke == _methodNameVersion)
                {
                    MessageBox.Show(methodToInvoke.Invoke(instance, null).ToString());
                }
                else
                {
                    var parameters = SetupMockParameters();
                    methodToInvoke.Invoke(instance, new object[] { parameters });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to invoke: " + ex.Message);
            }
        }


        private LSEXT.LSExtensionParameters SetupMockParameters()
        {
            var parameters = new MockExtensionParameters();
            parameters.Product = txtProduct.Text;
            parameters.Version = txtVersion.Text;
            parameters.Server = txtServer.Text;
            parameters.ComputerName = txtComputerName.Text;
            parameters.HKeyCurrentUser = txtHKeyCurrentUser.Text;
            parameters.HKeyLocalMachine = txtHKeyLocalMachine.Text;
            parameters.OperatorName = txtOperatorName.Text;
            parameters.RoleName = txtRoleName.Text;
            parameters.OperatorId = decimal.Parse(txtOperatorId.Text);
            parameters.RoleId = decimal.Parse(txtRoleId.Text);
            parameters.WorkstationId = decimal.Parse(txtWorkstationId.Text);
            parameters.SessionId = decimal.Parse(txtSessionId.Text);
            parameters.Username = txtUsername.Text;
            parameters.Password = txtPassword.Text;
            parameters.ServerInfo = txtServerInfo.Text;

            parameters.EntityId = decimal.Parse(txtEntityId.Text);
            parameters.EntityRecords = SplitAndParseEntityRecordsText();

            parameters.WorkflowId = decimal.Parse(txtWorkflowId.Text);
            parameters.WorkflowNodeId = decimal.Parse(txtWorkflowNodeId.Text);
            parameters.WorkflowTableName = txtWorkflowTableName.Text;
            parameters.WorkflowPrimaryKey = txtWorkflowPrimaryKey.Text;
            parameters.WorkflowIsInteractive = chkWorkflowIsInteractive.Checked;

            return parameters;
        }


        private ADODB.Recordset SplitAndParseEntityRecordsText()
        {
            var parts = txtEntityRecords.Text.Split(";, \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var entityRecordIds = new ADODB.Recordset();
            entityRecordIds.Fields.Append("ID", ADODB.DataTypeEnum.adVariant);
            entityRecordIds.Open();

            foreach (var id in parts)
            {
                entityRecordIds.AddNew("ID", id);
            }

            entityRecordIds.MoveFirst();

            return entityRecordIds;
        }


        private void btnChooseEntities_Click(object sender, EventArgs e)
        {
            //var ocsb = new OracleConnectionStringBuilder();
            //ocsb.DataSource = txtServerInfo.Text;
            //ocsb.UserID = txtUsername.Text;
            //ocsb.Password = txtPassword.Text;

            //using (var frm = new ChooseEntitiesForm(ocsb.ToString()))
            //{
            //    var result = frm.ShowDialog();

            //    if (result == System.Windows.Forms.DialogResult.OK)
            //    {
            //        if (frm.EntityId.HasValue) txtEntityId.Text = frm.EntityId.ToString();
            //        txtEntityRecords.Text = string.Join("\r\n", frm.EntityRecords.Select(x => x.ToString()));
            //    }
            //}
        }
    }
}

