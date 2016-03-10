using System;

namespace Nautilus.Data
{
    public partial class U_Result_Limits_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Result_Limits_User";

        /// <summary>
        /// Gets or sets U_Result_Limits_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Result_Limits_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Stat_Min, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Stat_Min { get; set; }

        /// <summary>
        /// Gets or sets U_Stat_Max, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Stat_Max { get; set; }

        /// <summary>
        /// Gets or sets U_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Ip_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Item_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ip_Item_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Spec_Min, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Spec_Min { get; set; }

        /// <summary>
        /// Gets or sets U_Spec_Max, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Spec_Max { get; set; }

        /// <summary>
        /// Gets or sets U_Specs_Apply_To_Actuals, CHAR(1) (null)
        /// </summary>
        public string U_Specs_Apply_To_Actuals { get; set; }

        /// <summary>
        /// Gets or sets U_Specs_Apply_To_Average, CHAR(1) (null)
        /// </summary>
        public string U_Specs_Apply_To_Average { get; set; }

        /// <summary>
        /// Gets or sets U_Stats_Apply_To_Actuals, CHAR(1) (null)
        /// </summary>
        public string U_Stats_Apply_To_Actuals { get; set; }

        /// <summary>
        /// Gets or sets U_Stats_Apply_To_Average, CHAR(1) (null)
        /// </summary>
        public string U_Stats_Apply_To_Average { get; set; }

    }
}
