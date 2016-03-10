using System;

namespace Nautilus.Data
{
    public partial class Pbcatfmt : NautilusEntity
    {
        public const string TableName = "Pbcatfmt";

        /// <summary>
        /// Gets or sets Pbf_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Pbf_Name { get; set; }

        /// <summary>
        /// Gets or sets Pbf_Frmt, VARCHAR2(254) (null)
        /// </summary>
        public string Pbf_Frmt { get; set; }

        /// <summary>
        /// Gets or sets Pbf_Type, NUMBER(22) (not null)
        /// </summary>
        public decimal Pbf_Type { get; set; }

        /// <summary>
        /// Gets or sets Pbf_Cntr, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbf_Cntr { get; set; }

    }
}
