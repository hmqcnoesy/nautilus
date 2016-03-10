using System;

namespace Nautilus.Data
{
    public partial class Pbcatcol : NautilusEntity
    {
        public const string TableName = "Pbcatcol";

        /// <summary>
        /// Gets or sets Pbc_Tnam, VARCHAR2(30) (not null)
        /// </summary>
        public string Pbc_Tnam { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Tid, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Tid { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Ownr, VARCHAR2(30) (not null)
        /// </summary>
        public string Pbc_Ownr { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Cnam, VARCHAR2(30) (not null)
        /// </summary>
        public string Pbc_Cnam { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Cid, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Cid { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Labl, VARCHAR2(254) (null)
        /// </summary>
        public string Pbc_Labl { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Lpos, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Lpos { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Hdr, VARCHAR2(254) (null)
        /// </summary>
        public string Pbc_Hdr { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Hpos, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Hpos { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Jtfy, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Jtfy { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Mask, VARCHAR2(31) (null)
        /// </summary>
        public string Pbc_Mask { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Case, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Case { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Hght, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Hght { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Wdth, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbc_Wdth { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Ptrn, VARCHAR2(31) (null)
        /// </summary>
        public string Pbc_Ptrn { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Bmap, CHAR(1) (null)
        /// </summary>
        public string Pbc_Bmap { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Init, VARCHAR2(254) (null)
        /// </summary>
        public string Pbc_Init { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Cmnt, VARCHAR2(254) (null)
        /// </summary>
        public string Pbc_Cmnt { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Edit, VARCHAR2(31) (null)
        /// </summary>
        public string Pbc_Edit { get; set; }

        /// <summary>
        /// Gets or sets Pbc_Tag, VARCHAR2(254) (null)
        /// </summary>
        public string Pbc_Tag { get; set; }

    }
}
