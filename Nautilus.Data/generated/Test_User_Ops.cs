using System;

namespace Nautilus.Data
{
    public partial class Test_User_Ops : NautilusEntity
    {
        public const string TableName = "Test_User";

        /// <summary>
        /// Gets or sets Test_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Sp_Workgroup, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sp_Workgroup { get; set; }

        /// <summary>
        /// Gets or sets U_Weight, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Weight { get; set; }

        /// <summary>
        /// Gets or sets U_Volume_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Volume_Factor { get; set; }

        /// <summary>
        /// Gets or sets U_Dilution, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Dilution { get; set; }

        /// <summary>
        /// Gets or sets U_Number_Of_Tests, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Number_Of_Tests { get; set; }

        /// <summary>
        /// Gets or sets U_Sl_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sl_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Duration, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Test_Duration { get; set; }

        /// <summary>
        /// Gets or sets U_Method_Used, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Method_Used { get; set; }

        /// <summary>
        /// Gets or sets U_Url, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Url { get; set; }

    }
}
