using System;

namespace Nautilus.Data
{
    public partial class Operator_Filter : NautilusEntity
    {
        public const string TableName = "Operator_Filter";
        public const string PrimaryKey = "Operator_Filter_Id";
        public const string SequenceName = "Sq_Operator_Filter";

        /// <summary>
        /// Gets or sets Operator_Filter_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Store_Arguments, CHAR(1) (null)
        /// </summary>
        public string Store_Arguments { get; set; }

        /// <summary>
        /// Gets or sets Auto_Prompt, CHAR(1) (null)
        /// </summary>
        public string Auto_Prompt { get; set; }

    }
}
