using System;

namespace Nautilus.Data
{
    public partial class Lims_Blob : NautilusEntity
    {
        public const string TableName = "Lims_Blob";
        public const string PrimaryKey = "Lims_Blob_Id";
        public const string SequenceName = "Sq_Lims_Blob";

        /// <summary>
        /// Gets or sets Lims_Blob_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Lims_Blob_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets Image_Quality, NUMBER(10) (null)
        /// </summary>
        public decimal? Image_Quality { get; set; }

        /// <summary>
        /// Gets or sets Blob_Size, NUMBER(22) (null)
        /// </summary>
        public decimal? Blob_Size { get; set; }

        /// <summary>
        /// Gets or sets Blob_Data, BLOB(4000) (null)
        /// </summary>
        public byte[] Blob_Data { get; set; }

    }
}
