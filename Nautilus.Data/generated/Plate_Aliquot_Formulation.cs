using System;

namespace Nautilus.Data
{
    public partial class Plate_Aliquot_Formulation : NautilusEntity
    {
        public const string TableName = "Plate_Aliquot_Formulation";
        public const string PrimaryKey = "Plate_Aliquot_Formulation_Id";
        public const string SequenceName = "Sq_Plate_Aliquot_Formulation";

        /// <summary>
        /// Gets or sets Plate_Aliquot_Formulation_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Aliquot_Formulation_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Child_Plate_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Child_Plate_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Plate_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Plate_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Old_Aliquot_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Old_Aliquot_Name { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Parent_Plate_Order, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Plate_Order { get; set; }

        /// <summary>
        /// Gets or sets Parent_Plate_Row, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Plate_Row { get; set; }

        /// <summary>
        /// Gets or sets Parent_Plate_Column, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Plate_Column { get; set; }

        /// <summary>
        /// Gets or sets Parent_Plate_Aliquot_Type, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Plate_Aliquot_Type { get; set; }

    }
}
