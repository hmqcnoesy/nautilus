using System;

namespace Nautilus.Data
{
    public partial class Instrument_User_Ops : NautilusEntity
    {
        public const string TableName = "Instrument_User";

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Id { get; set; }

    }
}
