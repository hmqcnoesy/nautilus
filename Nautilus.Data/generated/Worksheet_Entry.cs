using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Entry : NautilusEntity
    {
        public const string TableName = "Worksheet_Entry";
        public const string PrimaryKey = "Worksheet_Entry_Id";
        public const string SequenceName = "Sq_Worksheet_Entry";

        /// <summary>
        /// Gets or sets Worksheet_Entry_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Entry_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Order, NUMBER(22) (not null)
        /// </summary>
        public decimal Worksheet_Order { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Section, CHAR(1) (null)
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Gets or sets Parent_Entry_Number, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Entry_Number { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Aliquot_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Aliquot_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Acquired, CHAR(1) (null)
        /// </summary>
        public string Acquired { get; set; }

        /// <summary>
        /// Gets or sets Stock_Aliquot_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Control_Aliquot, CHAR(1) (null)
        /// </summary>
        public string Control_Aliquot { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Control, CHAR(1) (null)
        /// </summary>
        public string Aqc_Control { get; set; }

    }
}
