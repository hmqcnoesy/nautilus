using System;

namespace Nautilus.Data
{
    public partial class U_Trace_Transfer_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Trace_Transfer_User";

        /// <summary>
        /// Gets or sets U_Trace_Transfer_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Trace_Transfer_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Act1, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Act1 { get; set; }

        /// <summary>
        /// Gets or sets U_Act2, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Act2 { get; set; }

        /// <summary>
        /// Gets or sets U_Act3, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Act3 { get; set; }

        /// <summary>
        /// Gets or sets U_Act1_Result_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Act1_Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Act2_Result_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Act2_Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Act3_Result_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Act3_Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Ave, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ave { get; set; }

        /// <summary>
        /// Gets or sets U_Component_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Component_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Te_Lot_Nbr, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Te_Lot_Nbr { get; set; }

        /// <summary>
        /// Gets or sets U_Program_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Program_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Serial_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Serial_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Vendor, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Vendor { get; set; }

        /// <summary>
        /// Gets or sets U_Ave_Result_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ave_Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Transfer_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Transfer_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Completion_Date, DATE (null)
        /// </summary>
        public DateTime? U_Completion_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Te_Program_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Te_Program_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Vfile, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Vfile { get; set; }

        /// <summary>
        /// Gets or sets U_Vfile_Line_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Vfile_Line_No { get; set; }

        /// <summary>
        /// Gets or sets U_Source, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Source { get; set; }

        /// <summary>
        /// Gets or sets U_Aliquot_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Aliquot_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Sample_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sample_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Email_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Email_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Retransfer, CHAR(1) (null)
        /// </summary>
        public string U_Retransfer { get; set; }

    }
}
