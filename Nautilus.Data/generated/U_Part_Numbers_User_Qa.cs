using System;

namespace Nautilus.Data
{
    public partial class U_Part_Numbers_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Part_Numbers_User";

        /// <summary>
        /// Gets or sets U_Part_Numbers_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Part_Numbers_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Testing, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Testing { get; set; }

        /// <summary>
        /// Gets or sets U_Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Workflow_Id { get; set; }

    }
}
