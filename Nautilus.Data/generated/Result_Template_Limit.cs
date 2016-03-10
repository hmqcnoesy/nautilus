using System;

namespace Nautilus.Data
{
    public partial class Result_Template_Limit : NautilusEntity
    {
        public const string TableName = "Result_Template_Limit";
        public const string PrimaryKey = "Result_Template_Limit_Id";
        public const string SequenceName = "Sq_Result_Template_Limit";

        /// <summary>
        /// Gets or sets Result_Template_Limit_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Template_Limit_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Result_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Is_Lower, CHAR(1) (null)
        /// </summary>
        public string Is_Lower { get; set; }

        /// <summary>
        /// Gets or sets Significant_Figures, NUMBER(22) (null)
        /// </summary>
        public decimal? Significant_Figures { get; set; }

        /// <summary>
        /// Gets or sets Format, VARCHAR2(255) (null)
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets Numeric_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Numeric_Limit { get; set; }

    }
}
