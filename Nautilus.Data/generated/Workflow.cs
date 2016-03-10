using System;

namespace Nautilus.Data
{
    public partial class Workflow : NautilusEntity
    {
        public const string TableName = "Workflow";
        public const string PrimaryKey = "Workflow_Id";
        public const string SequenceName = "Sq_Workflow";

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Classification, VARCHAR2(255) (null)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

    }
}
