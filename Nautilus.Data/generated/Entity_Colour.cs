using System;

namespace Nautilus.Data
{
    public partial class Entity_Colour : NautilusEntity
    {
        public const string TableName = "Entity_Colour";

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Colour_Item_Status, VARCHAR2(255) (not null)
        /// </summary>
        public string Colour_Item_Status { get; set; }

        /// <summary>
        /// Gets or sets Text_Colour, NUMBER(10) (null)
        /// </summary>
        public decimal? Text_Colour { get; set; }

    }
}
