using System;

namespace Nautilus.Data
{
    public partial class Phrase_Entry : NautilusEntity
    {
        public const string TableName = "Phrase_Entry";

        /// <summary>
        /// Gets or sets Phrase_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Phrase_Id { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Name, VARCHAR2(255) (not null)
        /// </summary>
        public string Phrase_Name { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Phrase_Description { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Info, VARCHAR2(4000) (null)
        /// </summary>
        public string Phrase_Info { get; set; }

    }
}
