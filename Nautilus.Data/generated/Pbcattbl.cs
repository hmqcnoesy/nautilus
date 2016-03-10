using System;

namespace Nautilus.Data
{
    public partial class Pbcattbl : NautilusEntity
    {
        public const string TableName = "Pbcattbl";

        /// <summary>
        /// Gets or sets Pbt_Tnam, VARCHAR2(30) (not null)
        /// </summary>
        public string Pbt_Tnam { get; set; }

        /// <summary>
        /// Gets or sets Pbt_Tid, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbt_Tid { get; set; }

        /// <summary>
        /// Gets or sets Pbt_Ownr, VARCHAR2(30) (not null)
        /// </summary>
        public string Pbt_Ownr { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Fhgt, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbd_Fhgt { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Fwgt, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbd_Fwgt { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Fitl, CHAR(1) (null)
        /// </summary>
        public string Pbd_Fitl { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Funl, CHAR(1) (null)
        /// </summary>
        public string Pbd_Funl { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Fchr, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbd_Fchr { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Fptc, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbd_Fptc { get; set; }

        /// <summary>
        /// Gets or sets Pbd_Ffce, VARCHAR2(18) (null)
        /// </summary>
        public string Pbd_Ffce { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Fhgt, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbh_Fhgt { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Fwgt, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbh_Fwgt { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Fitl, CHAR(1) (null)
        /// </summary>
        public string Pbh_Fitl { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Funl, CHAR(1) (null)
        /// </summary>
        public string Pbh_Funl { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Fchr, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbh_Fchr { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Fptc, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbh_Fptc { get; set; }

        /// <summary>
        /// Gets or sets Pbh_Ffce, VARCHAR2(18) (null)
        /// </summary>
        public string Pbh_Ffce { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Fhgt, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbl_Fhgt { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Fwgt, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbl_Fwgt { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Fitl, CHAR(1) (null)
        /// </summary>
        public string Pbl_Fitl { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Funl, CHAR(1) (null)
        /// </summary>
        public string Pbl_Funl { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Fchr, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbl_Fchr { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Fptc, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbl_Fptc { get; set; }

        /// <summary>
        /// Gets or sets Pbl_Ffce, VARCHAR2(18) (null)
        /// </summary>
        public string Pbl_Ffce { get; set; }

        /// <summary>
        /// Gets or sets Pbt_Cmnt, VARCHAR2(254) (null)
        /// </summary>
        public string Pbt_Cmnt { get; set; }

    }
}
