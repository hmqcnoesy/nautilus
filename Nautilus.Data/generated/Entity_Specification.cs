using System;

namespace Nautilus.Data
{
    public partial class Entity_Specification : NautilusEntity
    {
        public const string TableName = "Entity_Specification";
        public const string PrimaryKey = "Entity_Specification_Id";
        public const string SequenceName = "Sq_Entity_Specification";

        /// <summary>
        /// Gets or sets Entity_Specification_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Entity_Specification_Id { get; set; }

        /// <summary>
        /// Gets or sets Specification_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Specification_Id { get; set; }

        /// <summary>
        /// Gets or sets Table_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Table_Name { get; set; }

        /// <summary>
        /// Gets or sets Record_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Record_Id { get; set; }

    }
}
