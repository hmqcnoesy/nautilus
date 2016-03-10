using System;

namespace Nautilus.Data
{
    public partial class Location_User_Qa : NautilusEntity
    {
        public const string TableName = "Location_User";

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Location_Id { get; set; }

    }
}
