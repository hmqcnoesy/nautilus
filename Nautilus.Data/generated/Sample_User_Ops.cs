using System;

namespace Nautilus.Data
{
    public partial class Sample_User_Ops : NautilusEntity
    {
        public const string TableName = "Sample_User";

        /// <summary>
        /// Gets or sets Sample_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Lot_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Lot_No { get; set; }

        /// <summary>
        /// Gets or sets U_Test_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Test_No { get; set; }

        /// <summary>
        /// Gets or sets U_Cust_Samp_Ref, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Cust_Samp_Ref { get; set; }

        /// <summary>
        /// Gets or sets U_Matrix_Num, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Matrix_Num { get; set; }

        /// <summary>
        /// Gets or sets U_Ref_Sample, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ref_Sample { get; set; }

        /// <summary>
        /// Gets or sets U_Sample_Num, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sample_Num { get; set; }

        /// <summary>
        /// Gets or sets U_Sp_Stock_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sp_Stock_No { get; set; }

        /// <summary>
        /// Gets or sets U_Prject_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Prject_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Clientname, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Clientname { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Phone, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Phone { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Email, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Email { get; set; }

        /// <summary>
        /// Gets or sets U_Project, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Project { get; set; }

        /// <summary>
        /// Gets or sets U_Task, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Task { get; set; }

        /// <summary>
        /// Gets or sets U_Subcode, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Subcode { get; set; }

        /// <summary>
        /// Gets or sets U_Hours, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Hours { get; set; }

        /// <summary>
        /// Gets or sets U_Program, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Program { get; set; }

        /// <summary>
        /// Gets or sets U_Processing_Time, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Processing_Time { get; set; }

        /// <summary>
        /// Gets or sets U_Propellant_Mix_Phrase, VARCHAR2(30) (null)
        /// </summary>
        public string U_Propellant_Mix_Phrase { get; set; }

        /// <summary>
        /// Gets or sets U_Mix_Building, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Mix_Building { get; set; }

        /// <summary>
        /// Gets or sets U_Pld, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Pld { get; set; }

        /// <summary>
        /// Gets or sets U_Person_Mix_Released_To, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Person_Mix_Released_To { get; set; }

        /// <summary>
        /// Gets or sets U_Mix_Bowl, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Mix_Bowl { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Info, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Material_Info { get; set; }

        /// <summary>
        /// Gets or sets U_Planning, VARCHAR2(30) (null)
        /// </summary>
        public string U_Planning { get; set; }

        /// <summary>
        /// Gets or sets U_Materials, VARCHAR2(30) (null)
        /// </summary>
        public string U_Materials { get; set; }

        /// <summary>
        /// Gets or sets U_Hardware, VARCHAR2(30) (null)
        /// </summary>
        public string U_Hardware { get; set; }

        /// <summary>
        /// Gets or sets U_Contract_Scope, VARCHAR2(30) (null)
        /// </summary>
        public string U_Contract_Scope { get; set; }

        /// <summary>
        /// Gets or sets U_Budget, VARCHAR2(30) (null)
        /// </summary>
        public string U_Budget { get; set; }

        /// <summary>
        /// Gets or sets U_Needed_Start_Date, DATE (null)
        /// </summary>
        public DateTime? U_Needed_Start_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Description, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Material_Description { get; set; }

    }
}
