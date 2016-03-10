using System;

namespace Nautilus.Data
{
    public partial class U_Ext_Client_Info_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Ext_Client_Info_User";

        /// <summary>
        /// Gets or sets U_Ext_Client_Info_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Ext_Client_Info_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Full_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Full_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Email, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Email { get; set; }

        /// <summary>
        /// Gets or sets U_Telephone, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Telephone { get; set; }

        /// <summary>
        /// Gets or sets U_Department, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Department { get; set; }

        /// <summary>
        /// Gets or sets U_Mail_Stop, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Mail_Stop { get; set; }

        /// <summary>
        /// Gets or sets U_Organization_Id, VARCHAR2(200) (null)
        /// </summary>
        public string U_Organization_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Parent_Org_Id, VARCHAR2(200) (null)
        /// </summary>
        public string U_Parent_Org_Id { get; set; }

    }
}
