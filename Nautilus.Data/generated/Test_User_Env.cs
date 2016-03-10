using System;

namespace Nautilus.Data
{
    public partial class Test_User_Env : NautilusEntity
    {
        public const string TableName = "Test_User";

        /// <summary>
        /// Gets or sets Test_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Method, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Method { get; set; }

        /// <summary>
        /// Gets or sets U_Price, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Price { get; set; }

        /// <summary>
        /// Gets or sets U_Weight, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Weight { get; set; }

        /// <summary>
        /// Gets or sets U_Dilution, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Dilution { get; set; }

        /// <summary>
        /// Gets or sets U_Volume_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Volume_Factor { get; set; }

        /// <summary>
        /// Gets or sets U_Hold_Days, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Hold_Days { get; set; }

        /// <summary>
        /// Gets or sets U_Hold_Date, DATE (null)
        /// </summary>
        public DateTime? U_Hold_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Url, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Url { get; set; }

    }
}
