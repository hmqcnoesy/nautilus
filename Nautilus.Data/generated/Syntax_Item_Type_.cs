using System;

namespace Nautilus.Data
{
    public partial class Syntax_Item_Type_ : NautilusEntity
    {
        public const string TableName = "Syntax_Item_Type";
        public const string PrimaryKey = "Syntax_Item_Type_Id";
        public const string SequenceName = "Sq_Syntax_Item_Type";

        /// <summary>
        /// Gets or sets Syntax_Item_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Syntax_Item_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Item_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Syntax_Item_Type { get; set; }

        /// <summary>
        /// Gets or sets Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Parent_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Parent_Count { get; set; }

        /// <summary>
        /// Gets or sets Field_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Field_Name { get; set; }

        /// <summary>
        /// Gets or sets Extra_1, VARCHAR2(30) (null)
        /// </summary>
        public string Extra_1 { get; set; }

        /// <summary>
        /// Gets or sets Extra_2, VARCHAR2(30) (null)
        /// </summary>
        public string Extra_2 { get; set; }

        /// <summary>
        /// Gets or sets Extra_3, VARCHAR2(30) (null)
        /// </summary>
        public string Extra_3 { get; set; }

        /// <summary>
        /// Gets or sets Parent_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Parent_Type { get; set; }

    }
}
