using System;

namespace Nautilus.Data
{
    public partial class Project_User_Env : NautilusEntity
    {
        public const string TableName = "Project_User";

        /// <summary>
        /// Gets or sets Project_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Project_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Client_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Charge_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Charge_No { get; set; }

        /// <summary>
        /// Gets or sets U_Purchace_Ord_No, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Purchace_Ord_No { get; set; }

        /// <summary>
        /// Gets or sets U_Task, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Task { get; set; }

        /// <summary>
        /// Gets or sets U_Subcode, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Subcode { get; set; }

    }
}
