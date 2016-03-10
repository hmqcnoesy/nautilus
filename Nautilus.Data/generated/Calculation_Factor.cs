using System;

namespace Nautilus.Data
{
    public partial class Calculation_Factor : NautilusEntity
    {
        public const string TableName = "Calculation_Factor";
        public const string PrimaryKey = "Calculation_Factor_Id";
        public const string SequenceName = "Sq_Calculation_Factor";

        /// <summary>
        /// Gets or sets Calculation_Factor_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calculation_Factor_Id { get; set; }

        /// <summary>
        /// Gets or sets Table_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Table_Name { get; set; }

        /// <summary>
        /// Gets or sets Record_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Record_Id { get; set; }

        /// <summary>
        /// Gets or sets Factor_Value, NUMBER(22) (null)
        /// </summary>
        public decimal? Factor_Value { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Factor_Type, CHAR(1) (null)
        /// </summary>
        public string Calculation_Factor_Type { get; set; }

        /// <summary>
        /// Gets or sets Factor_Text_Value, VARCHAR2(4000) (null)
        /// </summary>
        public string Factor_Text_Value { get; set; }

        /// <summary>
        /// Gets or sets Factor_Datetime_Value, DATE (null)
        /// </summary>
        public DateTime? Factor_Datetime_Value { get; set; }

    }
}
