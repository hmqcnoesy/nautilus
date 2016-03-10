using System;

namespace Nautilus.Data
{
    public partial class Step : NautilusEntity
    {
        public const string TableName = "Step";
        public const string PrimaryKey = "Step_Id";
        public const string SequenceName = "Sq_Step";

        /// <summary>
        /// Gets or sets Step_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Step_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Node_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (not null)
        /// </summary>
        public string Name { get; set; }

    }
}
