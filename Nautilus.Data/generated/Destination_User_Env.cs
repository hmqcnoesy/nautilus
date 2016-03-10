using System;

namespace Nautilus.Data
{
    public partial class Destination_User_Env : NautilusEntity
    {
        public const string TableName = "Destination_User";

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Destination_Id { get; set; }

    }
}
