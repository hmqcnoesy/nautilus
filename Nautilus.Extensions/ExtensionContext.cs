using Nautilus.Data;
using Nautilus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSEXT;

namespace Nautilus.Extensions
{
    public class ExtensionContext
    {
        private NautilusEntityRepo _repo;
        public string Product { get; private set; }
        public string Version { get; private set; }
        public string Server { get; private set; }
        public string ComputerName { get; private set; }
        public string HKeyCurrentUser { get; private set; }
        public string HKeyLocalMachine { get; private set; }
        public string OperatorName { get; private set; }
        public string RoleName { get; private set; }
        public decimal OperatorId { get; private set; }
        public decimal RoleId { get; private set; }
        public decimal WorkstationId { get; private set; }
        public decimal SessionId { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string ServerInfo { get; private set; }

        public decimal? EntityTypeId { get; private set; }
        public List<decimal> EntityIds { get; private set; }

        public decimal? WorkflowId { get; private set; }
        public decimal? WorkflowNodeId { get; private set; }
        public string WorkflowTableName { get; private set; }
        public string WorkflowPrimaryKey { get; private set; }
        public decimal WorkflowPrimaryKeyNumeric { get; private set; }
        public bool? WorkflowIsInteractive { get; private set; }


        public ExtensionContext(LSEXT.LSExtensionParameters parameters)
        {
            InitializeContext(parameters);
            _repo = new NautilusEntityRepo(this.ServerInfo, this.Username, this.Password);
        }


        private void InitializeContext(LSEXT.LSExtensionParameters parameters)
        {
            PopulateGenericExtensionProperties(parameters);
            PopulateWorkflowExtensionProperties(parameters);
            PopulateEntityExtensionProperties(parameters);
        }


        private void PopulateGenericExtensionProperties(LSExtensionParameters parameters)
        {
            this.Product = parameters["PRODUCT"].ToString();
            this.Version = parameters["VERSION"].ToString();
            this.Server = parameters["SERVER"].ToString();
            this.ComputerName = parameters["COMPUTER_NAME"].ToString();
            this.HKeyCurrentUser = parameters["HKEY_CURRENT_USER"].ToString();
            this.HKeyLocalMachine = parameters["HKEY_LOCAL_MACHINE"].ToString();
            this.OperatorName = parameters["OPERATOR_NAME"].ToString();
            this.RoleName = parameters["ROLE_NAME"].ToString();
            this.OperatorId = decimal.Parse(parameters["OPERATOR_ID"].ToString());
            this.RoleId = decimal.Parse(parameters["ROLE_ID"].ToString());
            this.WorkstationId = decimal.Parse(parameters["WORKSTATION_ID"].ToString());
            this.SessionId = decimal.Parse(parameters["SESSION_ID"].ToString());
            this.Username = parameters["USERNAME"].ToString();
            this.Password = parameters["PASSWORD"].ToString();
            this.ServerInfo = parameters["SERVER_INFO"].ToString();
        }


        private void PopulateEntityExtensionProperties(LSExtensionParameters parameters)
        {
            try
            {
                this.EntityTypeId = decimal.Parse(parameters["ENTITY_ID"].ToString());
            }
            catch (ArgumentException)
            {
                return; // if ENTITY_ID key doesn't exist, it's not an entity extension
            }

            ADODB.Recordset records = (ADODB.Recordset)parameters["RECORDS"];
            this.EntityIds = new List<decimal>();
            while (!records.EOF)
            {
                this.EntityIds.Add(decimal.Parse(records.Fields[0].Value.ToString()));
                records.MoveNext();
            }
        }


        private void PopulateWorkflowExtensionProperties(LSExtensionParameters parameters)
        {
            try
            {
                this.WorkflowId = decimal.Parse(parameters["WORKFLOW_ID"].ToString());
            }
            catch (ArgumentException)
            {
                return; // if WORKFLOW_ID key doesn't exist, it's not a workflow extension
            }

            this.WorkflowNodeId = decimal.Parse(parameters["WORKFLOW_NODE_ID"].ToString());
            this.WorkflowTableName = parameters["TABLE_NAME"].ToString();
            this.WorkflowPrimaryKey = parameters["PRIMARY_KEY"].ToString();
            this.WorkflowIsInteractive = parameters["INTERACTIVE"] == null ? null : (bool?)(parameters["INTERACTIVE"].ToString() == "1");
            decimal d;
            if (decimal.TryParse(this.WorkflowPrimaryKey, out d)) this.WorkflowPrimaryKeyNumeric = d;
        }


        public bool IsEntityOfType(string entityName)
        {
            if (!this.EntityTypeId.HasValue) return false;
            var entity = _repo.Get<Schema_Entity>(this.EntityTypeId.Value);
            return entity.Name.Equals(entityName, StringComparison.CurrentCultureIgnoreCase);
        }


        public bool IsOperatorInRole(string roleName)
        {
            return this.RoleName.Equals(roleName, StringComparison.CurrentCultureIgnoreCase);
        }


        public bool IsOperatorInOneOfTheseRoles(List<string> roleNames)
        {
            return roleNames.Contains(this.RoleName);
        }


        public bool IsWorkflowTable(string tableName)
        {
            return this.WorkflowTableName.ToLower() == tableName.ToLower();
        }


        internal void ShowOrLogMessage(string message)
        {
            if (this.WorkflowIsInteractive.HasValue && this.WorkflowIsInteractive.Value)
            {
                MessageBox.Show(message);
            }
            else
            {
                // TODO am I going to log this somewhere?  
            }
        }
    }
}
