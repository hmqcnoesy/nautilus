using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Format_Field : NautilusEntity
    {
        public const string TableName = "Worksheet_Format_Field";

        /// <summary>
        /// Gets or sets Worksheet_Format_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Format_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Format_Usage, CHAR(1) (not null)
        /// </summary>
        public string Worksheet_Format_Usage { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Format_Order, NUMBER(22) (not null)
        /// </summary>
        public decimal Worksheet_Format_Order { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Lookup_Schema_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Lookup_Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Field_Title, VARCHAR2(255) (null)
        /// </summary>
        public string Field_Title { get; set; }

        /// <summary>
        /// Gets or sets Datatype, CHAR(1) (null)
        /// </summary>
        public string Datatype { get; set; }

        /// <summary>
        /// Gets or sets Field_Format, VARCHAR2(255) (null)
        /// </summary>
        public string Field_Format { get; set; }

        /// <summary>
        /// Gets or sets Field_Width, NUMBER(10) (null)
        /// </summary>
        public decimal? Field_Width { get; set; }

        /// <summary>
        /// Gets or sets Fixed_Width, CHAR(1) (null)
        /// </summary>
        public string Fixed_Width { get; set; }

        /// <summary>
        /// Gets or sets Right_Justify, CHAR(1) (null)
        /// </summary>
        public string Right_Justify { get; set; }

        /// <summary>
        /// Gets or sets Add_Separator, CHAR(1) (null)
        /// </summary>
        public string Add_Separator { get; set; }

        /// <summary>
        /// Gets or sets Field_Default, VARCHAR2(255) (null)
        /// </summary>
        public string Field_Default { get; set; }

        /// <summary>
        /// Gets or sets String_Start, NUMBER(10) (null)
        /// </summary>
        public decimal? String_Start { get; set; }

        /// <summary>
        /// Gets or sets String_Length, NUMBER(10) (null)
        /// </summary>
        public decimal? String_Length { get; set; }

    }
}
