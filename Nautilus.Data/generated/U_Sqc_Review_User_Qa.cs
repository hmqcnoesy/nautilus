using System;

namespace Nautilus.Data
{
    public partial class U_Sqc_Review_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Sqc_Review_User";

        /// <summary>
        /// Gets or sets U_Sqc_Review_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Sqc_Review_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Serial_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Serial_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Ip_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Timestamp { get; set; }

    }
}
