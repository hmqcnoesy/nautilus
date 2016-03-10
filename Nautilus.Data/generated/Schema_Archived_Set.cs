using System;

namespace Nautilus.Data
{
    public partial class Schema_Archived_Set : NautilusEntity
    {
        public const string TableName = "Schema_Archived_Set";
        public const string PrimaryKey = "Schema_Archived_Set_Id";
        public const string SequenceName = "Sq_Schema_Archived_Set";

        /// <summary>
        /// Gets or sets Schema_Archived_Set_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Archived_Set_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Code, VARCHAR2(3) (null)
        /// </summary>
        public string Code { get; set; }

    }
}
