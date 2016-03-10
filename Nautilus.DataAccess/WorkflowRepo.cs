using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nautilus.DataAccess
{
    public class WorkflowRepo : NautilusEntityRepo
    {
        public WorkflowRepo(string connectionString) : base(connectionString)
        {
        }


        public WorkflowRepo(string dataSource, string userId, string password) : base(dataSource, userId, password)
        {
        }


        public string GetWorkflowAssignedPartNumber(decimal workflowId)
        {
            var sql = @"select parameter_2
                from lims_sys.workflow_node 
                where workflow_id = :id
                and workflow_prompt_column = 'U_PART_NUMBER'
                and parameter_3 = '160'";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                return connection.ExecuteScalar<string>(sql, new { id = workflowId });
            }
        }


        public void UpdateWorkflowAndFieldAssignmentNodeWithPartDescription(decimal workflowId, string description)
        {
            var sqlWfNode = @"update lims_sys.workflow_node set parameter_2 = :description 
                where workflow_id = :id
                and workflow_prompt_column = 'DESCRIPTION' 
                and parameter_3 = '28' 
                and parameter_5 = 'SAMPLE' ";

            var sqlWf = @"update lims_sys.workflow set description = :description
                where workflow_id = :id";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                this.SetLimsUserRole(connection);
                var tx = connection.BeginTransaction();

                try
                {
                    connection.Execute(sqlWfNode, new { description = description, id = workflowId }, tx);
                    connection.Execute(sqlWf, new { description = description, id = workflowId }, tx);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}
