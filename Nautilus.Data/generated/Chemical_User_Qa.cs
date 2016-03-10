using System;

namespace Nautilus.Data
{
    public partial class Chemical_User_Qa : NautilusEntity
    {
        public const string TableName = "Chemical_User";

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Chemical_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Target_Organs, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Target_Organs { get; set; }

        /// <summary>
        /// Gets or sets U_Physical_Hazards, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Physical_Hazards { get; set; }

        /// <summary>
        /// Gets or sets U_Hazard_Label_Form_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Hazard_Label_Form_Id { get; set; }

    }
}
