using System;

namespace Nautilus.Data
{
    public partial class Supplier_User_Qa : NautilusEntity
    {
        public const string TableName = "Supplier_User";

        /// <summary>
        /// Gets or sets Supplier_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Supplier_Id { get; set; }

    }
}
