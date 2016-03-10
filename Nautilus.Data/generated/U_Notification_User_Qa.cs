using System;

namespace Nautilus.Data
{
    public partial class U_Notification_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Notification_User";

        /// <summary>
        /// Gets or sets U_Notification_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Notification_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Header_Html, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Header_Html { get; set; }

    }
}
