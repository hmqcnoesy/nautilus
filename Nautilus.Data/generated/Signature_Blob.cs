using System;

namespace Nautilus.Data
{
    public partial class Signature_Blob : NautilusEntity
    {
        public const string TableName = "Signature_Blob";
        public const string PrimaryKey = "Signature_Id";
        public const string SequenceName = "Sq_Signature_Blob";

        /// <summary>
        /// Gets or sets Signature_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Signature_Id { get; set; }

        /// <summary>
        /// Gets or sets Blob_Data, BLOB(4000) (null)
        /// </summary>
        public byte[] Blob_Data { get; set; }

    }
}
