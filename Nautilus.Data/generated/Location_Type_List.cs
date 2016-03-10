using System;

namespace Nautilus.Data
{
    public partial class Location_Type_List : NautilusEntity
    {
        public const string TableName = "Location_Type_List";

        /// <summary>
        /// Gets or sets Parent_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Parent_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Location_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Location_Type_Id { get; set; }

    }
}
