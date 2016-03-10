using System;

namespace Nautilus.Data
{
    public partial class Aliquot_Formulation : NautilusEntity
    {
        public const string TableName = "Aliquot_Formulation";

        /// <summary>
        /// Gets or sets Parent_Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Parent_Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Child_Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Child_Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Amount_Used, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount_Used { get; set; }

        /// <summary>
        /// Gets or sets Dilution_Factor, NUMBER(22) (null)
        /// </summary>
        public decimal? Dilution_Factor { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

    }
}
