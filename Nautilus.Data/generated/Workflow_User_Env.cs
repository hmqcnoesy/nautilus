using System;

namespace Nautilus.Data
{
    public partial class Workflow_User_Env : NautilusEntity
    {
        public const string TableName = "Workflow_User";

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Id { get; set; }

    }
}
