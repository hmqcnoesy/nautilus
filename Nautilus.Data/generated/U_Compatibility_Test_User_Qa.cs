using System;

namespace Nautilus.Data
{
    public partial class U_Compatibility_Test_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Compatibility_Test_User";

        /// <summary>
        /// Gets or sets U_Compatibility_Test_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Compatibility_Test_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Item_Description, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Item_Description { get; set; }

        /// <summary>
        /// Gets or sets U_Requested_By, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Requested_By { get; set; }

        /// <summary>
        /// Gets or sets U_Item_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Item_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Ecl, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ecl { get; set; }

        /// <summary>
        /// Gets or sets U_Atk_Lot_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Atk_Lot_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Part_Component_Condition, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Part_Component_Condition { get; set; }

        /// <summary>
        /// Gets or sets U_Chemical_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Chemical_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Hazard_Info, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Hazard_Info { get; set; }

        /// <summary>
        /// Gets or sets U_Where_Used, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Where_Used { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer_Description, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer_Description { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Manufacturer_Lot_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Manufacturer_Lot_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier_Part_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier_Part_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Supplier_Lot_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Supplier_Lot_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Control_Material, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Control_Material { get; set; }

        /// <summary>
        /// Gets or sets U_Lab_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Lab_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Tal_Press_23hrs, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Tal_Press_23hrs { get; set; }

        /// <summary>
        /// Gets or sets U_Tested_On, DATE (null)
        /// </summary>
        public DateTime? U_Tested_On { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Test_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Tal_Max_Press, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Tal_Max_Press { get; set; }

        /// <summary>
        /// Gets or sets U_Tal_Max_Press_Time, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Tal_Max_Press_Time { get; set; }

        /// <summary>
        /// Gets or sets U_Dsc_Mix_Xotherm, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Dsc_Mix_Xotherm { get; set; }

        /// <summary>
        /// Gets or sets U_Dsc_Mix_Xotemp, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Dsc_Mix_Xotemp { get; set; }

        /// <summary>
        /// Gets or sets U_Accept_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Accept_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Comments, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comments { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Id, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Test_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Csr_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Csr_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Last_Updated, DATE (null)
        /// </summary>
        public DateTime? U_Last_Updated { get; set; }

        /// <summary>
        /// Gets or sets U_Category, VARCHAR2(255) (null)
        /// </summary>
        public string U_Category { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Results, VARCHAR2(4000) (null)
        /// </summary>
        public string U_Test_Results { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Location, VARCHAR2(30) (null)
        /// </summary>
        public string U_Test_Location { get; set; }

    }
}
