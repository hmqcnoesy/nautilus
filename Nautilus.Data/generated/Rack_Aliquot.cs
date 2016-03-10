using System;

namespace Nautilus.Data
{
    public partial class Rack_Aliquot : NautilusEntity
    {
        public const string TableName = "Rack_Aliquot";

        /// <summary>
        /// Gets or sets Rack_Usage_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Usage_Id { get; set; }

        /// <summary>
        /// Gets or sets Absolute_Position, NUMBER(10) (not null)
        /// </summary>
        public decimal Absolute_Position { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Aliquot_Id { get; set; }

    }
}
