using System;

namespace Nautilus.Data
{
    public partial class U_Fp_Success_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Fp_Success_User";

        /// <summary>
        /// Gets or sets U_Fp_Success_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Fp_Success_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Client_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Created_On, DATE (null)
        /// </summary>
        public DateTime? U_Created_On { get; set; }

        /// <summary>
        /// Gets or sets U_Info_Text, VARCHAR2(4000) (null)
        /// </summary>
        public string U_Info_Text { get; set; }

    }
}
