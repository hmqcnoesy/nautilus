using System;

namespace Nautilus.Data
{
    public partial class Audit_Field : NautilusEntity
    {
        public const string TableName = "Audit_Field";

        /// <summary>
        /// Gets or sets Audit_Table_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Audit_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Config_Field, VARCHAR2(30) (not null)
        /// </summary>
        public string Audit_Config_Field { get; set; }

        /// <summary>
        /// Gets or sets Trigger_Field, CHAR(1) (null)
        /// </summary>
        public string Trigger_Field { get; set; }

        /// <summary>
        /// Gets or sets Record_Field, CHAR(1) (null)
        /// </summary>
        public string Record_Field { get; set; }

        /// <summary>
        /// Gets or sets New_Value, VARCHAR2(4000) (null)
        /// </summary>
        public string New_Value { get; set; }

        /// <summary>
        /// Gets or sets Old_Value, VARCHAR2(4000) (null)
        /// </summary>
        public string Old_Value { get; set; }

    }
}
