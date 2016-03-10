using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Template_Entry : NautilusEntity
    {
        public const string TableName = "Worksheet_Template_Entry";

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Order, NUMBER(22) (not null)
        /// </summary>
        public decimal Worksheet_Template_Order { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Aliquot_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Aliquot_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Section, CHAR(1) (null)
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Entry_Number, NUMBER(10) (null)
        /// </summary>
        public decimal? Aliquot_Entry_Number { get; set; }

        /// <summary>
        /// Gets or sets Parent_Entry_Number, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Entry_Number { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Repeated, CHAR(1) (null)
        /// </summary>
        public string Repeated { get; set; }

        /// <summary>
        /// Gets or sets Random_Frequency, NUMBER(10) (null)
        /// </summary>
        public decimal? Random_Frequency { get; set; }

        /// <summary>
        /// Gets or sets Amount, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Link_Stock, CHAR(1) (null)
        /// </summary>
        public string Link_Stock { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Control, CHAR(1) (null)
        /// </summary>
        public string Aqc_Control { get; set; }

    }
}
