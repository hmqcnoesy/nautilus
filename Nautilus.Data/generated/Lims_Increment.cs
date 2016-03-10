using System;

namespace Nautilus.Data
{
    public partial class Lims_Increment : NautilusEntity
    {
        public const string TableName = "Lims_Increment";

        /// <summary>
        /// Gets or sets Increment_Table, VARCHAR2(30) (not null)
        /// </summary>
        public string Increment_Table { get; set; }

        /// <summary>
        /// Gets or sets Increment_Field, VARCHAR2(255) (not null)
        /// </summary>
        public string Increment_Field { get; set; }

        /// <summary>
        /// Gets or sets Increment_Value, NUMBER(22) (null)
        /// </summary>
        public decimal? Increment_Value { get; set; }

    }
}
