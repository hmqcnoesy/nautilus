using System;

namespace Nautilus.Data
{
    public partial class Unit_Cache : NautilusEntity
    {
        public const string TableName = "Unit_Cache";

        /// <summary>
        /// Gets or sets From_Unit, VARCHAR2(255) (not null)
        /// </summary>
        public string From_Unit { get; set; }

        /// <summary>
        /// Gets or sets To_Unit, VARCHAR2(255) (not null)
        /// </summary>
        public string To_Unit { get; set; }

        /// <summary>
        /// Gets or sets Conversion_Factor, NUMBER(22) (not null)
        /// </summary>
        public decimal Conversion_Factor { get; set; }

    }
}
