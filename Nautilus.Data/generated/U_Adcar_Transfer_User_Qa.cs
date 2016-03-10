using System;

namespace Nautilus.Data
{
    public partial class U_Adcar_Transfer_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Adcar_Transfer_User";

        /// <summary>
        /// Gets or sets U_Adcar_Transfer_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Adcar_Transfer_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Badge_No, VARCHAR2(9) (null)
        /// </summary>
        public string U_Badge_No { get; set; }

        /// <summary>
        /// Gets or sets U_Col_Id, VARCHAR2(3) (not null)
        /// </summary>
        public string U_Col_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Completion_Date, DATE (not null)
        /// </summary>
        public DateTime U_Completion_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Doc_Type, VARCHAR2(1) (not null)
        /// </summary>
        public string U_Doc_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Item, VARCHAR2(4) (not null)
        /// </summary>
        public string U_Ip_Item { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Type, VARCHAR2(1) (not null)
        /// </summary>
        public string U_Ip_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Lot_No, VARCHAR2(7) (not null)
        /// </summary>
        public string U_Lot_No { get; set; }

        /// <summary>
        /// Gets or sets U_Pn_Stock_No, VARCHAR2(32) (not null)
        /// </summary>
        public string U_Pn_Stock_No { get; set; }

        /// <summary>
        /// Gets or sets U_Program_Code, VARCHAR2(3) (not null)
        /// </summary>
        public string U_Program_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Matrix_Cd, VARCHAR2(1) (null)
        /// </summary>
        public string U_Matrix_Cd { get; set; }

        /// <summary>
        /// Gets or sets U_Matrix_Id, VARCHAR2(8) (not null)
        /// </summary>
        public string U_Matrix_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Result, VARCHAR2(17) (not null)
        /// </summary>
        public string U_Result { get; set; }

        /// <summary>
        /// Gets or sets U_Result_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Row_Id, VARCHAR2(3) (not null)
        /// </summary>
        public string U_Row_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Source, VARCHAR2(1) (not null)
        /// </summary>
        public string U_Source { get; set; }

        /// <summary>
        /// Gets or sets U_Start_Date, DATE (not null)
        /// </summary>
        public DateTime U_Start_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Transfer_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Transfer_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Sample_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sample_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Aliquot_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Aliquot_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Email_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Email_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Retransfer, CHAR(1) (null)
        /// </summary>
        public string U_Retransfer { get; set; }

        /// <summary>
        /// Gets or sets U_Source_File, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Source_File { get; set; }

        /// <summary>
        /// Gets or sets U_Line_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Line_No { get; set; }

    }
}
