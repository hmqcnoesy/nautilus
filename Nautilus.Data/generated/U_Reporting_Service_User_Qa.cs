using System;

namespace Nautilus.Data
{
    public partial class U_Reporting_Service_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Reporting_Service_User";

        /// <summary>
        /// Gets or sets U_Reporting_Service_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Reporting_Service_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Url, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Url { get; set; }

        /// <summary>
        /// Gets or sets U_Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Icon, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Icon { get; set; }

    }
}
