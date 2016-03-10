using System;

namespace Nautilus.Data
{
    public partial class Aqc_Chart_Rule : NautilusEntity
    {
        public const string TableName = "Aqc_Chart_Rule";

        /// <summary>
        /// Gets or sets Aqc_Chart_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Chart_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Rule_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Rule_Id { get; set; }

        /// <summary>
        /// Gets or sets Rule_Number, NUMBER(16) (not null)
        /// </summary>
        public decimal Rule_Number { get; set; }

    }
}
