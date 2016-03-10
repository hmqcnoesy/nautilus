using System;

namespace Nautilus.Data
{
    public partial class Analyte_User_Env : NautilusEntity
    {
        public const string TableName = "Analyte_User";

        /// <summary>
        /// Gets or sets Analyte_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Analyte_Id { get; set; }

    }
}
