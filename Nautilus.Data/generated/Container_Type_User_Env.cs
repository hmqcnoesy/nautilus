using System;

namespace Nautilus.Data
{
    public partial class Container_Type_User_Env : NautilusEntity
    {
        public const string TableName = "Container_Type_User";

        /// <summary>
        /// Gets or sets Container_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Container_Type_Id { get; set; }

    }
}
