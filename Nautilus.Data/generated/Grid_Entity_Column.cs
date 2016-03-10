using System;

namespace Nautilus.Data
{
    public partial class Grid_Entity_Column : NautilusEntity
    {
        public const string TableName = "Grid_Entity_Column";
        public const string PrimaryKey = "Entity_Column_Id";
        public const string SequenceName = "Sq_Grid_Entity_Column";

        /// <summary>
        /// Gets or sets Entity_Column_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Entity_Column_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Column_Width, NUMBER(10) (null)
        /// </summary>
        public decimal? Column_Width { get; set; }

        /// <summary>
        /// Gets or sets Lookup_Schema_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Lookup_Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Index, NUMBER(22) (null)
        /// </summary>
        public decimal? Group_Index { get; set; }

        /// <summary>
        /// Gets or sets Sort_Index, NUMBER(22) (null)
        /// </summary>
        public decimal? Sort_Index { get; set; }

        /// <summary>
        /// Gets or sets Sort_Order, CHAR(1) (null)
        /// </summary>
        public string Sort_Order { get; set; }

        /// <summary>
        /// Gets or sets Parent_Object, VARCHAR2(30) (null)
        /// </summary>
        public string Parent_Object { get; set; }

    }
}
