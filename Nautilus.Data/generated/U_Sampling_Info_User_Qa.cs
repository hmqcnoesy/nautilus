using System;

namespace Nautilus.Data
{
    public partial class U_Sampling_Info_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Sampling_Info_User";

        /// <summary>
        /// Gets or sets U_Sampling_Info_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Sampling_Info_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Receiver_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Receiver_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Material_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Lab_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Lab_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Revision, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Revision { get; set; }

        /// <summary>
        /// Gets or sets U_Dom, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Dom { get; set; }

        /// <summary>
        /// Gets or sets U_Scn_Cn, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Scn_Cn { get; set; }

        /// <summary>
        /// Gets or sets U_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Pdl_Rev, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Pdl_Rev { get; set; }

        /// <summary>
        /// Gets or sets U_Weight, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Weight { get; set; }

        /// <summary>
        /// Gets or sets U_Sl_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Sl_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Color, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Color { get; set; }

        /// <summary>
        /// Gets or sets U_Po_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Po_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Vendor_Lot, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Vendor_Lot { get; set; }

        /// <summary>
        /// Gets or sets U_Damage, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Damage { get; set; }

        /// <summary>
        /// Gets or sets U_Misc_Notes, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Misc_Notes { get; set; }

        /// <summary>
        /// Gets or sets U_Comments, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comments { get; set; }

        /// <summary>
        /// Gets or sets U_Container_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Container_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Um, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Um { get; set; }

        /// <summary>
        /// Gets or sets U_Sample_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Vendor, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Vendor { get; set; }

        /// <summary>
        /// Gets or sets U_Stores_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Stores_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Needs_Attention, CHAR(1) (null)
        /// </summary>
        public string U_Needs_Attention { get; set; }

    }
}
