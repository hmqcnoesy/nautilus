using System;

namespace Nautilus.Data
{
    public partial class Note_Phrases : NautilusEntity
    {
        public const string TableName = "Note_Phrases";

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Display_Name, VARCHAR2(255) (not null)
        /// </summary>
        public string Display_Name { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Phrase_Id { get; set; }

        /// <summary>
        /// Gets or sets Note_Icon_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Note_Icon_Name { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Use_Plain_Text, CHAR(1) (null)
        /// </summary>
        public string Use_Plain_Text { get; set; }

    }
}
