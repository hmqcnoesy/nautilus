using System;

namespace Nautilus.Data
{
    public partial class Cofa_Template_Operator : NautilusEntity
    {
        public const string TableName = "Cofa_Template_Operator";

        /// <summary>
        /// Gets or sets Cofa_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cofa_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

    }
}
