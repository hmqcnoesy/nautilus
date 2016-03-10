using System;

namespace Nautilus.Data
{
    public partial class Specification_Item : NautilusEntity
    {
        public const string TableName = "Specification_Item";

        /// <summary>
        /// Gets or sets Specification_Grade_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Specification_Grade_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Specification_Item_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Specification_Item_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Parameter, VARCHAR2(4000) (null)
        /// </summary>
        public string Parameter { get; set; }

    }
}
