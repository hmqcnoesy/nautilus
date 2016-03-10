using System;

namespace Nautilus.Data
{
    public partial class Rack : NautilusEntity
    {
        public const string TableName = "Rack";
        public const string PrimaryKey = "Rack_Id";
        public const string SequenceName = "Sq_Rack";

        /// <summary>
        /// Gets or sets Rack_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Id { get; set; }

        /// <summary>
        /// Gets or sets Rack_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Rack_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

    }
}
