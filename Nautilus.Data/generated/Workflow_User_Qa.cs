using System;

namespace Nautilus.Data
{
    public partial class Workflow_User_Qa : NautilusEntity
    {
        public const string TableName = "Workflow_User";

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Comments, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comments { get; set; }

        /// <summary>
        /// Gets or sets U_Created_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Created_By { get; set; }

        /// <summary>
        /// Gets or sets U_Created_On, DATE (null)
        /// </summary>
        public DateTime? U_Created_On { get; set; }

        /// <summary>
        /// Gets or sets U_Revised_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Revised_By { get; set; }

        /// <summary>
        /// Gets or sets U_Revised_On, DATE (null)
        /// </summary>
        public DateTime? U_Revised_On { get; set; }

        /// <summary>
        /// Gets or sets U_Revision_Notes, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Revision_Notes { get; set; }

        /// <summary>
        /// Gets or sets U_Program, VARCHAR2(30) (null)
        /// </summary>
        public string U_Program { get; set; }

        /// <summary>
        /// Gets or sets U_Charge_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Charge_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Special_Instructions_Req, CHAR(1) (null)
        /// </summary>
        public string U_Special_Instructions_Req { get; set; }

    }
}
