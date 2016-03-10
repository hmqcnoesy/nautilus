using System;

namespace Nautilus.Data
{
    public partial class U_Wp_Transfer_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Wp_Transfer_User";

        /// <summary>
        /// Gets or sets U_Wp_Transfer_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Wp_Transfer_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Aliquot_Name, VARCHAR2(200) (null)
        /// </summary>
        public string U_Aliquot_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Comp_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comp_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Comp_Sn, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comp_Sn { get; set; }

        /// <summary>
        /// Gets or sets U_Witness_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Witness_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Witness_Sn, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Witness_Sn { get; set; }

        /// <summary>
        /// Gets or sets U_Seg_Alias, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Seg_Alias { get; set; }

        /// <summary>
        /// Gets or sets U_Lwr, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Lwr { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Date, DATE (null)
        /// </summary>
        public DateTime? U_Test_Date { get; set; }

        /// <summary>
        /// Gets or sets U_Building, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Building { get; set; }

        /// <summary>
        /// Gets or sets U_Wo, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Wo { get; set; }

        /// <summary>
        /// Gets or sets U_Operator, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Operator { get; set; }

        /// <summary>
        /// Gets or sets U_Instrument, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Instrument { get; set; }

        /// <summary>
        /// Gets or sets U_Humidity, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Humidity { get; set; }

        /// <summary>
        /// Gets or sets U_Temperature, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Temperature { get; set; }

        /// <summary>
        /// Gets or sets U_Test_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Test_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Summary_Notes, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Summary_Notes { get; set; }

        /// <summary>
        /// Gets or sets U_Result_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Result, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result { get; set; }

        /// <summary>
        /// Gets or sets U_Email_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Email_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Transfer_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Transfer_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Crosshead_Speed, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Crosshead_Speed { get; set; }

        /// <summary>
        /// Gets or sets U_Raw_Data_File_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Raw_Data_File_Location { get; set; }

    }
}
