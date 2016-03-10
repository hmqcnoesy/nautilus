using System;

namespace Nautilus.Data
{
    public partial class U_Safetylimits_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Safetylimits_User";

        /// <summary>
        /// Gets or sets U_Safetylimits_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Safetylimits_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Dot_Class, VARCHAR2(30) (null)
        /// </summary>
        public string U_Dot_Class { get; set; }

        /// <summary>
        /// Gets or sets U_Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Location_Id { get; set; }

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
