using System;

namespace Nautilus.Data
{
    public partial class Rack_Location : NautilusEntity
    {
        public const string TableName = "Rack_Location";
        public const string PrimaryKey = "Rack_Location_Id";
        public const string SequenceName = "Sq_Rack_Location";

        /// <summary>
        /// Gets or sets Rack_Location_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Rack_Usage_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Usage_Id { get; set; }

        /// <summary>
        /// Gets or sets Received_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Received_By { get; set; }

        /// <summary>
        /// Gets or sets Removed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Removed_By { get; set; }

        /// <summary>
        /// Gets or sets Received_On, DATE (null)
        /// </summary>
        public DateTime? Received_On { get; set; }

        /// <summary>
        /// Gets or sets Removed_On, DATE (null)
        /// </summary>
        public DateTime? Removed_On { get; set; }

    }
}
