using System;

namespace Nautilus.Data
{
    public partial class Entity_Event_Parameters : NautilusEntity
    {
        public const string TableName = "Entity_Event_Parameters";

        /// <summary>
        /// Gets or sets Entity_Event_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Entity_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Parameter_Number, NUMBER(22) (not null)
        /// </summary>
        public decimal Parameter_Number { get; set; }

        /// <summary>
        /// Gets or sets Parameter_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_Name { get; set; }

    }
}
