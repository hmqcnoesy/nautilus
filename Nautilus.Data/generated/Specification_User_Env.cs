using System;

namespace Nautilus.Data
{
    public partial class Specification_User_Env : NautilusEntity
    {
        public const string TableName = "Specification_User";

        /// <summary>
        /// Gets or sets Specification_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Specification_Id { get; set; }

    }
}
