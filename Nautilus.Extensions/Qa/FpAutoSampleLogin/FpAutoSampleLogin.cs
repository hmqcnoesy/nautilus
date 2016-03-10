using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSEXT;
using System.Windows.Forms;
using Nautilus.DataAccess;
using Nautilus.Data;
using System.IO;

namespace Nautilus.Extensions.Qa
{
    public class FpAutoSampleLogin : LSEXT.IWorkflowExtension, LSEXT.IVersion
    {
        private NautilusEntityRepo _repo;

        int IVersion.GetVersion()
        {
            return 4101;
        }


        void IWorkflowExtension.Execute(ref LSExtensionParameters parameters)
        {
            var exctx = new ExtensionContext(parameters);

            if (!exctx.IsEntityOfType("Sample"))
            {
                MessageBox.Show("This extension runs only on sample entities.");
                return;
            }

            _repo = new NautilusEntityRepo(exctx.ServerInfo, exctx.Username, exctx.Password);
            var sample = _repo.Get<Sample>(exctx.WorkflowPrimaryKeyNumeric);
            var sampleUser = _repo.Get<Sample_User_Qa>(exctx.WorkflowPrimaryKeyNumeric);
            var oper = _repo.Get<Operator>(sample.Created_By.Value);
            var wfNodes = _repo.Get<Workflow_Node>("Workflow_Id", exctx.WorkflowId.Value);
            var fpWorkflowName = wfNodes
                .SingleOrDefault(n => n.Workflow_Node_Type_Id == 17 && n.Workflow_Prompt_Column == "U_FP_WORKFLOW")?.Parameter_2;

            if (string.IsNullOrEmpty(fpWorkflowName))
            {
                MessageBox.Show("The workflow has the FP Auto Sample Login Extension but NO FP WORKFLOW FIELD ASSIGNMENT NODES."
                    + "\r\nThe extension cannot auto login the fp sample(s) without these nodes in the workflow.");
                return;
            }

            var parsingLocation = _repo.Get<OpsInstrument>("Name", "File Login").SingleOrDefault()?.Input_File_Directory;

            if (string.IsNullOrEmpty(parsingLocation))
            {
                MessageBox.Show("The ops 'File Login' instrument parsing location couldn't be determined.");
                return;
            }

            CreateFpLoginFile(parsingLocation, oper.Full_Name, fpWorkflowName, sample.Name, sampleUser.U_Serial_Number, sample.Date_Results_Required);
        }


        private void CreateFpLoginFile(string filePath, string createdBy, string workflowName, string qaSampleName, string serialNumber, DateTime? dueDate)
        {
            var dueDateString = dueDate.HasValue ? dueDate.Value.ToString("") : string.Empty;
            var header = "Begin Sample\r\n\"External_Ref\",\"Workflow_Name\",\"Study_Ref\",\"SDG_Ref\",\"Description\",\"U_LOT_NO\",\"DATE_RESULTS_REQUIRED\"\r\n";
            var detail = $"\"{createdBy}\",\"{workflowName}\",,,\"{qaSampleName}\",\"{serialNumber}\",\"{dueDateString}\"\r\n";
            var footer = "End Sample";
            try
            {
                File.WriteAllText(filePath, header + detail + footer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create the FP sample login file: " + ex.Message);
            }
        }
    }
}
