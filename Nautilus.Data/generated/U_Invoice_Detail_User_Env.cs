using System;

namespace Nautilus.Data
{
    public partial class U_Invoice_Detail_User_Env : NautilusEntity
    {
        public const string TableName = "U_Invoice_Detail_User";

        /// <summary>
        /// Gets or sets U_Invoice_Detail_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Invoice_Detail_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Invoice_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Invoice_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Sequence_Id, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Sequence_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Unit_Cost, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Unit_Cost { get; set; }

        /// <summary>
        /// Gets or sets U_Quantity, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Quantity { get; set; }

    }
}
