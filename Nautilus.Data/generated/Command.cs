using System;

namespace Nautilus.Data
{
    public partial class Command : NautilusEntity
    {
        public const string TableName = "Command";
        public const string PrimaryKey = "Command_Id";
        public const string SequenceName = "Sq_Command";

        /// <summary>
        /// Gets or sets Command_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Command_Id { get; set; }

        /// <summary>
        /// Gets or sets Config_Item_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Config_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Command_Type, CHAR(1) (null)
        /// </summary>
        public string Command_Type { get; set; }

        /// <summary>
        /// Gets or sets Parameter1, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter1 { get; set; }

        /// <summary>
        /// Gets or sets Parameter2, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter2 { get; set; }

        /// <summary>
        /// Gets or sets Icon_Filename, VARCHAR2(255) (null)
        /// </summary>
        public string Icon_Filename { get; set; }

    }
}
