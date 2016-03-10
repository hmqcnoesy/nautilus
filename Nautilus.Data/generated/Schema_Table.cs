using System;

namespace Nautilus.Data
{
    public partial class Schema_Table : NautilusEntity
    {
        public const string TableName = "Schema_Table";
        public const string PrimaryKey = "Schema_Table_Id";
        public const string SequenceName = "Sq_Schema_Table";

        /// <summary>
        /// Gets or sets Schema_Table_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Database_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Database_Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets User_Defined, CHAR(1) (null)
        /// </summary>
        public string User_Defined { get; set; }

        /// <summary>
        /// Gets or sets Extra_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Extra_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Archived_Set_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Archived_Set_Id { get; set; }

        /// <summary>
        /// Gets or sets Needs_Archiving, CHAR(1) (null)
        /// </summary>
        public string Needs_Archiving { get; set; }

        /// <summary>
        /// Gets or sets Archived, CHAR(1) (null)
        /// </summary>
        public string Archived { get; set; }

        /// <summary>
        /// Gets or sets Archiving_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Archiving_Object { get; set; }

        /// <summary>
        /// Gets or sets Active_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Active_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Exportable, CHAR(1) (null)
        /// </summary>
        public string Exportable { get; set; }

    }
}
