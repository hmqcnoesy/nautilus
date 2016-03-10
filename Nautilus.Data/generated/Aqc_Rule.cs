using System;

namespace Nautilus.Data
{
    public partial class Aqc_Rule : NautilusEntity
    {
        public const string TableName = "Aqc_Rule";
        public const string PrimaryKey = "Aqc_Rule_Id";
        public const string SequenceName = "Sq_Aqc_Rule";

        /// <summary>
        /// Gets or sets Aqc_Rule_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Rule_Id { get; set; }

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
        /// Gets or sets Rule_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Rule_Type { get; set; }

        /// <summary>
        /// Gets or sets Failure_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Failure_Type { get; set; }

        /// <summary>
        /// Gets or sets Point_Count, NUMBER(16) (null)
        /// </summary>
        public decimal? Point_Count { get; set; }

        /// <summary>
        /// Gets or sets Limit_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Limit_Type { get; set; }

        /// <summary>
        /// Gets or sets Limit_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? Limit_Factor { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

    }
}
