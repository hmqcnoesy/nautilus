using System;

namespace Nautilus.Data
{
    public partial class Stock_Supplier : NautilusEntity
    {
        public const string TableName = "Stock_Supplier";

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Supplier_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Supplier_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Amount, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets Preferred, CHAR(1) (null)
        /// </summary>
        public string Preferred { get; set; }

    }
}
