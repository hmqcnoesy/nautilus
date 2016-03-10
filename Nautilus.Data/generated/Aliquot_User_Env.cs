using System;

namespace Nautilus.Data
{
    public partial class Aliquot_User_Env : NautilusEntity
    {
        public const string TableName = "Aliquot_User";

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Bottles, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Bottles { get; set; }

    }
}
