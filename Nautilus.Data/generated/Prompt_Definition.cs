using System;

namespace Nautilus.Data
{
    public partial class Prompt_Definition : NautilusEntity
    {
        public const string TableName = "Prompt_Definition";

        /// <summary>
        /// Gets or sets Prompt_Table, VARCHAR2(30) (not null)
        /// </summary>
        public string Prompt_Table { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Column, VARCHAR2(30) (not null)
        /// </summary>
        public string Prompt_Column { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Type { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Text, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Text { get; set; }

        /// <summary>
        /// Gets or sets Default_Num, NUMBER(22) (null)
        /// </summary>
        public decimal? Default_Num { get; set; }

        /// <summary>
        /// Gets or sets Default_Text, VARCHAR2(4000) (null)
        /// </summary>
        public string Default_Text { get; set; }

        /// <summary>
        /// Gets or sets Info_Text1, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text1 { get; set; }

        /// <summary>
        /// Gets or sets Info_Text2, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text2 { get; set; }

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
        /// Gets or sets Background_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Background_Object { get; set; }

        /// <summary>
        /// Gets or sets Edit_Mask, VARCHAR2(255) (null)
        /// </summary>
        public string Edit_Mask { get; set; }

        /// <summary>
        /// Gets or sets Config_Item_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Config_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Allow_In_Template, CHAR(1) (null)
        /// </summary>
        public string Allow_In_Template { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Can_Lookup_Spec, CHAR(1) (null)
        /// </summary>
        public string Can_Lookup_Spec { get; set; }

    }
}
