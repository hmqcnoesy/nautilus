using System;

namespace Nautilus.Data
{
    public partial class U_Stat_Limit_Qc_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Stat_Limit_Qc_User";

        /// <summary>
        /// Gets or sets U_Stat_Limit_Qc_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Stat_Limit_Qc_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Test_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Analyte, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Analyte { get; set; }

        /// <summary>
        /// Gets or sets U_Worksheet_Aliquot_Typ_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Worksheet_Aliquot_Typ_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Unit, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Unit { get; set; }

        /// <summary>
        /// Gets or sets U_Minus_3_Sigma, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Minus_3_Sigma { get; set; }

        /// <summary>
        /// Gets or sets U_Plus_3_Sigma, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Plus_3_Sigma { get; set; }

        /// <summary>
        /// Gets or sets U_Result_Count, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Result_Count { get; set; }

    }
}
