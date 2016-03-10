using System;

namespace Nautilus.Data
{
    public partial class Toolbar : NautilusEntity
    {
        public const string TableName = "Toolbar";
        public const string PrimaryKey = "Toolbar_Id";
        public const string SequenceName = "Sq_Toolbar";

        /// <summary>
        /// Gets or sets Toolbar_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Toolbar_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

    }
}
