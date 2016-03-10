using System;

namespace Nautilus.Data
{
    public partial class Location_Hazard : NautilusEntity
    {
        public const string TableName = "Location_Hazard";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Location_Id { get; set; }

    }
}
