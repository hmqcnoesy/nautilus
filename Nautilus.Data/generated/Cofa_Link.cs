using System;

namespace Nautilus.Data
{
    public partial class Cofa_Link : NautilusEntity
    {
        public const string TableName = "Cofa_Link";

        /// <summary>
        /// Gets or sets Cofa_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cofa_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Cofa_Entity_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cofa_Entity_Item_Id { get; set; }

    }
}
