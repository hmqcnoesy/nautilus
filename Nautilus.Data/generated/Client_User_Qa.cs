using System;

namespace Nautilus.Data
{
    public partial class Client_User_Qa : NautilusEntity
    {
        public const string TableName = "Client_User";

        /// <summary>
        /// Gets or sets Client_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Client_Id { get; set; }

    }
}
