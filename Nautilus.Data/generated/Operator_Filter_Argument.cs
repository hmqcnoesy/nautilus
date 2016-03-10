using System;

namespace Nautilus.Data
{
    public partial class Operator_Filter_Argument : NautilusEntity
    {
        public const string TableName = "Operator_Filter_Argument";
        public const string PrimaryKey = "Operator_Filter_Argument_Id";
        public const string SequenceName = "Sq_Operator_Filter_Argument";

        /// <summary>
        /// Gets or sets Operator_Filter_Argument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Filter_Argument_Id { get; set; }

        /// <summary>
        /// Gets or sets Filter_Argument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Filter_Argument_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Value_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Value_Number { get; set; }

        /// <summary>
        /// Gets or sets Value_Text, VARCHAR2(4000) (null)
        /// </summary>
        public string Value_Text { get; set; }

        /// <summary>
        /// Gets or sets Value_Date, DATE (null)
        /// </summary>
        public DateTime? Value_Date { get; set; }

    }
}
