using System;

namespace Nautilus.Data
{
    public partial class Signature_Template_Field : NautilusEntity
    {
        public const string TableName = "Signature_Template_Field";
        public const string PrimaryKey = "Signature_Template_Field_Id";
        public const string SequenceName = "Sq_Signature_Template_Field";

        /// <summary>
        /// Gets or sets Signature_Template_Field_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Signature_Template_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Signature_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Signature_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

    }
}
