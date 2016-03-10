using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Template : NautilusEntity
    {
        public const string TableName = "Worksheet_Template";
        public const string PrimaryKey = "Worksheet_Template_Id";
        public const string SequenceName = "Sq_Worksheet_Template";

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Id { get; set; }

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
        /// Gets or sets Worksheet_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Worksheet_Type { get; set; }

        /// <summary>
        /// Gets or sets Session_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Session_Count { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Count_Min, NUMBER(10) (null)
        /// </summary>
        public decimal? Aliquot_Count_Min { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Count_Max, NUMBER(10) (null)
        /// </summary>
        public decimal? Aliquot_Count_Max { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Repeat_Section_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Repeat_Section_Count { get; set; }

        /// <summary>
        /// Gets or sets Repeat_Section_Action, VARCHAR2(255) (null)
        /// </summary>
        public string Repeat_Section_Action { get; set; }

        /// <summary>
        /// Gets or sets Auto_Build, CHAR(1) (null)
        /// </summary>
        public string Auto_Build { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

    }
}
