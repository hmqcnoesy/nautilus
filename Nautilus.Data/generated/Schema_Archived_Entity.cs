using System;

namespace Nautilus.Data
{
    public partial class Schema_Archived_Entity : NautilusEntity
    {
        public const string TableName = "Schema_Archived_Entity";
        public const string PrimaryKey = "Schema_Archived_Entity_Id";
        public const string SequenceName = "Sq_Schema_Archived_Entity";

        /// <summary>
        /// Gets or sets Schema_Archived_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Archived_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Datastore_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Datastore_Object { get; set; }

        /// <summary>
        /// Gets or sets Interface_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Interface_Object { get; set; }

        /// <summary>
        /// Gets or sets Default_Selected_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Default_Selected_Icon { get; set; }

        /// <summary>
        /// Gets or sets Default_Unselected_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Default_Unselected_Icon { get; set; }

        /// <summary>
        /// Gets or sets Name_Field, VARCHAR2(30) (null)
        /// </summary>
        public string Name_Field { get; set; }

        /// <summary>
        /// Gets or sets Order_Field, VARCHAR2(30) (null)
        /// </summary>
        public string Order_Field { get; set; }

    }
}
