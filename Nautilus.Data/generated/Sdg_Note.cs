using System;

namespace Nautilus.Data
{
    public partial class Sdg_Note : NautilusEntity
    {
        public const string TableName = "Sdg_Note";
        public const string PrimaryKey = "Note_Entry_Id";
        public const string SequenceName = "Sq_Sdg_Note";

        /// <summary>
        /// Gets or sets Note_Entry_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Note_Entry_Id { get; set; }

        /// <summary>
        /// Gets or sets Sdg_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sdg_Id { get; set; }

        /// <summary>
        /// Gets or sets Entry_Date, DATE (not null)
        /// </summary>
        public DateTime Entry_Date { get; set; }

        /// <summary>
        /// Gets or sets Note_Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Note_Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Entry_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Entry_Type { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Attachment_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Attachment_Id { get; set; }

        /// <summary>
        /// Gets or sets Audit_Entry_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Audit_Entry_Id { get; set; }

        /// <summary>
        /// Gets or sets Subject, VARCHAR2(255) (null)
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets Details, LONG RAW(0) (null)
        /// </summary>
        public byte[] Details { get; set; }

        /// <summary>
        /// Gets or sets System_Type, CHAR(1) (null)
        /// </summary>
        public string System_Type { get; set; }

        /// <summary>
        /// Gets or sets Web_Address, VARCHAR2(4000) (null)
        /// </summary>
        public string Web_Address { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Signature_Entry_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Signature_Entry_Id { get; set; }

    }
}
