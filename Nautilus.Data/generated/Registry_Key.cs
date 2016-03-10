using System;

namespace Nautilus.Data
{
    public partial class Registry_Key : NautilusEntity
    {
        public const string TableName = "Registry_Key";
        public const string PrimaryKey = "Registry_Key_Id";
        public const string SequenceName = "Sq_Registry_Key";

        /// <summary>
        /// Gets or sets Registry_Key_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Registry_Key_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Key_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Key_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

    }
}
