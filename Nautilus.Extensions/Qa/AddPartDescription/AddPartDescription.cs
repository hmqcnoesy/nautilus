using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSEXT;
using System.Windows.Forms;
using Nautilus.DataAccess;
using Nautilus.Data;

namespace Nautilus.Extensions.Qa
{
    [System.Runtime.InteropServices.ProgId("NautilusExtensions.Qa.AddPartDescription")]
    public class AddPartDescription : LSEXT.IEntityExtension, LSEXT.IVersion
    {
        private WorkflowRepo _repo;


        int IVersion.GetVersion()
        {
            return 4101;
        }


        ExecuteExtension IEntityExtension.CanExecute(ref IExtensionParameters Parameters)
        {
            return ExecuteExtension.exEnabled;
        }


        void IEntityExtension.Execute(ref LSExtensionParameters parameters)
        {
            var exctx = new ExtensionContext(parameters);
            _repo = new WorkflowRepo(exctx.ServerInfo, exctx.Username, exctx.Password);
            
            if (!exctx.IsEntityOfType("Sample Workflow"))
            {
                MessageBox.Show("This extension is for sample workflows only.");
                return;
            }

            var workflows = _repo.Get<Workflow>(exctx.EntityIds);

            foreach(var workflow in workflows)
            {
                var partNumber = _repo.GetWorkflowAssignedPartNumber(workflow.Workflow_Id);
                if (string.IsNullOrEmpty(partNumber))
                {
                    MessageBox.Show($"Couldn't find part number assignment for {workflow.Workflow_Id}");
                    continue;
                }

                var partDesc = _repo.Get<Ecms_Part>("Part_Nbr", partNumber).SingleOrDefault()?.Part_Dsc;
                if (string.IsNullOrEmpty(partDesc))
                {
                    MessageBox.Show($"Couldn't find an ECMS part description for {partNumber}");
                    continue;
                }

                _repo.UpdateWorkflowAndFieldAssignmentNodeWithPartDescription(workflow.Workflow_Id, partDesc);
                MessageBox.Show($"Workflow {workflow.Workflow_Id} was updated with description:\r\n{partDesc}");
            }
        }
    }
}
