using System;

namespace Nautilus.Data
{
    public partial class Result_User_Env : NautilusEntity
    {
        public const string TableName = "Result_User";

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Qc_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Qc_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Plsql_Procedure, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Plsql_Procedure { get; set; }

        /// <summary>
        /// Gets or sets U_Plsql_Params, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Plsql_Params { get; set; }

        /// <summary>
        /// Gets or sets U_Result_Loaded_Date, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result_Loaded_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Weight, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Weight { get; set; }

        /// <summary>
        /// Gets or sets U_Dilution, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Dilution { get; set; }

        /// <summary>
        /// Gets or sets U_Mdl_Calc, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Mdl_Calc { get; set; }

        /// <summary>
        /// Gets or sets U_Adjust_Factor_Calc, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Adjust_Factor_Calc { get; set; }

        /// <summary>
        /// Gets or sets U_Eql_Calc, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Eql_Calc { get; set; }

        /// <summary>
        /// Gets or sets U_Volume, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Volume { get; set; }

    }
}
