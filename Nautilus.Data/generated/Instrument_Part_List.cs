using System;

namespace Nautilus.Data
{
    public partial class Instrument_Part_List : NautilusEntity
    {
        public const string TableName = "Instrument_Part_List";

        /// <summary>
        /// Gets or sets Part_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Part_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Type_Id { get; set; }

    }
}
