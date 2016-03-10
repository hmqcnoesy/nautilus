using System;

namespace Nautilus.Data
{
    public partial class Aliquot_Analyte : NautilusEntity
    {
        public const string TableName = "Aliquot_Analyte";

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Analyte_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Concentration, NUMBER(22) (null)
        /// </summary>
        public decimal? Concentration { get; set; }

        /// <summary>
        /// Gets or sets Comments, VARCHAR2(4000) (null)
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets Conclusion, VARCHAR2(255) (null)
        /// </summary>
        public string Conclusion { get; set; }

    }
}
