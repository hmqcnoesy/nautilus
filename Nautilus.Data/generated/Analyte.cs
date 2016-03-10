using System;

namespace Nautilus.Data
{
    public partial class Analyte : NautilusEntity
    {
        public const string TableName = "Analyte";
        public const string PrimaryKey = "Analyte_Id";
        public const string SequenceName = "Sq_Analyte";

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Analyte_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Project_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Project_Id { get; set; }

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
        /// Gets or sets Molecular_Weight, NUMBER(22) (null)
        /// </summary>
        public decimal? Molecular_Weight { get; set; }

        /// <summary>
        /// Gets or sets Molecular_Formula, VARCHAR2(255) (null)
        /// </summary>
        public string Molecular_Formula { get; set; }

        /// <summary>
        /// Gets or sets Classification, VARCHAR2(255) (null)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Chemical_Id { get; set; }

        /// <summary>
        /// Gets or sets Purity, NUMBER(22) (null)
        /// </summary>
        public decimal? Purity { get; set; }

    }
}
