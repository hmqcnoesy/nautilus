using System;

namespace Nautilus.Data
{
    public partial class U_Invoice_Header_User_Env : NautilusEntity
    {
        public const string TableName = "U_Invoice_Header_User";

        /// <summary>
        /// Gets or sets U_Invoice_Header_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Invoice_Header_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Voucher_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Voucher_No { get; set; }

        /// <summary>
        /// Gets or sets U_Date_Printed, DATE (null)
        /// </summary>
        public DateTime? U_Date_Printed { get; set; }

        /// <summary>
        /// Gets or sets U_Date_Created, DATE (null)
        /// </summary>
        public DateTime? U_Date_Created { get; set; }

    }
}
