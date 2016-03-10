using System;

namespace Nautilus.Data
{
    public partial class Sdg_User_Ops : NautilusEntity
    {
        public const string TableName = "Sdg_User";

        /// <summary>
        /// Gets or sets Sdg_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sdg_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Project, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Project { get; set; }

        /// <summary>
        /// Gets or sets U_Task, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Task { get; set; }

        /// <summary>
        /// Gets or sets U_Clientname, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Clientname { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Email, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Email { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Phone, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Phone { get; set; }

        /// <summary>
        /// Gets or sets U_Plan_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Plan_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Energetic, CHAR(1) (null)
        /// </summary>
        public string U_Energetic { get; set; }

        /// <summary>
        /// Gets or sets U_Limits_Ll_String, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Limits_Ll_String { get; set; }

        /// <summary>
        /// Gets or sets U_Limits_Ul_String, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Limits_Ul_String { get; set; }

        /// <summary>
        /// Gets or sets U_Planning_Index, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Planning_Index { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Dept, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Dept { get; set; }

        /// <summary>
        /// Gets or sets U_Client_Mailstop, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Client_Mailstop { get; set; }

    }
}
