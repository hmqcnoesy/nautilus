using System;

namespace Nautilus.Data
{
    public partial class Report_Argument : NautilusEntity
    {
        public const string TableName = "Report_Argument";
        public const string PrimaryKey = "Report_Argument_Id";
        public const string SequenceName = "Sq_Report_Argument";

        /// <summary>
        /// Gets or sets Report_Argument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Report_Argument_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Argument_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Argument_Type { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Info_Num1, NUMBER(22) (null)
        /// </summary>
        public decimal? Info_Num1 { get; set; }

        /// <summary>
        /// Gets or sets Info_Text1, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text1 { get; set; }

        /// <summary>
        /// Gets or sets Prompt_For_Argument, CHAR(1) (null)
        /// </summary>
        public string Prompt_For_Argument { get; set; }

    }
}
