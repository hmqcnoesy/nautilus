using System;

namespace Nautilus.Data
{
    public partial class Calculation_Node : NautilusEntity
    {
        public const string TableName = "Calculation_Node";
        public const string PrimaryKey = "Calculation_Node_Id";
        public const string SequenceName = "Sq_Calculation_Node";

        /// <summary>
        /// Gets or sets Calculation_Node_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calculation_Node_Id { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Calculation_Id { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Node_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Calculation_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Parameter, VARCHAR2(4000) (null)
        /// </summary>
        public string Parameter { get; set; }

    }
}
