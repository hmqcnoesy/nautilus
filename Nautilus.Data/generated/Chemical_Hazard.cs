using System;

namespace Nautilus.Data
{
    public partial class Chemical_Hazard : NautilusEntity
    {
        public const string TableName = "Chemical_Hazard";

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Chemical_Id { get; set; }

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

    }
}
