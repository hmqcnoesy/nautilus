using System;

namespace Nautilus.Data
{
    public partial class Raw_Result : NautilusEntity
    {
        public const string TableName = "Raw_Result";

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Order_Number, NUMBER(22) (not null)
        /// </summary>
        public decimal Result_Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Dilution_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? Dilution_Factor { get; set; }

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
        /// Gets or sets Raw_Numeric_Result, NUMBER(22) (null)
        /// </summary>
        public decimal? Raw_Numeric_Result { get; set; }

        /// <summary>
        /// Gets or sets Bad_Point, CHAR(1) (null)
        /// </summary>
        public string Bad_Point { get; set; }

        /// <summary>
        /// Gets or sets Unit, VARCHAR2(255) (null)
        /// </summary>
        public string Unit { get; set; }

    }
}
