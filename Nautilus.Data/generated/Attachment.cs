using System;

namespace Nautilus.Data
{
    public partial class Attachment : NautilusEntity
    {
        public const string TableName = "Attachment";
        public const string PrimaryKey = "Attachment_Id";
        public const string SequenceName = "Sq_Attachment";

        /// <summary>
        /// Gets or sets Attachment_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Attachment_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Ole_Class, VARCHAR2(255) (null)
        /// </summary>
        public string Ole_Class { get; set; }

        /// <summary>
        /// Gets or sets Object_Data, LONG RAW(0) (null)
        /// </summary>
        public byte[] Object_Data { get; set; }

        /// <summary>
        /// Gets or sets Is_Raw_Data, CHAR(1) (null)
        /// </summary>
        public string Is_Raw_Data { get; set; }

        /// <summary>
        /// Gets or sets Raw_Data_Filename, VARCHAR2(255) (null)
        /// </summary>
        public string Raw_Data_Filename { get; set; }

    }
}
