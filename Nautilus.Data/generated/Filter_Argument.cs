using System;

namespace Nautilus.Data
{
    public partial class Filter_Argument : NautilusEntity
    {
        public const string TableName = "Filter_Argument";
        public const string PrimaryKey = "Filter_Argument_Id";
        public const string SequenceName = "Sq_Filter_Argument";

        /// <summary>
        /// Gets or sets Filter_Argument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Filter_Argument_Id { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (not null)
        /// </summary>
        public decimal Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Argument_Type, VARCHAR2(255) (not null)
        /// </summary>
        public string Argument_Type { get; set; }

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

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Prompt_For_Value, CHAR(1) (not null)
        /// </summary>
        public string Prompt_For_Value { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Phrase_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Replace_With, VARCHAR2(1000) (null)
        /// </summary>
        public string Replace_With { get; set; }

    }
}
