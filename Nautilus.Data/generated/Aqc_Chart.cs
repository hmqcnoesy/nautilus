using System;

namespace Nautilus.Data
{
    public partial class Aqc_Chart : NautilusEntity
    {
        public const string TableName = "Aqc_Chart";
        public const string PrimaryKey = "Aqc_Chart_Id";
        public const string SequenceName = "Sq_Aqc_Chart";

        /// <summary>
        /// Gets or sets Aqc_Chart_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Chart_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Aliquot_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Aliquot_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Result_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Id { get; set; }

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
        /// Gets or sets Target, NUMBER(22) (null)
        /// </summary>
        public decimal? Target { get; set; }

        /// <summary>
        /// Gets or sets Precision, NUMBER(22) (null)
        /// </summary>
        public decimal? Precision { get; set; }

        /// <summary>
        /// Gets or sets Bias, NUMBER(22) (null)
        /// </summary>
        public decimal? Bias { get; set; }

        /// <summary>
        /// Gets or sets Chart_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Chart_Type { get; set; }

        /// <summary>
        /// Gets or sets Warning_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Warning_Limit { get; set; }

        /// <summary>
        /// Gets or sets Action_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Action_Limit { get; set; }

        /// <summary>
        /// Gets or sets Subgroup_Size, NUMBER(16) (null)
        /// </summary>
        public decimal? Subgroup_Size { get; set; }

        /// <summary>
        /// Gets or sets Block_Size, NUMBER(16) (null)
        /// </summary>
        public decimal? Block_Size { get; set; }

        /// <summary>
        /// Gets or sets Limit_Method, VARCHAR2(255) (null)
        /// </summary>
        public string Limit_Method { get; set; }

        /// <summary>
        /// Gets or sets Limit_Parameter, NUMBER(16) (null)
        /// </summary>
        public decimal? Limit_Parameter { get; set; }

    }
}
