using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Aliquot_Type : NautilusEntity
    {
        public const string TableName = "Worksheet_Aliquot_Type";
        public const string PrimaryKey = "Worksheet_Aliquot_Type_Id";
        public const string SequenceName = "Sq_Worksheet_Aliquot_Type";

        /// <summary>
        /// Gets or sets Worksheet_Aliquot_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Aliquot_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

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
        /// Gets or sets Uses_Standard, CHAR(1) (null)
        /// </summary>
        public string Uses_Standard { get; set; }

        /// <summary>
        /// Gets or sets Display_Colour, NUMBER(10) (null)
        /// </summary>
        public decimal? Display_Colour { get; set; }

        /// <summary>
        /// Gets or sets Uses_Sample, CHAR(1) (null)
        /// </summary>
        public string Uses_Sample { get; set; }

        /// <summary>
        /// Gets or sets Usage, VARCHAR2(255) (null)
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Amount, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets Link_Stock, CHAR(1) (null)
        /// </summary>
        public string Link_Stock { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Control, CHAR(1) (null)
        /// </summary>
        public string Aqc_Control { get; set; }

    }
}
