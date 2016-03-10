using System;

namespace Nautilus.Data
{
    public partial class Lims_Role : NautilusEntity
    {
        public const string TableName = "Lims_Role";
        public const string PrimaryKey = "Role_Id";
        public const string SequenceName = "Sq_Lims_Role";

        /// <summary>
        /// Gets or sets Role_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Role_Id { get; set; }

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
