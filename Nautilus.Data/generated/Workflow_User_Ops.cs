using System;

namespace Nautilus.Data
{
    public partial class Workflow_User_Ops : NautilusEntity
    {
        public const string TableName = "Workflow_User";

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Mechtest_Id, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Mechtest_Id { get; set; }

    }
}
