using System;

namespace Nautilus.Data
{
    public partial class Stored_Report_ : NautilusEntity
    {
        public const string TableName = "Stored_Report";
        public const string PrimaryKey = "Stored_Report_Id";
        public const string SequenceName = "Sq_Stored_Report";

        /// <summary>
        /// Gets or sets Stored_Report_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stored_Report_Id { get; set; }

        /// <summary>
        /// Gets or sets Report_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Report_Id { get; set; }

        /// <summary>
        /// Gets or sets Stored_Report, LONG RAW(0) (null)
        /// </summary>
        public byte[] Stored_Report { get; set; }

        /// <summary>
        /// Gets or sets Reported_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Reported_By { get; set; }

        /// <summary>
        /// Gets or sets Reported_On, DATE (null)
        /// </summary>
        public DateTime? Reported_On { get; set; }

        /// <summary>
        /// Gets or sets Stored_Report_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Stored_Report_Name { get; set; }

        /// <summary>
        /// Gets or sets Stored_Report_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Stored_Report_Type { get; set; }

    }
}
