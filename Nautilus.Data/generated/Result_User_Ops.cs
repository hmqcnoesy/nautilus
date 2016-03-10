using System;

namespace Nautilus.Data
{
    public partial class Result_User_Ops : NautilusEntity
    {
        public const string TableName = "Result_User";

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Analyst, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Analyst { get; set; }

        /// <summary>
        /// Gets or sets U_Plsql_Routine, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Plsql_Routine { get; set; }

        /// <summary>
        /// Gets or sets U_Plsql_Params, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Plsql_Params { get; set; }

        /// <summary>
        /// Gets or sets U_Plsql_Procedure, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Plsql_Procedure { get; set; }

        /// <summary>
        /// Gets or sets U_Result_Loaded_Date, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result_Loaded_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Adjust_Factor_Calc, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Adjust_Factor_Calc { get; set; }

        /// <summary>
        /// Gets or sets U_Mdl_Calc, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Mdl_Calc { get; set; }

        /// <summary>
        /// Gets or sets U_Eql_Calc, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Eql_Calc { get; set; }

        /// <summary>
        /// Gets or sets U_Weight, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Weight { get; set; }

        /// <summary>
        /// Gets or sets U_Dilution, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Dilution { get; set; }

        /// <summary>
        /// Gets or sets U_Volume, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Volume { get; set; }

        /// <summary>
        /// Gets or sets U_Max_Above_Target, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Max_Above_Target { get; set; }

        /// <summary>
        /// Gets or sets U_Max_Below_Target, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Max_Below_Target { get; set; }

        /// <summary>
        /// Gets or sets U_Target, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Target { get; set; }

        /// <summary>
        /// Gets or sets U_Sl_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sl_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Checked_On, DATE (null)
        /// </summary>
        public DateTime? U_Checked_On { get; set; }

        /// <summary>
        /// Gets or sets U_Needs_Stat_Review, CHAR(1) (null)
        /// </summary>
        public string U_Needs_Stat_Review { get; set; }

        /// <summary>
        /// Gets or sets U_Exclude_From_Stats, CHAR(1) (null)
        /// </summary>
        public string U_Exclude_From_Stats { get; set; }

        /// <summary>
        /// Gets or sets U_Needs_Stat_Check, CHAR(1) (null)
        /// </summary>
        public string U_Needs_Stat_Check { get; set; }

        /// <summary>
        /// Gets or sets U_Stat_Review_Remarks, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Stat_Review_Remarks { get; set; }

    }
}
