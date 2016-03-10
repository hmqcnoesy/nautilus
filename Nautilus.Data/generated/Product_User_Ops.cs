using System;

namespace Nautilus.Data
{
    public partial class Product_User_Ops : NautilusEntity
    {
        public const string TableName = "Product_User";

        /// <summary>
        /// Gets or sets Product_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Product_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Material_Id { get; set; }

    }
}
