using System;

namespace Nautilus.Data
{
    public partial class Result_Template : NautilusEntity
    {
        public const string TableName = "Result_Template";
        public const string PrimaryKey = "Result_Template_Id";
        public const string SequenceName = "Sq_Result_Template";

        /// <summary>
        /// Gets or sets Result_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Result_Type, CHAR(1) (null)
        /// </summary>
        public string Result_Type { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Phrase_Id { get; set; }

        /// <summary>
        /// Gets or sets Dilution_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? Dilution_Factor { get; set; }

        /// <summary>
        /// Gets or sets Maximum, NUMBER(22) (null)
        /// </summary>
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Gets or sets Minimum, NUMBER(22) (null)
        /// </summary>
        public decimal? Minimum { get; set; }

        /// <summary>
        /// Gets or sets True_Word, VARCHAR2(255) (null)
        /// </summary>
        public string True_Word { get; set; }

        /// <summary>
        /// Gets or sets False_Word, VARCHAR2(255) (null)
        /// </summary>
        public string False_Word { get; set; }

        /// <summary>
        /// Gets or sets Allowed_Characters, VARCHAR2(255) (null)
        /// </summary>
        public string Allowed_Characters { get; set; }

        /// <summary>
        /// Gets or sets Decimal_Places, NUMBER(22) (null)
        /// </summary>
        public decimal? Decimal_Places { get; set; }

        /// <summary>
        /// Gets or sets Significant_Figures, NUMBER(22) (null)
        /// </summary>
        public decimal? Significant_Figures { get; set; }

        /// <summary>
        /// Gets or sets Ole_Class, VARCHAR2(255) (null)
        /// </summary>
        public string Ole_Class { get; set; }

        /// <summary>
        /// Gets or sets Default_Result, VARCHAR2(4000) (null)
        /// </summary>
        public string Default_Result { get; set; }

        /// <summary>
        /// Gets or sets File_Directory, VARCHAR2(255) (null)
        /// </summary>
        public string File_Directory { get; set; }

        /// <summary>
        /// Gets or sets File_Extension, VARCHAR2(255) (null)
        /// </summary>
        public string File_Extension { get; set; }

        /// <summary>
        /// Gets or sets Choose_From_Phrase, CHAR(1) (null)
        /// </summary>
        public string Choose_From_Phrase { get; set; }

        /// <summary>
        /// Gets or sets Validate_From_Phrase, CHAR(1) (null)
        /// </summary>
        public string Validate_From_Phrase { get; set; }

        /// <summary>
        /// Gets or sets Original_Unit, VARCHAR2(255) (null)
        /// </summary>
        public string Original_Unit { get; set; }

        /// <summary>
        /// Gets or sets Formatted_Unit, VARCHAR2(255) (null)
        /// </summary>
        public string Formatted_Unit { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Classification, VARCHAR2(255) (null)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Calculation_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Inspection_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Reported, CHAR(1) (null)
        /// </summary>
        public string Reported { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Analyte_Id { get; set; }

        /// <summary>
        /// Gets or sets Usage, VARCHAR2(255) (null)
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets Rounding_Method, CHAR(1) (null)
        /// </summary>
        public string Rounding_Method { get; set; }

        /// <summary>
        /// Gets or sets Has_Limits, CHAR(1) (null)
        /// </summary>
        public string Has_Limits { get; set; }

        /// <summary>
        /// Gets or sets Format, VARCHAR2(255) (null)
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets Allow_Out_Of_Limit, CHAR(1) (null)
        /// </summary>
        public string Allow_Out_Of_Limit { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Extension_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

    }
}
