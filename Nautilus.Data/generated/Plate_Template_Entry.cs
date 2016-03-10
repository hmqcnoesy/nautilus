using System;

namespace Nautilus.Data
{
    public partial class Plate_Template_Entry : NautilusEntity
    {
        public const string TableName = "Plate_Template_Entry";

        /// <summary>
        /// Gets or sets Plate_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Template_Order, NUMBER(10) (not null)
        /// </summary>
        public decimal Plate_Template_Order { get; set; }

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Aliquot_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Aliquot_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Template_Row, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Template_Row { get; set; }

        /// <summary>
        /// Gets or sets Plate_Template_Column, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Template_Column { get; set; }

        /// <summary>
        /// Gets or sets Parent_Entry_Number, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Entry_Number { get; set; }

        /// <summary>
        /// Gets or sets Amount, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets Link_Stock, CHAR(1) (null)
        /// </summary>
        public string Link_Stock { get; set; }

    }
}
