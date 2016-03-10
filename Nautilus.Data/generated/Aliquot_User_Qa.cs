using System;

namespace Nautilus.Data
{
    public partial class Aliquot_User_Qa : NautilusEntity
    {
        public const string TableName = "Aliquot_User";

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Mix_Grind_Lwr, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Mix_Grind_Lwr { get; set; }

        /// <summary>
        /// Gets or sets U_Bare_Metal_Panel_Serial, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Bare_Metal_Panel_Serial { get; set; }

        /// <summary>
        /// Gets or sets U_Adcar_Transfer, CHAR(1) (null)
        /// </summary>
        public string U_Adcar_Transfer { get; set; }

        /// <summary>
        /// Gets or sets U_Trace_Transfer, CHAR(1) (null)
        /// </summary>
        public string U_Trace_Transfer { get; set; }

        /// <summary>
        /// Gets or sets U_Wp_Transfer, CHAR(1) (null)
        /// </summary>
        public string U_Wp_Transfer { get; set; }

        /// <summary>
        /// Gets or sets U_Unauthorization, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Unauthorization { get; set; }

        /// <summary>
        /// Gets or sets U_Te_Comp_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Te_Comp_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Broadgood_Lot_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Broadgood_Lot_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Sqc_Reviewer_Notified, CHAR(1) (null)
        /// </summary>
        public string U_Sqc_Reviewer_Notified { get; set; }

        /// <summary>
        /// Gets or sets U_Family, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Family { get; set; }

        /// <summary>
        /// Gets or sets U_Particle_Size, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Particle_Size { get; set; }

        /// <summary>
        /// Gets or sets U_Ahops, VARCHAR2(30) (null)
        /// </summary>
        public string U_Ahops { get; set; }

    }
}
