using System;

namespace Nautilus.Data
{
    public partial class Rack_Usage_User_Env : NautilusEntity
    {
        public const string TableName = "Rack_Usage_User";

        /// <summary>
        /// Gets or sets Rack_Usage_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Usage_Id { get; set; }

    }
}
