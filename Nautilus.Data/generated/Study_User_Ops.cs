using System;

namespace Nautilus.Data
{
    public partial class Study_User_Ops : NautilusEntity
    {
        public const string TableName = "Study_User";

        /// <summary>
        /// Gets or sets Study_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Study_Id { get; set; }

    }
}
