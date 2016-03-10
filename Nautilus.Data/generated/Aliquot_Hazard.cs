using System;

namespace Nautilus.Data
{
    public partial class Aliquot_Hazard : NautilusEntity
    {
        public const string TableName = "Aliquot_Hazard";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

    }
}
