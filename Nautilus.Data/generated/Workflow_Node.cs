using System;

namespace Nautilus.Data
{
    public partial class Workflow_Node : NautilusEntity
    {
        public const string TableName = "Workflow_Node";
        public const string PrimaryKey = "Workflow_Node_Id";
        public const string SequenceName = "Sq_Workflow_Node";

        /// <summary>
        /// Gets or sets Workflow_Node_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Extra, VARCHAR2(255) (null)
        /// </summary>
        public string Extra { get; set; }

        /// <summary>
        /// Gets or sets Events, VARCHAR2(4000) (null)
        /// </summary>
        public string Events { get; set; }

        /// <summary>
        /// Gets or sets Usage, VARCHAR2(255) (null)
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Prompt_Type, CHAR(1) (null)
        /// </summary>
        public string Workflow_Prompt_Type { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Prompt_Column, VARCHAR2(30) (null)
        /// </summary>
        public string Workflow_Prompt_Column { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Level, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Level { get; set; }

        /// <summary>
        /// Gets or sets Template, NUMBER(10) (null)
        /// </summary>
        public decimal? Template { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Long_Name, VARCHAR2(4000) (null)
        /// </summary>
        public string Long_Name { get; set; }

        /// <summary>
        /// Gets or sets Parameter_1, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_1 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_2, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_2 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_3, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_3 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_4, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_4 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_5, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_5 { get; set; }

    }
}
