using System;

namespace Nautilus.Data
{
    public partial class Hazard_User_Qa : NautilusEntity
    {
        public const string TableName = "Hazard_User";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

    }
}
