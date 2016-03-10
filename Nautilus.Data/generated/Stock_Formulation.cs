using System;

namespace Nautilus.Data
{
    public partial class Stock_Formulation : NautilusEntity
    {
        public const string TableName = "Stock_Formulation";

        /// <summary>
        /// Gets or sets Parent_Stock_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Parent_Stock_Id { get; set; }

        /// <summary>
        /// Gets or sets Child_Stock_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Child_Stock_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Amount_Used, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount_Used { get; set; }

        /// <summary>
        /// Gets or sets Dilution_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? Dilution_Factor { get; set; }

    }
}
