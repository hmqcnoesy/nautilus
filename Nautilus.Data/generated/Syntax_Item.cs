using System;

namespace Nautilus.Data
{
    public partial class Syntax_Item : NautilusEntity
    {
        public const string TableName = "Syntax_Item";
        public const string PrimaryKey = "Syntax_Item_Id";
        public const string SequenceName = "Sq_Syntax_Item";

        /// <summary>
        /// Gets or sets Syntax_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Syntax_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Item_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Item_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Text_Value, VARCHAR2(4000) (null)
        /// </summary>
        public string Text_Value { get; set; }

        /// <summary>
        /// Gets or sets Numeric_Value, NUMBER(22) (null)
        /// </summary>
        public decimal? Numeric_Value { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

    }
}
