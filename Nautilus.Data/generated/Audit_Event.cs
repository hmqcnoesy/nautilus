using System;

namespace Nautilus.Data
{
    public partial class Audit_Event : NautilusEntity
    {
        public const string TableName = "Audit_Event";
        public const string PrimaryKey = "Audit_Event_Id";
        public const string SequenceName = "Sq_Audit_Event";

        /// <summary>
        /// Gets or sets Audit_Event_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Audit_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Transaction_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Audit_Transaction_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Table, VARCHAR2(30) (null)
        /// </summary>
        public string Audit_Table { get; set; }

        /// <summary>
        /// Gets or sets Event_Type, CHAR(1) (null)
        /// </summary>
        public string Event_Type { get; set; }

        /// <summary>
        /// Gets or sets Alerted, CHAR(1) (null)
        /// </summary>
        public string Alerted { get; set; }

        /// <summary>
        /// Gets or sets Audit_Prompt, CHAR(1) (null)
        /// </summary>
        public string Audit_Prompt { get; set; }

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Table_Varchar_Key, VARCHAR2(255) (null)
        /// </summary>
        public string Audit_Table_Varchar_Key { get; set; }

        /// <summary>
        /// Gets or sets Audit_Table_Date_Key, DATE (null)
        /// </summary>
        public DateTime? Audit_Table_Date_Key { get; set; }

        /// <summary>
        /// Gets or sets Parent_Event_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Table_Numeric_Key, NUMBER(16) (null)
        /// </summary>
        public decimal? Audit_Table_Numeric_Key { get; set; }

    }
}
