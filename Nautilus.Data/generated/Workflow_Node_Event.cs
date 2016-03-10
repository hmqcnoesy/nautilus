using System;

namespace Nautilus.Data
{
    public partial class Workflow_Node_Event : NautilusEntity
    {
        public const string TableName = "Workflow_Node_Event";

        /// <summary>
        /// Gets or sets Workflow_Node_Event_Id, CHAR(1) (not null)
        /// </summary>
        public string Workflow_Node_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Allow_Multiple, CHAR(1) (null)
        /// </summary>
        public string Allow_Multiple { get; set; }

    }
}
