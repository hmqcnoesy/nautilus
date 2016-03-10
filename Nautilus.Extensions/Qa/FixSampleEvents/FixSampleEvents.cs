using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSEXT;
using System.Windows.Forms;
using Nautilus.DataAccess;
using Nautilus.Data;

namespace Nautilus.Extensions.Qa
{
    public class FixSampleEvents : LSEXT.IEntityExtension, LSEXT.IVersion
    {
        int IVersion.GetVersion()
        {
            return 4101;
        }


        ExecuteExtension IEntityExtension.CanExecute(ref IExtensionParameters parameters)
        {
            return ExecuteExtension.exEnabled;
        }


        void IEntityExtension.Execute(ref LSExtensionParameters parameters)
        {
            var exctx = new ExtensionContext(parameters);

            if (!exctx.IsEntityOfType("Sample"))
            {
                MessageBox.Show("This extension runs only on sample entities.");
                return;
            }

            var repo = new NautilusEntityRepo(exctx.ServerInfo, exctx.Username, exctx.Password);

            var sbEvents = string.Empty;

            foreach (var sampleId in exctx.EntityIds)
            {
                var sample = repo.Get<Sample>(sampleId);
                var wfNodes = repo.Get<Workflow_Node>("Parent_Id", sample.Workflow_Node_Id);

                foreach (var n in wfNodes)
                {
                    if (string.IsNullOrEmpty(n.Events)) continue;

                    sbEvents += $"({n.Events}-{n.Name},{n.Workflow_Id},{n.Order_Number},{n.Parameter_3},{n.Parameter_4})";
                }

                sample.Events = sbEvents;
                repo.Update(sample, "Events");
            }
        }
    }
}
