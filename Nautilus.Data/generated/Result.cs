using System;

namespace Nautilus.Data
{
    public partial class Result : NautilusEntity
    {
        public const string TableName = "Result";
        public const string PrimaryKey = "Result_Id";
        public const string SequenceName = "Sq_Result";

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Type, CHAR(1) (null)
        /// </summary>
        public string Result_Type { get; set; }

        /// <summary>
        /// Gets or sets Dilution_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? Dilution_Factor { get; set; }

        /// <summary>
        /// Gets or sets Formatted_Result, VARCHAR2(4000) (null)
        /// </summary>
        public string Formatted_Result { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_File_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_File_Id { get; set; }

        /// <summary>
        /// Gets or sets Original_Result, VARCHAR2(4000) (null)
        /// </summary>
        public string Original_Result { get; set; }

        /// <summary>
        /// Gets or sets Raw_Numeric_Result, NUMBER(22) (null)
        /// </summary>
        public decimal? Raw_Numeric_Result { get; set; }

        /// <summary>
        /// Gets or sets Raw_Datetime_Result, DATE (null)
        /// </summary>
        public DateTime? Raw_Datetime_Result { get; set; }

        /// <summary>
        /// Gets or sets Calculated_Numeric_Result, NUMBER(22) (null)
        /// </summary>
        public decimal? Calculated_Numeric_Result { get; set; }

        /// <summary>
        /// Gets or sets Result_Prefix, CHAR(1) (null)
        /// </summary>
        public string Result_Prefix { get; set; }

        /// <summary>
        /// Gets or sets Conclusion, VARCHAR2(255) (null)
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// Gets or sets Ad_Hoc, CHAR(1) (null)
        /// </summary>
        public string Ad_Hoc { get; set; }

        /// <summary>
        /// Gets or sets Formatted_Unit, VARCHAR2(255) (null)
        /// </summary>
        public string Formatted_Unit { get; set; }

        /// <summary>
        /// Gets or sets Original_Unit, VARCHAR2(255) (null)
        /// </summary>
        public string Original_Unit { get; set; }

        /// <summary>
        /// Gets or sets Modified, CHAR(1) (null)
        /// </summary>
        public string Modified { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Node_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Result_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Test_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Status, CHAR(1) (null)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Old_Status, VARCHAR2(255) (null)
        /// </summary>
        public string Old_Status { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Completed_On, DATE (null)
        /// </summary>
        public DateTime? Completed_On { get; set; }

        /// <summary>
        /// Gets or sets Authorised_On, DATE (null)
        /// </summary>
        public DateTime? Authorised_On { get; set; }

        /// <summary>
        /// Gets or sets Events, VARCHAR2(4000) (null)
        /// </summary>
        public string Events { get; set; }

        /// <summary>
        /// Gets or sets Needs_Review, CHAR(1) (null)
        /// </summary>
        public string Needs_Review { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Inspection_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Has_Notes, CHAR(1) (null)
        /// </summary>
        public string Has_Notes { get; set; }

        /// <summary>
        /// Gets or sets Has_Audits, CHAR(1) (null)
        /// </summary>
        public string Has_Audits { get; set; }

        /// <summary>
        /// Gets or sets Reported, CHAR(1) (null)
        /// </summary>
        public string Reported { get; set; }

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Analyte_Id { get; set; }

        /// <summary>
        /// Gets or sets Created_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Created_By { get; set; }

        /// <summary>
        /// Gets or sets Completed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Completed_By { get; set; }

        /// <summary>
        /// Gets or sets Authorised_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Authorised_By { get; set; }

        /// <summary>
        /// Gets or sets Maximum, NUMBER(22) (null)
        /// </summary>
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Gets or sets Minimum, NUMBER(22) (null)
        /// </summary>
        public decimal? Minimum { get; set; }

        /// <summary>
        /// Gets or sets Rounding_Method, CHAR(1) (null)
        /// </summary>
        public string Rounding_Method { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Failure, CHAR(1) (null)
        /// </summary>
        public string Aqc_Failure { get; set; }

    }
}
