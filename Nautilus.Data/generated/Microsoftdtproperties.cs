using System;

namespace Nautilus.Data
{
    public partial class Microsoftdtproperties : NautilusEntity
    {
        public const string TableName = "Microsoftdtproperties";

        /// <summary>
        /// Gets or sets Id, NUMBER(22) (not null)
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Gets or sets Objectid, NUMBER(22) (null)
        /// </summary>
        public decimal? Objectid { get; set; }

        /// <summary>
        /// Gets or sets Property, VARCHAR2(64) (not null)
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets Value, VARCHAR2(255) (null)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets Lvalue, LONG RAW(0) (null)
        /// </summary>
        public byte[] Lvalue { get; set; }

        /// <summary>
        /// Gets or sets Version, NUMBER(22) (not null)
        /// </summary>
        public decimal Version { get; set; }

    }
}
