using System;

namespace Nautilus.Data
{
    public partial class Analyte_Stock : NautilusEntity
    {
        public const string TableName = "Analyte_Stock";

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Analyte_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Concentration, NUMBER(22) (null)
        /// </summary>
        public decimal? Concentration { get; set; }

    }
}
