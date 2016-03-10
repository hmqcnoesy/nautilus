using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockNautilus
{

    class MockExtensionParameters : LSEXT.LSExtensionParameters
    {
        public string Product { get; set; }
        public string Version { get; set; }
        public string Server { get; set; }
        public string ComputerName { get; set; }
        public string HKeyCurrentUser { get; set; }
        public string HKeyLocalMachine { get; set; }
        public string OperatorName { get; set; }
        public string RoleName { get; set; }
        public decimal OperatorId { get; set; }
        public decimal RoleId { get; set; }
        public decimal WorkstationId { get; set; }
        public decimal SessionId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ServerInfo { get; set; }

        public decimal? EntityId { get; set; }
        public ADODB.Recordset EntityRecords { get; set; }

        public decimal? WorkflowId { get; set; }
        public decimal? WorkflowNodeId { get; set; }
        public string WorkflowTableName { get; set; }
        public string WorkflowPrimaryKey { get; set; }
        public bool? WorkflowIsInteractive { get; set; }

        dynamic LSEXT.IExtensionParametersEx.this[string Key]
        {
            get
            {
                if (Key == "PRODUCT") return Product;
                if (Key == "VERSION") return Version;
                if (Key == "SERVER") return Server;
                if (Key == "COMPUTER_NAME") return ComputerName;
                if (Key == "HKEY_CURRENT_USER") return HKeyCurrentUser;
                if (Key == "HKEY_LOCAL_MACHINE") return HKeyLocalMachine;
                if (Key == "OPERATOR_NAME") return OperatorName;
                if (Key == "ROLE_NAME") return RoleName;
                if (Key == "OPERATOR_ID") return OperatorId;
                if (Key == "ROLE_ID") return RoleId;
                if (Key == "WORKSTATION_ID") return WorkstationId;
                if (Key == "SESSION_ID") return SessionId;
                if (Key == "USERNAME") return Username;
                if (Key == "PASSWORD") return Password;
                if (Key == "SERVER_INFO") return ServerInfo;
                if (Key == "ENTITY_ID") return EntityId;
                if (Key == "RECORDS") return EntityRecords;
                if (Key == "WORKFLOW_ID") return WorkflowId;
                if (Key == "WORKFLOW_NODE_ID") return WorkflowNodeId;
                if (Key == "TABLE_NAME") return WorkflowTableName;
                if (Key == "PRIMARY_KEY") return WorkflowPrimaryKey;
                if (Key == "INTERACTIVE") return WorkflowIsInteractive;
                throw new ArgumentException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void LSEXT.IExtensionParametersEx.Add(string Key, object Value)
        {
            throw new NotImplementedException();
        }

        int LSEXT.IExtensionParametersEx.Count
        {
            get { throw new NotImplementedException(); }
        }

        System.Collections.IEnumerator LSEXT.IExtensionParametersEx.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        LSEXT.LSExtensionParameter LSEXT.IExtensionParametersEx.Parameter(string Key)
        {
            throw new NotImplementedException();
        }

        void LSEXT.IExtensionParametersEx.Remove(string Key)
        {
            throw new NotImplementedException();
        }

        void LSEXT.IExtensionParametersEx.RemoveAll()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}