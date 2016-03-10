using System;

namespace Nautilus.Data
{
    public partial class Instrument_Control : NautilusEntity
    {
        public const string TableName = "Instrument_Control";
        public const string PrimaryKey = "Instrument_Control_Id";
        public const string SequenceName = "Sq_Instrument_Control";

        /// <summary>
        /// Gets or sets Instrument_Control_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Control_Id { get; set; }

        /// <summary>
        /// Gets or sets Building_Script_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Building_Script_Id { get; set; }

        /// <summary>
        /// Gets or sets Parsing_Script_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parsing_Script_Id { get; set; }

        /// <summary>
        /// Gets or sets Mapping_Script_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Mapping_Script_Id { get; set; }

        /// <summary>
        /// Gets or sets Interface_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Interface_Type { get; set; }

        /// <summary>
        /// Gets or sets Interface_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Interface_Name { get; set; }

        /// <summary>
        /// Gets or sets Baud_Rate, VARCHAR2(10) (null)
        /// </summary>
        public string Baud_Rate { get; set; }

        /// <summary>
        /// Gets or sets Data_Bits, CHAR(1) (null)
        /// </summary>
        public string Data_Bits { get; set; }

        /// <summary>
        /// Gets or sets Stop_Bits, VARCHAR2(3) (null)
        /// </summary>
        public string Stop_Bits { get; set; }

        /// <summary>
        /// Gets or sets Parity, VARCHAR2(5) (null)
        /// </summary>
        public string Parity { get; set; }

        /// <summary>
        /// Gets or sets Flow_Control, VARCHAR2(10) (null)
        /// </summary>
        public string Flow_Control { get; set; }

        /// <summary>
        /// Gets or sets Input_File_Directory, VARCHAR2(128) (null)
        /// </summary>
        public string Input_File_Directory { get; set; }

        /// <summary>
        /// Gets or sets Input_File_Extension, VARCHAR2(3) (null)
        /// </summary>
        public string Input_File_Extension { get; set; }

        /// <summary>
        /// Gets or sets Output_File_Directory, VARCHAR2(128) (null)
        /// </summary>
        public string Output_File_Directory { get; set; }

        /// <summary>
        /// Gets or sets Output_File_Extension, VARCHAR2(3) (null)
        /// </summary>
        public string Output_File_Extension { get; set; }

        /// <summary>
        /// Gets or sets Copy_File, CHAR(1) (null)
        /// </summary>
        public string Copy_File { get; set; }

        /// <summary>
        /// Gets or sets Print_File, CHAR(1) (null)
        /// </summary>
        public string Print_File { get; set; }

        /// <summary>
        /// Gets or sets File_Delimiting, CHAR(1) (null)
        /// </summary>
        public string File_Delimiting { get; set; }

        /// <summary>
        /// Gets or sets Start_Of_File, VARCHAR2(128) (null)
        /// </summary>
        public string Start_Of_File { get; set; }

        /// <summary>
        /// Gets or sets End_Of_File, VARCHAR2(128) (null)
        /// </summary>
        public string End_Of_File { get; set; }

        /// <summary>
        /// Gets or sets Message_Delimiting, CHAR(1) (null)
        /// </summary>
        public string Message_Delimiting { get; set; }

        /// <summary>
        /// Gets or sets Start_Of_Message, VARCHAR2(128) (null)
        /// </summary>
        public string Start_Of_Message { get; set; }

        /// <summary>
        /// Gets or sets End_Of_Message, VARCHAR2(128) (null)
        /// </summary>
        public string End_Of_Message { get; set; }

        /// <summary>
        /// Gets or sets Skip_After_Som, NUMBER(22) (null)
        /// </summary>
        public decimal? Skip_After_Som { get; set; }

        /// <summary>
        /// Gets or sets Timeout, NUMBER(22) (null)
        /// </summary>
        public decimal? Timeout { get; set; }

        /// <summary>
        /// Gets or sets Discard_Chars, VARCHAR2(128) (null)
        /// </summary>
        public string Discard_Chars { get; set; }

        /// <summary>
        /// Gets or sets Start_Command, VARCHAR2(128) (null)
        /// </summary>
        public string Start_Command { get; set; }

        /// <summary>
        /// Gets or sets Reply_Eom, VARCHAR2(128) (null)
        /// </summary>
        public string Reply_Eom { get; set; }

        /// <summary>
        /// Gets or sets Reply_Eof, VARCHAR2(128) (null)
        /// </summary>
        public string Reply_Eof { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Input_File_Subdirectories, CHAR(1) (null)
        /// </summary>
        public string Input_File_Subdirectories { get; set; }

        /// <summary>
        /// Gets or sets Rsf_Directory, VARCHAR2(128) (null)
        /// </summary>
        public string Rsf_Directory { get; set; }

        /// <summary>
        /// Gets or sets Rsf_Extension, VARCHAR2(3) (null)
        /// </summary>
        public string Rsf_Extension { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Format_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Worksheet_Format_Id { get; set; }

        /// <summary>
        /// Gets or sets Rsf_Preview, CHAR(1) (null)
        /// </summary>
        public string Rsf_Preview { get; set; }

    }
}
