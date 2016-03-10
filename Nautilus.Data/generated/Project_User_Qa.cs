using System;

namespace Nautilus.Data
{
    public partial class Project_User_Qa : NautilusEntity
    {
        public const string TableName = "Project_User";

        /// <summary>
        /// Gets or sets Project_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Project_Id { get; set; }

    }
}
