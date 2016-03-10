using System;

namespace Nautilus.Data
{
    public partial class Schema_Entity_Extension : NautilusEntity
    {
        public const string TableName = "Schema_Entity_Extension";
        public const string PrimaryKey = "Schema_Entity_Extension_Id";
        public const string SequenceName = "Sq_Schema_Entity_Extension";

        /// <summary>
        /// Gets or sets Schema_Entity_Extension_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Extension_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Extension_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Extension_Icon { get; set; }

    }
}
