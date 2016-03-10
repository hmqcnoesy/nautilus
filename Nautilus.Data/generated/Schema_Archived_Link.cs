using System;

namespace Nautilus.Data
{
    public partial class Schema_Archived_Link : NautilusEntity
    {
        public const string TableName = "Schema_Archived_Link";
        public const string PrimaryKey = "Schema_Archived_Link_Id";
        public const string SequenceName = "Sq_Schema_Archived_Link";

        /// <summary>
        /// Gets or sets Schema_Archived_Link_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Archived_Link_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Child_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Child_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Where_Statement, VARCHAR2(4000) (null)
        /// </summary>
        public string Where_Statement { get; set; }

        /// <summary>
        /// Gets or sets V82, VARCHAR2(255) (null)
        /// </summary>
        public string V82 { get; set; }

    }
}
