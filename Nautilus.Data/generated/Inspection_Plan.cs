using System;

namespace Nautilus.Data
{
    public partial class Inspection_Plan : NautilusEntity
    {
        public const string TableName = "Inspection_Plan";
        public const string PrimaryKey = "Inspection_Plan_Id";
        public const string SequenceName = "Sq_Inspection_Plan";

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Inspection_Plan_Id { get; set; }

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

    }
}
