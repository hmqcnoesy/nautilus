using System;

namespace Nautilus.Data
{
    public partial class Config_Group : NautilusEntity
    {
        public const string TableName = "Config_Group";
        public const string PrimaryKey = "Config_Group_Id";
        public const string SequenceName = "Sq_Config_Group";

        /// <summary>
        /// Gets or sets Config_Group_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Config_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

    }
}
