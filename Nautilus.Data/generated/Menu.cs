using System;

namespace Nautilus.Data
{
    public partial class Menu : NautilusEntity
    {
        public const string TableName = "Menu";
        public const string PrimaryKey = "Menu_Id";
        public const string SequenceName = "Sq_Menu";

        /// <summary>
        /// Gets or sets Menu_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Menu_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Menu_Item_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Menu_Item_Name { get; set; }

        /// <summary>
        /// Gets or sets Menu_Item_Type, CHAR(1) (null)
        /// </summary>
        public string Menu_Item_Type { get; set; }

        /// <summary>
        /// Gets or sets Config_Item_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Config_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Parameter1, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter1 { get; set; }

        /// <summary>
        /// Gets or sets Parameter2, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter2 { get; set; }

        /// <summary>
        /// Gets or sets Is_Tool, CHAR(1) (null)
        /// </summary>
        public string Is_Tool { get; set; }

    }
}
