using System;

namespace Nautilus.Data
{
    public partial class Operator_User_Ops : NautilusEntity
    {
        public const string TableName = "Operator_User";

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

    }
}
