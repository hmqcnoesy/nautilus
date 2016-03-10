using System;

namespace Nautilus.Data
{
    public partial class Extension : NautilusEntity
    {
        public const string TableName = "Extension";
        public const string PrimaryKey = "Extension_Id";
        public const string SequenceName = "Sq_Extension";

        /// <summary>
        /// Gets or sets Extension_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Progid, VARCHAR2(255) (null)
        /// </summary>
        public string Progid { get; set; }

        /// <summary>
        /// Gets or sets Extension_Version, NUMBER(10) (null)
        /// </summary>
        public decimal? Extension_Version { get; set; }

        /// <summary>
        /// Gets or sets Supported_Interfaces, VARCHAR2(255) (null)
        /// </summary>
        public string Supported_Interfaces { get; set; }

        /// <summary>
        /// Gets or sets Assembly_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Assembly_Name { get; set; }

        /// <summary>
        /// Gets or sets Assembly_Version, VARCHAR2(255) (null)
        /// </summary>
        public string Assembly_Version { get; set; }

        /// <summary>
        /// Gets or sets Class_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Class_Name { get; set; }

    }
}
