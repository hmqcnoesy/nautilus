using System;

namespace Nautilus.Data
{
    public partial class Plate_Formulation : NautilusEntity
    {
        public const string TableName = "Plate_Formulation";

        /// <summary>
        /// Gets or sets Parent_Plate_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Parent_Plate_Id { get; set; }

        /// <summary>
        /// Gets or sets Child_Plate_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Child_Plate_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Action_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Plate_Action_Id { get; set; }

    }
}
