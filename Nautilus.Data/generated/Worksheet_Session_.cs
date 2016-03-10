using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Session_ : NautilusEntity
    {
        public const string TableName = "Worksheet_Session";
        public const string PrimaryKey = "Worksheet_Session_Id";
        public const string SequenceName = "Sq_Worksheet_Session";

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Session, NUMBER(22) (not null)
        /// </summary>
        public decimal Worksheet_Session { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Status, CHAR(1) (null)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Start_Date, DATE (null)
        /// </summary>
        public DateTime? Start_Date { get; set; }

        /// <summary>
        /// Gets or sets End_Date, DATE (null)
        /// </summary>
        public DateTime? End_Date { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Session, CHAR(1) (null)
        /// </summary>
        public string Aqc_Session { get; set; }

    }
}
