using System;

namespace Nautilus.Data
{
    public partial class Signature_Entry : NautilusEntity
    {
        public const string TableName = "Signature_Entry";
        public const string PrimaryKey = "Signature_Entry_Id";
        public const string SequenceName = "Sq_Signature_Entry";

        /// <summary>
        /// Gets or sets Signature_Entry_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Signature_Entry_Id { get; set; }

        /// <summary>
        /// Gets or sets Signature_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Signature_Id { get; set; }

        /// <summary>
        /// Gets or sets Signature_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Signature_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Entry_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Entry_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Entry_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Schema_Entity_Entry_Name { get; set; }

        /// <summary>
        /// Gets or sets Checksum, VARCHAR2(40) (null)
        /// </summary>
        public string Checksum { get; set; }

    }
}
