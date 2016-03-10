using System;

namespace Nautilus.Data
{
    public partial class Config_Item : NautilusEntity
    {
        public const string TableName = "Config_Item";
        public const string PrimaryKey = "Config_Item_Id";
        public const string SequenceName = "Sq_Config_Item";

        /// <summary>
        /// Gets or sets Config_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Config_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets User_Modifiable, CHAR(1) (null)
        /// </summary>
        public string User_Modifiable { get; set; }

        /// <summary>
        /// Gets or sets Config_Group_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Config_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets System_Value, VARCHAR2(255) (null)
        /// </summary>
        public string System_Value { get; set; }

        /// <summary>
        /// Gets or sets System_Only, CHAR(1) (null)
        /// </summary>
        public string System_Only { get; set; }

        /// <summary>
        /// Gets or sets Type_Param, VARCHAR2(255) (null)
        /// </summary>
        public string Type_Param { get; set; }

        /// <summary>
        /// Gets or sets Config_Data_Type, CHAR(1) (null)
        /// </summary>
        public string Config_Data_Type { get; set; }

        /// <summary>
        /// Gets or sets Config_Item_Type, CHAR(1) (null)
        /// </summary>
        public string Config_Item_Type { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Object_Name { get; set; }

    }
}
