using System;

namespace Nautilus.Data
{
    public partial class Cofa_Template_Storage : NautilusEntity
    {
        public const string TableName = "Cofa_Template_Storage";

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Cofa_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cofa_Template_Id { get; set; }

    }
}
