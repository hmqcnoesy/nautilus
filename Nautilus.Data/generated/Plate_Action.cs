using System;

namespace Nautilus.Data
{
    public partial class Plate_Action : NautilusEntity
    {
        public const string TableName = "Plate_Action";
        public const string PrimaryKey = "Plate_Action_Id";
        public const string SequenceName = "Sq_Plate_Action";

        /// <summary>
        /// Gets or sets Plate_Action_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Action_Id { get; set; }

        /// <summary>
        /// Gets or sets Created_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Created_By { get; set; }

        /// <summary>
        /// Gets or sets Plate_Action_Type, CHAR(1) (null)
        /// </summary>
        public string Plate_Action_Type { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

    }
}
