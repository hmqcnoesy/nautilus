using System;

namespace Nautilus.Data
{
    public partial class Rack_Worksheet : NautilusEntity
    {
        public const string TableName = "Rack_Worksheet";

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Rack_Usage_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Usage_Id { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

    }
}
