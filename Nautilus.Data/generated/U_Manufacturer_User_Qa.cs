using System;

namespace Nautilus.Data
{
    public partial class U_Manufacturer_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Manufacturer_User";

        /// <summary>
        /// Gets or sets U_Manufacturer_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Manufacturer_Id { get; set; }

    }
}
