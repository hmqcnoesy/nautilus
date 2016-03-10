using System;

namespace Nautilus.Data
{
    public partial class Entity_Event_Link : NautilusEntity
    {
        public const string TableName = "Entity_Event_Link";

        /// <summary>
        /// Gets or sets Entity_Event_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Entity_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Entity_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Entity_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Link_Command_Line, VARCHAR2(255) (null)
        /// </summary>
        public string Link_Command_Line { get; set; }

        /// <summary>
        /// Gets or sets Link_Parameter_List, VARCHAR2(255) (null)
        /// </summary>
        public string Link_Parameter_List { get; set; }

        /// <summary>
        /// Gets or sets Window_State, CHAR(3) (null)
        /// </summary>
        public string Window_State { get; set; }

    }
}
