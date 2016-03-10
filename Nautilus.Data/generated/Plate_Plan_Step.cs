using System;

namespace Nautilus.Data
{
    public partial class Plate_Plan_Step : NautilusEntity
    {
        public const string TableName = "Plate_Plan_Step";
        public const string PrimaryKey = "Plate_Plan_Step_Id";
        public const string SequenceName = "Sq_Plate_Plan_Step";

        /// <summary>
        /// Gets or sets Plate_Plan_Step_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Plan_Step_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Plan_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Plate_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Step_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Step_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Default_Step, CHAR(1) (null)
        /// </summary>
        public string Default_Step { get; set; }

    }
}
