using System;

namespace Nautilus.Data
{
    public partial class Calculation_Constant : NautilusEntity
    {
        public const string TableName = "Calculation_Constant";
        public const string PrimaryKey = "Calculation_Constant_Id";
        public const string SequenceName = "Sq_Calculation_Constant";

        /// <summary>
        /// Gets or sets Calculation_Constant_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calculation_Constant_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

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
        /// Gets or sets Constant_Value, NUMBER(22) (null)
        /// </summary>
        public decimal? Constant_Value { get; set; }

    }
}
