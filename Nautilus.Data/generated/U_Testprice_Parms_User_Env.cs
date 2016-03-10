using System;

namespace Nautilus.Data
{
    public partial class U_Testprice_Parms_User_Env : NautilusEntity
    {
        public const string TableName = "U_Testprice_Parms_User";

        /// <summary>
        /// Gets or sets U_Testprice_Parms_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Testprice_Parms_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Test, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Test { get; set; }

        /// <summary>
        /// Gets or sets U_Max_Test_Price, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Max_Test_Price { get; set; }

        /// <summary>
        /// Gets or sets U_Per_Result_Price, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Per_Result_Price { get; set; }

    }
}
