using System;

namespace Nautilus.Data
{
    public partial class Audit_Data : NautilusEntity
    {
        public const string TableName = "Audit_Data";

        /// <summary>
        /// Gets or sets Audit_Event_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Audit_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Field, VARCHAR2(30) (not null)
        /// </summary>
        public string Audit_Field { get; set; }

        /// <summary>
        /// Gets or sets New_Value, VARCHAR2(4000) (null)
        /// </summary>
        public string New_Value { get; set; }

        /// <summary>
        /// Gets or sets Old_Value, VARCHAR2(4000) (null)
        /// </summary>
        public string Old_Value { get; set; }

        /// <summary>
        /// Gets or sets Data_Reason, VARCHAR2(4000) (null)
        /// </summary>
        public string Data_Reason { get; set; }

    }
}
