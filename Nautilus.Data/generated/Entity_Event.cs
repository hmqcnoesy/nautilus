using System;

namespace Nautilus.Data
{
    public partial class Entity_Event : NautilusEntity
    {
        public const string TableName = "Entity_Event";
        public const string PrimaryKey = "Entity_Event_Id";
        public const string SequenceName = "Sq_Entity_Event";

        /// <summary>
        /// Gets or sets Entity_Event_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Entity_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Event_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Event_Name { get; set; }

    }
}
