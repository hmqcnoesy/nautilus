using System;

namespace Nautilus.Data
{
    public partial class Audit_Table : NautilusEntity
    {
        public const string TableName = "Audit_Table";
        public const string PrimaryKey = "Audit_Table_Id";
        public const string SequenceName = "Sq_Audit_Table";

        /// <summary>
        /// Gets or sets Audit_Table_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Audit_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Config_Table, VARCHAR2(30) (not null)
        /// </summary>
        public string Audit_Config_Table { get; set; }

        /// <summary>
        /// Gets or sets Event_Type, CHAR(1) (not null)
        /// </summary>
        public string Event_Type { get; set; }

        /// <summary>
        /// Gets or sets Alerted, CHAR(1) (null)
        /// </summary>
        public string Alerted { get; set; }

        /// <summary>
        /// Gets or sets Build_Trigger, CHAR(1) (null)
        /// </summary>
        public string Build_Trigger { get; set; }

        /// <summary>
        /// Gets or sets Create_Note, CHAR(1) (null)
        /// </summary>
        public string Create_Note { get; set; }

        /// <summary>
        /// Gets or sets Audit_Prompt, CHAR(1) (null)
        /// </summary>
        public string Audit_Prompt { get; set; }

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Destination_Id { get; set; }

    }
}
