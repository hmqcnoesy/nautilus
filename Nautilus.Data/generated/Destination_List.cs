using System;

namespace Nautilus.Data
{
    public partial class Destination_List : NautilusEntity
    {
        public const string TableName = "Destination_List";

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets Actual_Destination_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Actual_Destination_Id { get; set; }

    }
}
