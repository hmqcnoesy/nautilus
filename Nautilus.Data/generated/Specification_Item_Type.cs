using System;

namespace Nautilus.Data
{
    public partial class Specification_Item_Type : NautilusEntity
    {
        public const string TableName = "Specification_Item_Type";
        public const string PrimaryKey = "Specification_Item_Type_Id";
        public const string SequenceName = "Sq_Specification_Item_Type";

        /// <summary>
        /// Gets or sets Specification_Item_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Specification_Item_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Result_Types, CHAR(10) (null)
        /// </summary>
        public string Result_Types { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Required, CHAR(1) (null)
        /// </summary>
        public string Phrase_Required { get; set; }

    }
}
