using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Format : NautilusEntity
    {
        public const string TableName = "Worksheet_Format";
        public const string PrimaryKey = "Worksheet_Format_Id";
        public const string SequenceName = "Sq_Worksheet_Format";

        /// <summary>
        /// Gets or sets Worksheet_Format_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Format_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Start_Of_Line, VARCHAR2(10) (null)
        /// </summary>
        public string Start_Of_Line { get; set; }

        /// <summary>
        /// Gets or sets End_Of_Line, VARCHAR2(10) (null)
        /// </summary>
        public string End_Of_Line { get; set; }

        /// <summary>
        /// Gets or sets Field_Separator, VARCHAR2(10) (null)
        /// </summary>
        public string Field_Separator { get; set; }

        /// <summary>
        /// Gets or sets Text_Delimiter, VARCHAR2(10) (null)
        /// </summary>
        public string Text_Delimiter { get; set; }

        /// <summary>
        /// Gets or sets Include_Header_Names, CHAR(1) (null)
        /// </summary>
        public string Include_Header_Names { get; set; }

        /// <summary>
        /// Gets or sets Include_Field_Headers, CHAR(1) (null)
        /// </summary>
        public string Include_Field_Headers { get; set; }

        /// <summary>
        /// Gets or sets Literal_Text1, VARCHAR2(4000) (null)
        /// </summary>
        public string Literal_Text1 { get; set; }

        /// <summary>
        /// Gets or sets Literal_Text2, VARCHAR2(4000) (null)
        /// </summary>
        public string Literal_Text2 { get; set; }

        /// <summary>
        /// Gets or sets Literal_Text3, VARCHAR2(4000) (null)
        /// </summary>
        public string Literal_Text3 { get; set; }

    }
}
