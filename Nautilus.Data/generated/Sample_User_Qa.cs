using System;

namespace Nautilus.Data
{
    public partial class Sample_User_Qa : NautilusEntity
    {
        public const string TableName = "Sample_User";

        /// <summary>
        /// Gets or sets Sample_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Receiver_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Receiver_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Serial_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Serial_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Retest_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Retest_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Adcar_Flag, CHAR(1) (null)
        /// </summary>
        public string U_Adcar_Flag { get; set; }

        /// <summary>
        /// Gets or sets U_Trace_Flag, CHAR(1) (null)
        /// </summary>
        public string U_Trace_Flag { get; set; }

        /// <summary>
        /// Gets or sets U_Comments, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comments { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Ip_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Revision, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ip_Revision { get; set; }

        /// <summary>
        /// Gets or sets U_Work_Order, VARCHAR2(30) (null)
        /// </summary>
        public string U_Work_Order { get; set; }

        /// <summary>
        /// Gets or sets U_Te_Program, VARCHAR2(30) (null)
        /// </summary>
        public string U_Te_Program { get; set; }

        /// <summary>
        /// Gets or sets U_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Program_Code, VARCHAR2(30) (null)
        /// </summary>
        public string U_Program_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Quantity, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Quantity { get; set; }

        /// <summary>
        /// Gets or sets U_Um, VARCHAR2(30) (null)
        /// </summary>
        public string U_Um { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Material_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Review_Area, VARCHAR2(30) (null)
        /// </summary>
        public string U_Review_Area { get; set; }

        /// <summary>
        /// Gets or sets U_Days_To_Complete, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Days_To_Complete { get; set; }

        /// <summary>
        /// Gets or sets U_Calendar_Days, CHAR(1) (null)
        /// </summary>
        public string U_Calendar_Days { get; set; }

        /// <summary>
        /// Gets or sets U_Purchase_Order, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Purchase_Order { get; set; }

        /// <summary>
        /// Gets or sets U_Inspection, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Inspection { get; set; }

        /// <summary>
        /// Gets or sets U_Witness_Panel_Flag, CHAR(1) (null)
        /// </summary>
        public string U_Witness_Panel_Flag { get; set; }

        /// <summary>
        /// Gets or sets U_Witness_Panel_Sent_Flag, CHAR(1) (null)
        /// </summary>
        public string U_Witness_Panel_Sent_Flag { get; set; }

        /// <summary>
        /// Gets or sets U_Queued_On, DATE (null)
        /// </summary>
        public DateTime? U_Queued_On { get; set; }

        /// <summary>
        /// Gets or sets U_Agecontrol, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Agecontrol { get; set; }

        /// <summary>
        /// Gets or sets U_Agesequence, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Agesequence { get; set; }

        /// <summary>
        /// Gets or sets U_Program, VARCHAR2(30) (null)
        /// </summary>
        public string U_Program { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Desc, VARCHAR2(255) (null)
        /// </summary>
        public string U_Material_Desc { get; set; }

        /// <summary>
        /// Gets or sets U_Charge_Code, VARCHAR2(255) (null)
        /// </summary>
        public string U_Charge_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Motor, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Motor { get; set; }

        /// <summary>
        /// Gets or sets U_Requester_Notes, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Requester_Notes { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier_Lot, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier_Lot { get; set; }

        /// <summary>
        /// Gets or sets U_Class, VARCHAR2(30) (null)
        /// </summary>
        public string U_Class { get; set; }

        /// <summary>
        /// Gets or sets U_Revision, VARCHAR2(30) (null)
        /// </summary>
        public string U_Revision { get; set; }

        /// <summary>
        /// Gets or sets U_Ponumber, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ponumber { get; set; }

        /// <summary>
        /// Gets or sets U_Polinenumber, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Polinenumber { get; set; }

        /// <summary>
        /// Gets or sets U_Atklotnumber, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Atklotnumber { get; set; }

        /// <summary>
        /// Gets or sets U_Subcode, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Subcode { get; set; }

        /// <summary>
        /// Gets or sets U_Datedue, DATE (null)
        /// </summary>
        public DateTime? U_Datedue { get; set; }

        /// <summary>
        /// Gets or sets U_Operator, VARCHAR2(30) (null)
        /// </summary>
        public string U_Operator { get; set; }

        /// <summary>
        /// Gets or sets U_Spectest, VARCHAR2(30) (null)
        /// </summary>
        public string U_Spectest { get; set; }

        /// <summary>
        /// Gets or sets U_Datereceived, DATE (null)
        /// </summary>
        public DateTime? U_Datereceived { get; set; }

        /// <summary>
        /// Gets or sets U_Datecompleted, DATE (null)
        /// </summary>
        public DateTime? U_Datecompleted { get; set; }

        /// <summary>
        /// Gets or sets U_Mixnumbera, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Mixnumbera { get; set; }

        /// <summary>
        /// Gets or sets U_Fp_Workflow, VARCHAR2(30) (null)
        /// </summary>
        public string U_Fp_Workflow { get; set; }

        /// <summary>
        /// Gets or sets U_Item_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Item_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Excelhyperlink, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Excelhyperlink { get; set; }

        /// <summary>
        /// Gets or sets U_Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Needs_Reporting, CHAR(1) (null)
        /// </summary>
        public string U_Needs_Reporting { get; set; }

        /// <summary>
        /// Gets or sets U_Get_Impresa_Info, CHAR(1) (null)
        /// </summary>
        public string U_Get_Impresa_Info { get; set; }

        /// <summary>
        /// Gets or sets U_Unauthorization, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Unauthorization { get; set; }

        /// <summary>
        /// Gets or sets U_Promise_Date, DATE (null)
        /// </summary>
        public DateTime? U_Promise_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Lab_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Lab_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Requested_By, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Requested_By { get; set; }

        /// <summary>
        /// Gets or sets U_Email_Results_To, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Email_Results_To { get; set; }

        /// <summary>
        /// Gets or sets U_Hazard_Info, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Hazard_Info { get; set; }

        /// <summary>
        /// Gets or sets U_Contacts_Propellant, CHAR(1) (null)
        /// </summary>
        public string U_Contacts_Propellant { get; set; }

        /// <summary>
        /// Gets or sets U_Return_To, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Return_To { get; set; }

        /// <summary>
        /// Gets or sets U_Chemical_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Chemical_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Ecl, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ecl { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer_Lot_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer_Lot_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer_Description, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer_Description { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Where_Used, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Where_Used { get; set; }

        /// <summary>
        /// Gets or sets U_Csr_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Csr_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Justification, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Justification { get; set; }

    }
}
