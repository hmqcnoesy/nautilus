using System;

namespace Nautilus.Data
{
    public partial class U_Burn_Profile_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Burn_Profile_User";

        /// <summary>
        /// Gets or sets U_Burn_Profile_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Burn_Profile_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Date_Approved, DATE (null)
        /// </summary>
        public DateTime? U_Date_Approved { get; set; }

        /// <summary>
        /// Gets or sets U_Dot_Classification, VARCHAR2(30) (null)
        /// </summary>
        public string U_Dot_Classification { get; set; }

        /// <summary>
        /// Gets or sets U_Reactive_Waste_Category, VARCHAR2(30) (null)
        /// </summary>
        public string U_Reactive_Waste_Category { get; set; }

        /// <summary>
        /// Gets or sets U_Hyperlink, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Hyperlink { get; set; }

    }
}
