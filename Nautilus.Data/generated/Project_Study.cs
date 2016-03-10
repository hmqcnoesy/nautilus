using System;

namespace Nautilus.Data
{
    public partial class Project_Study : NautilusEntity
    {
        public const string TableName = "Project_Study";

        /// <summary>
        /// Gets or sets Project_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Project_Id { get; set; }

        /// <summary>
        /// Gets or sets Study_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Study_Id { get; set; }

    }
}
