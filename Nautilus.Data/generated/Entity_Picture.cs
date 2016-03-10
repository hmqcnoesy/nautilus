using System;

namespace Nautilus.Data
{
    public partial class Entity_Picture : NautilusEntity
    {
        public const string TableName = "Entity_Picture";

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Picture_Item_Status, VARCHAR2(255) (not null)
        /// </summary>
        public string Picture_Item_Status { get; set; }

        /// <summary>
        /// Gets or sets Selected_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Selected_Icon { get; set; }

        /// <summary>
        /// Gets or sets Unselected_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Unselected_Icon { get; set; }

    }
}
