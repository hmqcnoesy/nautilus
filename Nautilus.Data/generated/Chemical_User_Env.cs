using System;

namespace Nautilus.Data
{
    public partial class Chemical_User_Env : NautilusEntity
    {
        public const string TableName = "Chemical_User";

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Chemical_Id { get; set; }

    }
}
