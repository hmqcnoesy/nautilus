using System;

namespace Nautilus.Data
{
    public partial class Inspection_Entry : NautilusEntity
    {
        public const string TableName = "Inspection_Entry";

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Inspection_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Order, NUMBER(22) (not null)
        /// </summary>
        public decimal Inspection_Order { get; set; }

        /// <summary>
        /// Gets or sets Role_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Role_Id { get; set; }

        /// <summary>
        /// Gets or sets Propagate_Up, CHAR(1) (null)
        /// </summary>
        public string Propagate_Up { get; set; }

        /// <summary>
        /// Gets or sets Sequential, CHAR(1) (null)
        /// </summary>
        public string Sequential { get; set; }

        /// <summary>
        /// Gets or sets In_Review, CHAR(1) (null)
        /// </summary>
        public string In_Review { get; set; }

    }
}
