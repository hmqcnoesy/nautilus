using System;

namespace Nautilus.Data
{
    public partial class X_Compat_Master_User_Qa : NautilusEntity
    {
        public const string TableName = "X_Compat_Master_User";

        /// <summary>
        /// Gets or sets U_Compat_Master_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Compat_Master_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Bacchus_Item_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Bacchus_Item_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Promontory_Item_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Promontory_Item_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Lwi_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Lwi_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Category, VARCHAR2(30) (null)
        /// </summary>
        public string U_Category { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier { get; set; }

        /// <summary>
        /// Gets or sets U_Tested_On, DATE (null)
        /// </summary>
        public DateTime? U_Tested_On { get; set; }

        /// <summary>
        /// Gets or sets U_Control_Materials, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Control_Materials { get; set; }

        /// <summary>
        /// Gets or sets U_Control_Materials_Reject, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Control_Materials_Reject { get; set; }

        /// <summary>
        /// Gets or sets U_Accept_Or_Reject, VARCHAR2(30) (null)
        /// </summary>
        public string U_Accept_Or_Reject { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Results, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Test_Results { get; set; }

        /// <summary>
        /// Gets or sets U_Comments, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comments { get; set; }

        /// <summary>
        /// Gets or sets U_Contact_Item, CHAR(1) (null)
        /// </summary>
        public string U_Contact_Item { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Location, VARCHAR2(30) (null)
        /// </summary>
        public string U_Test_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Maintenance_Item, CHAR(1) (null)
        /// </summary>
        public string U_Maintenance_Item { get; set; }

        /// <summary>
        /// Gets or sets U_Testing_Exempt, CHAR(1) (null)
        /// </summary>
        public string U_Testing_Exempt { get; set; }

    }
}
