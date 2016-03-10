using System;

namespace Nautilus.Data
{
    public partial class Chemical : NautilusEntity
    {
        public const string TableName = "Chemical";
        public const string PrimaryKey = "Chemical_Id";
        public const string SequenceName = "Sq_Chemical";

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Chemical_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Container_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Container_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Density_Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Density_Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Temperature_Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Temperature_Unit_Id { get; set; }

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
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

        /// <summary>
        /// Gets or sets Classification, VARCHAR2(255) (null)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets Iupac_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Iupac_Name { get; set; }

        /// <summary>
        /// Gets or sets Cas_Registry_Number, VARCHAR2(255) (null)
        /// </summary>
        public string Cas_Registry_Number { get; set; }

        /// <summary>
        /// Gets or sets Appearance, VARCHAR2(255) (null)
        /// </summary>
        public string Appearance { get; set; }

        /// <summary>
        /// Gets or sets State, VARCHAR2(255) (null)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Storage, VARCHAR2(4000) (null)
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets Molecular_Formula, VARCHAR2(255) (null)
        /// </summary>
        public string Molecular_Formula { get; set; }

        /// <summary>
        /// Gets or sets Molecular_Weight, NUMBER(22) (null)
        /// </summary>
        public decimal? Molecular_Weight { get; set; }

        /// <summary>
        /// Gets or sets Boiling_Point, NUMBER(22) (null)
        /// </summary>
        public decimal? Boiling_Point { get; set; }

        /// <summary>
        /// Gets or sets Melting_Point, NUMBER(22) (null)
        /// </summary>
        public decimal? Melting_Point { get; set; }

        /// <summary>
        /// Gets or sets Density, NUMBER(22) (null)
        /// </summary>
        public decimal? Density { get; set; }

        /// <summary>
        /// Gets or sets Application, VARCHAR2(4000) (null)
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Gets or sets Handling, VARCHAR2(4000) (null)
        /// </summary>
        public string Handling { get; set; }

        /// <summary>
        /// Gets or sets Chemical_Structure, LONG RAW(0) (null)
        /// </summary>
        public byte[] Chemical_Structure { get; set; }

    }
}
