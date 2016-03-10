using System;

namespace Nautilus.Data
{
    public partial class Sdg_User_Env : NautilusEntity
    {
        public const string TableName = "Sdg_User";

        /// <summary>
        /// Gets or sets Sdg_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sdg_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Invoice_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Invoice_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Client_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Invoice, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Invoice { get; set; }

        /// <summary>
        /// Gets or sets U_Cofa_Report_Date, DATE (null)
        /// </summary>
        public DateTime? U_Cofa_Report_Date { get; set; }

    }
}
