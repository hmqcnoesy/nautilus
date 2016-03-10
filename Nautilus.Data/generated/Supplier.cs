using System;

namespace Nautilus.Data
{
    public partial class Supplier : NautilusEntity
    {
        public const string TableName = "Supplier";
        public const string PrimaryKey = "Supplier_Id";
        public const string SequenceName = "Sq_Supplier";

        /// <summary>
        /// Gets or sets Supplier_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Supplier_Id { get; set; }

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
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Supplier_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Supplier_Type { get; set; }

        /// <summary>
        /// Gets or sets Supplier_Code, VARCHAR2(255) (null)
        /// </summary>
        public string Supplier_Code { get; set; }

    }
}
