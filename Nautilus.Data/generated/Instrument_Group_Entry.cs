using System;

namespace Nautilus.Data
{
    public partial class Instrument_Group_Entry : NautilusEntity
    {
        public const string TableName = "Instrument_Group_Entry";

        /// <summary>
        /// Gets or sets Instrument_Group_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Id { get; set; }

    }
}
