using System;

namespace Nautilus.Data
{
    public partial class U_Notification_Item_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Notification_Item_User";

        /// <summary>
        /// Gets or sets U_Notification_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Notification_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Notification_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Notification_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Active, CHAR(1) (null)
        /// </summary>
        public string U_Active { get; set; }

    }
}
