using System;

namespace Nautilus.Data
{
    public partial class U_Wp_Transfer_Data_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Wp_Transfer_Data_User";

        /// <summary>
        /// Gets or sets U_Wp_Transfer_Data_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Wp_Transfer_Data_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Wp_Transfer_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Wp_Transfer_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Specimen_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Specimen_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Specimen_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Specimen_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Result_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Result, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Result { get; set; }

        /// <summary>
        /// Gets or sets U_Summary_Notes, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Summary_Notes { get; set; }

    }
}
