using System;

namespace Nautilus.Data
{
    public partial class Signature : NautilusEntity
    {
        public const string TableName = "Signature";
        public const string PrimaryKey = "Signature_Id";
        public const string SequenceName = "Sq_Signature";

        /// <summary>
        /// Gets or sets Signature_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Signature_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Operator_Full_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Operator_Full_Name { get; set; }

        /// <summary>
        /// Gets or sets Server_Time, DATE (null)
        /// </summary>
        public DateTime? Server_Time { get; set; }

        /// <summary>
        /// Gets or sets Client_Time, DATE (null)
        /// </summary>
        public DateTime? Client_Time { get; set; }

        /// <summary>
        /// Gets or sets Signature_Action, VARCHAR2(255) (null)
        /// </summary>
        public string Signature_Action { get; set; }

        /// <summary>
        /// Gets or sets Signature_Status, VARCHAR2(255) (null)
        /// </summary>
        public string Signature_Status { get; set; }

        /// <summary>
        /// Gets or sets Checksum, VARCHAR2(40) (null)
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or sets Signature_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Signature_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Session_Id { get; set; }

    }
}
