using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Template_Result : NautilusEntity
    {
        public const string TableName = "Worksheet_Template_Result";

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Session, NUMBER(22) (not null)
        /// </summary>
        public decimal Worksheet_Template_Session { get; set; }

        /// <summary>
        /// Gets or sets Result_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Template_Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Result, CHAR(1) (null)
        /// </summary>
        public string Aqc_Result { get; set; }

    }
}
