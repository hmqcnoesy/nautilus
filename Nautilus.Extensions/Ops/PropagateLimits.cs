using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSEXT;
using Nautilus.DataAccess;
using Nautilus.Data;

namespace Nautilus.Extensions.Ops
{
    public class PropagateLimits : LSEXT.IEntityExtension, LSEXT.IWorkflowExtension, LSEXT.IVersion
    {
        private SampleRepo _repo;
        private ExtensionContext _ctx;


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
            _ctx = new ExtensionContext(parameters);
            if (!_ctx.IsEntityOfType("Sample"))
            {
                _ctx.ShowOrLogMessage("Can execute this extension only on samples.");
            }

            foreach(var sampleId in _ctx.EntityIds)
            {
                PropagateResultLimits(sampleId);
            }
        }


        void IWorkflowExtension.Execute(ref LSExtensionParameters parameters)
        {
            var _ctx = new ExtensionContext(parameters);
            if (!_ctx.IsWorkflowTable("Sample"))
            {
                _ctx.ShowOrLogMessage("Can execute this extension only on samples.");
                return;
            }

            PropagateResultLimits(_ctx.WorkflowPrimaryKeyNumeric);
        }


        void PropagateResultLimits(decimal sampleId)
        {
            _repo = new SampleRepo(_ctx.ServerInfo, _ctx.Username, _ctx.Password);
            var sample = _repo.GetHierarchy(sampleId);

            var mixEvaluation = sample.Name.Substring(4, 3);
            var evaluation = _repo.Get<U_Evaluation_Ops>("Name", mixEvaluation).SingleOrDefault();

            if (evaluation == null)
            {
                _ctx.ShowOrLogMessage($"Evaluation {mixEvaluation} not found, cannot determine limits for sample {sampleId}");
                return;
            }

            var evaluationUser = _repo.Get<U_Evaluation_User_Ops>(evaluation.U_Evaluation_Id);
            var results = sample.GetResultsProgeny();
            var resultUsers = _repo.Get<Result_User_Ops>(results.Select(r => r.Result_Id));

            foreach (var result in resultUsers)
            {
                var resultName = results.Single(r => r.Result_Id == result.Result_Id).Name;
                SetResultLimits(resultName, result, evaluationUser);
                _repo.Update(result, new[] { "U_Target", "U_Max_Below_Target", "U_Max_Above_Target" });
            }
        }


        private void SetResultLimits(string resultName, Result_User_Ops result, U_Evaluation_User_Ops evaluation)
        {
            switch (resultName)
            {
                case "Burn Rate":
                    result.U_Target = evaluation.U_Lsbr_Target;
                    result.U_Max_Below_Target = evaluation.U_Lsbr_Target - 0.023m;
                    result.U_Max_Above_Target = evaluation.U_Lsbr_Target + 0.023m;
                    break;
                case "HB (Liquid Fraction)":
                    result.U_Target = evaluation.U_Hb_Target;
                    result.U_Max_Below_Target = evaluation.U_Hb_Target - 0.50m;
                    result.U_Max_Above_Target = evaluation.U_Hb_Target + 0.50m;
                    break;
                case "Iron Oxide":
                    result.U_Target = evaluation.U_Iron_Oxide_Target;
                    result.U_Max_Below_Target = evaluation.U_Iron_Oxide_Target - 0.030m;
                    result.U_Max_Above_Target = evaluation.U_Iron_Oxide_Target + 0.030m;
                    break;
                case "Al + Fe":
                    result.U_Target = evaluation.U_Iron_Oxide_Target + 16.00m;
                    result.U_Max_Below_Target = evaluation.U_Iron_Oxide_Target + 15.90m;
                    result.U_Max_Above_Target = evaluation.U_Iron_Oxide_Target + 16.30m;
                    break;
                case "Total Solids":
                    result.U_Target = 86.00m;
                    result.U_Max_Below_Target = 85.50m;
                    result.U_Max_Above_Target = 86.50m;
                    break;
                default:
                    break;
            }
        }
    }
}
