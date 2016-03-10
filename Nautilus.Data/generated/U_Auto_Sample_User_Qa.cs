using System;

namespace Nautilus.Data
{
    public partial class U_Auto_Sample_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Auto_Sample_User";

        /// <summary>
        /// Gets or sets U_Auto_Sample_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Auto_Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Day, VARCHAR2(30) (null)
        /// </summary>
        public string U_Day { get; set; }

        /// <summary>
        /// Gets or sets U_Date, VARCHAR2(30) (null)
        /// </summary>
        public string U_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Week, VARCHAR2(30) (null)
        /// </summary>
        public string U_Week { get; set; }

        /// <summary>
        /// Gets or sets U_Month, VARCHAR2(30) (null)
        /// </summary>
        public string U_Month { get; set; }

        /// <summary>
        /// Gets or sets U_Sample_Workflows, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sample_Workflows { get; set; }

        /// <summary>
        /// Gets or sets U_Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Reporting_Service_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Reporting_Service_Id { get; set; }

    }
}
