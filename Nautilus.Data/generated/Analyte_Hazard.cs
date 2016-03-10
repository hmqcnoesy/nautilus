using System;

namespace Nautilus.Data
{
    public partial class Analyte_Hazard : NautilusEntity
    {
        public const string TableName = "Analyte_Hazard";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Analyte_Id { get; set; }

    }
}
