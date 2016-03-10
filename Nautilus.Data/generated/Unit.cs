using System;

namespace Nautilus.Data
{
    public partial class Unit : NautilusEntity
    {
        public const string TableName = "Unit";
        public const string PrimaryKey = "Unit_Id";
        public const string SequenceName = "Sq_Unit";

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Unit_Id { get; set; }

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
        /// Gets or sets Quantity, VARCHAR2(255) (null)
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets Class, CHAR(1) (null)
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets Derivation, VARCHAR2(255) (null)
        /// </summary>
        public string Derivation { get; set; }

        /// <summary>
        /// Gets or sets To_Base, VARCHAR2(2000) (null)
        /// </summary>
        public string To_Base { get; set; }

        /// <summary>
        /// Gets or sets From_Base, VARCHAR2(2000) (null)
        /// </summary>
        public string From_Base { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

    }
}
