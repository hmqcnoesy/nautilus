using System;

namespace Nautilus.Data
{
    public partial class U_Material_Info_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Material_Info_User";

        /// <summary>
        /// Gets or sets U_Material_Info_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Material_Info_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Commercial, CHAR(1) (null)
        /// </summary>
        public string U_Commercial { get; set; }

        /// <summary>
        /// Gets or sets U_Burn_Profile, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Burn_Profile { get; set; }

    }
}
