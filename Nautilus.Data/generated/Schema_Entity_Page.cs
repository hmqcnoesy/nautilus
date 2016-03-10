using System;

namespace Nautilus.Data
{
    public partial class Schema_Entity_Page : NautilusEntity
    {
        public const string TableName = "Schema_Entity_Page";
        public const string PrimaryKey = "Schema_Entity_Page_Id";
        public const string SequenceName = "Sq_Schema_Entity_Page";

        /// <summary>
        /// Gets or sets Schema_Entity_Page_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Page_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Extension_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled, CHAR(1) (null)
        /// </summary>
        public string Enabled { get; set; }

        /// <summary>
        /// Gets or sets System, CHAR(1) (null)
        /// </summary>
        public string System { get; set; }

        /// <summary>
        /// Gets or sets Page_Type, CHAR(1) (null)
        /// </summary>
        public string Page_Type { get; set; }

    }
}
