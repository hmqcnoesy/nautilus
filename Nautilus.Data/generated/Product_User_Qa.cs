using System;

namespace Nautilus.Data
{
    public partial class Product_User_Qa : NautilusEntity
    {
        public const string TableName = "Product_User";

        /// <summary>
        /// Gets or sets Product_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Product_Id { get; set; }

    }
}
