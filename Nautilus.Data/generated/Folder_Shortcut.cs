using System;

namespace Nautilus.Data
{
    public partial class Folder_Shortcut : NautilusEntity
    {
        public const string TableName = "Folder_Shortcut";
        public const string PrimaryKey = "Folder_Shortcut_Id";
        public const string SequenceName = "Sq_Folder_Shortcut";

        /// <summary>
        /// Gets or sets Folder_Shortcut_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Folder_Shortcut_Id { get; set; }

        /// <summary>
        /// Gets or sets Folder_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Folder_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Where_Statement, VARCHAR2(4000) (null)
        /// </summary>
        public string Where_Statement { get; set; }

    }
}
