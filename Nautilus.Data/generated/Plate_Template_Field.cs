using System;

namespace Nautilus.Data
{
    public partial class Plate_Template_Field : NautilusEntity
    {
        public const string TableName = "Plate_Template_Field";

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Prompt_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Field_Prompt_Id { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Text, VARCHAR2(255) (not null)
        /// </summary>
        public string Prompt_Text { get; set; }

        /// <summary>
        /// Gets or sets Default_Num, NUMBER(22) (null)
        /// </summary>
        public decimal? Default_Num { get; set; }

        /// <summary>
        /// Gets or sets Default_Text, VARCHAR2(4000) (null)
        /// </summary>
        public string Default_Text { get; set; }

        /// <summary>
        /// Gets or sets Displayed, CHAR(1) (null)
        /// </summary>
        public string Displayed { get; set; }

        /// <summary>
        /// Gets or sets Mandatory, CHAR(1) (null)
        /// </summary>
        public string Mandatory { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Prompted, CHAR(1) (null)
        /// </summary>
        public string Prompted { get; set; }

        /// <summary>
        /// Gets or sets Receiving, CHAR(1) (null)
        /// </summary>
        public string Receiving { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

    }
}
