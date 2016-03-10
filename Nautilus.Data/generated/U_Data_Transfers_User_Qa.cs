using System;

namespace Nautilus.Data
{
    public partial class U_Data_Transfers_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Data_Transfers_User";

        /// <summary>
        /// Gets or sets U_Data_Transfers_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Data_Transfers_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Adcar_Col_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Adcar_Col_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Transfer_Result, CHAR(1) (null)
        /// </summary>
        public string U_Transfer_Result { get; set; }

    }
}
