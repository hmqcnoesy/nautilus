using System;

namespace Nautilus.Data
{
    public partial class Schema_Field_Prompt : NautilusEntity
    {
        public const string TableName = "Schema_Field_Prompt";
        public const string PrimaryKey = "Schema_Field_Prompt_Id";
        public const string SequenceName = "Sq_Schema_Field_Prompt";

        /// <summary>
        /// Gets or sets Schema_Field_Prompt_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Field_Prompt_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Type { get; set; }

        /// <summary>
        /// Gets or sets Default_Text, VARCHAR2(4000) (null)
        /// </summary>
        public string Default_Text { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Prompt_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Default_Num, NUMBER(22) (null)
        /// </summary>
        public decimal? Default_Num { get; set; }

        /// <summary>
        /// Gets or sets Info_Num1, NUMBER(22) (null)
        /// </summary>
        public decimal? Info_Num1 { get; set; }

        /// <summary>
        /// Gets or sets Info_Num2, NUMBER(22) (null)
        /// </summary>
        public decimal? Info_Num2 { get; set; }

        /// <summary>
        /// Gets or sets Info_Num3, NUMBER(22) (null)
        /// </summary>
        public decimal? Info_Num3 { get; set; }

        /// <summary>
        /// Gets or sets Info_Text1, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text1 { get; set; }

        /// <summary>
        /// Gets or sets Info_Text2, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text2 { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Text, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Text { get; set; }

        /// <summary>
        /// Gets or sets Allow_In_Template, CHAR(1) (null)
        /// </summary>
        public string Allow_In_Template { get; set; }

        /// <summary>
        /// Gets or sets Readonly_Flag, CHAR(1) (null)
        /// </summary>
        public string Readonly_Flag { get; set; }

    }
}
