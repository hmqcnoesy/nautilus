using System;

namespace Nautilus.Data
{
    public partial class Instrument_Config : NautilusEntity
    {
        public const string TableName = "Instrument_Config";

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Part_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Part_Id { get; set; }

        /// <summary>
        /// Gets or sets Assembled_On, DATE (not null)
        /// </summary>
        public DateTime Assembled_On { get; set; }

        /// <summary>
        /// Gets or sets Disassembled_On, DATE (null)
        /// </summary>
        public DateTime? Disassembled_On { get; set; }

        /// <summary>
        /// Gets or sets Assembled_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Assembled_By { get; set; }

        /// <summary>
        /// Gets or sets Disassembled_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Disassembled_By { get; set; }

    }
}
