using System;

namespace Nautilus.Data
{
    public partial class Entity_Link : NautilusEntity
    {
        public const string TableName = "Entity_Link";

        /// <summary>
        /// Gets or sets Child_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Child_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Where_Statement, VARCHAR2(4000) (null)
        /// </summary>
        public string Where_Statement { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Use_Entity_Link, CHAR(1) (null)
        /// </summary>
        public string Use_Entity_Link { get; set; }

        /// <summary>
        /// Gets or sets User_Defined, CHAR(1) (null)
        /// </summary>
        public string User_Defined { get; set; }

    }
}
