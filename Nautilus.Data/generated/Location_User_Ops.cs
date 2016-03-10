using System;

namespace Nautilus.Data
{
    public partial class Location_User_Ops : NautilusEntity
    {
        public const string TableName = "Location_User";

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Location_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Safety_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Safety_Limit { get; set; }

        /// <summary>
        /// Gets or sets U_Warning_Percent, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Warning_Percent { get; set; }

    }
}
