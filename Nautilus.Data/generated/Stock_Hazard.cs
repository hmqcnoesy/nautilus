using System;

namespace Nautilus.Data
{
    public partial class Stock_Hazard : NautilusEntity
    {
        public const string TableName = "Stock_Hazard";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stock_Template_Id { get; set; }

    }
}
