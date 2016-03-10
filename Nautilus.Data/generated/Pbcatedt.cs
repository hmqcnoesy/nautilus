using System;

namespace Nautilus.Data
{
    public partial class Pbcatedt : NautilusEntity
    {
        public const string TableName = "Pbcatedt";

        /// <summary>
        /// Gets or sets Pbe_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Pbe_Name { get; set; }

        /// <summary>
        /// Gets or sets Pbe_Edit, VARCHAR2(254) (null)
        /// </summary>
        public string Pbe_Edit { get; set; }

        /// <summary>
        /// Gets or sets Pbe_Type, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbe_Type { get; set; }

        /// <summary>
        /// Gets or sets Pbe_Cntr, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbe_Cntr { get; set; }

        /// <summary>
        /// Gets or sets Pbe_Seqn, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbe_Seqn { get; set; }

        /// <summary>
        /// Gets or sets Pbe_Flag, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbe_Flag { get; set; }

        /// <summary>
        /// Gets or sets Pbe_Work, VARCHAR2(32) (null)
        /// </summary>
        public string Pbe_Work { get; set; }

    }
}
