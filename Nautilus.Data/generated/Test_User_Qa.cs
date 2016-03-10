using System;

namespace Nautilus.Data
{
    public partial class Test_User_Qa : NautilusEntity
    {
        public const string TableName = "Test_User";

        /// <summary>
        /// Gets or sets Test_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Matrix_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Matrix_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Vendor_Data, CHAR(1) (null)
        /// </summary>
        public string U_Vendor_Data { get; set; }

        /// <summary>
        /// Gets or sets U_Ip_Item_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ip_Item_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Tested_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Tested_By { get; set; }

        /// <summary>
        /// Gets or sets U_Row_Id, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Row_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Tested_By_Text, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Tested_By_Text { get; set; }

        /// <summary>
        /// Gets or sets U_Instrument, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Instrument { get; set; }

        /// <summary>
        /// Gets or sets U_Temperature, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Temperature { get; set; }

        /// <summary>
        /// Gets or sets U_Humidity, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Humidity { get; set; }

        /// <summary>
        /// Gets or sets U_Replicates, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Replicates { get; set; }

        /// <summary>
        /// Gets or sets U_Raw_Data_File_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Raw_Data_File_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Hours_Worked, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Hours_Worked { get; set; }

        /// <summary>
        /// Gets or sets U_Unauthorization, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Unauthorization { get; set; }

        /// <summary>
        /// Gets or sets U_External_Reference, VARCHAR2(2000) (null)
        /// </summary>
        public string U_External_Reference { get; set; }

        /// <summary>
        /// Gets or sets U_Program, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Program { get; set; }

        /// <summary>
        /// Gets or sets U_Charge_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Charge_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Control_Material_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Control_Material_Id { get; set; }

        /// <summary>
        /// Gets or sets U_S9_Config_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_S9_Config_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Speed, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Speed { get; set; }

    }
}
