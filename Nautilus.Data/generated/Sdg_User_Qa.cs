using System;

namespace Nautilus.Data
{
    public partial class Sdg_User_Qa : NautilusEntity
    {
        public const string TableName = "Sdg_User";

        /// <summary>
        /// Gets or sets Sdg_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sdg_Id { get; set; }

    }
}
