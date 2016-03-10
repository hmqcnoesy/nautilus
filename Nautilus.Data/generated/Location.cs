using System;

namespace Nautilus.Data
{
    public partial class Location : NautilusEntity
    {
        public const string TableName = "Location";
        public const string PrimaryKey = "Location_Id";
        public const string SequenceName = "Sq_Location";

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Grid_Reference, VARCHAR2(20) (null)
        /// </summary>
        public string Grid_Reference { get; set; }

        /// <summary>
        /// Gets or sets Elevation, VARCHAR2(20) (null)
        /// </summary>
        public string Elevation { get; set; }

        /// <summary>
        /// Gets or sets Can_Store_Items, CHAR(1) (null)
        /// </summary>
        public string Can_Store_Items { get; set; }

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

        /// <summary>
        /// Gets or sets Location_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

    }
}
