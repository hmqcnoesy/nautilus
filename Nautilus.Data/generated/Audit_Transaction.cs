using System;

namespace Nautilus.Data
{
    public partial class Audit_Transaction : NautilusEntity
    {
        public const string TableName = "Audit_Transaction";
        public const string PrimaryKey = "Audit_Transaction_Id";
        public const string SequenceName = "Sq_Audit_Transaction";

        /// <summary>
        /// Gets or sets Audit_Transaction_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Audit_Transaction_Id { get; set; }

        /// <summary>
        /// Gets or sets Timestamp, DATE (null)
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Transaction_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Transaction_Name { get; set; }

        /// <summary>
        /// Gets or sets Transaction_Reason, VARCHAR2(4000) (null)
        /// </summary>
        public string Transaction_Reason { get; set; }

    }
}
