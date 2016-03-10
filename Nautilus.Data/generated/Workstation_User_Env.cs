using System;

namespace Nautilus.Data
{
    public partial class Workstation_User_Env : NautilusEntity
    {
        public const string TableName = "Workstation_User";

        /// <summary>
        /// Gets or sets Workstation_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workstation_Id { get; set; }

    }
}
