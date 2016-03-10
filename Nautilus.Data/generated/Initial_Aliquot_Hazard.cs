using System;

namespace Nautilus.Data
{
    public partial class Initial_Aliquot_Hazard : NautilusEntity
    {
        public const string TableName = "Initial_Aliquot_Hazard";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Template_Id { get; set; }

    }
}
