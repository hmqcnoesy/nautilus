using System;

namespace Nautilus.Data
{
    public partial class Operator_Role : NautilusEntity
    {
        public const string TableName = "Operator_Role";

        /// <summary>
        /// Gets or sets Role_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Role_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

    }
}
