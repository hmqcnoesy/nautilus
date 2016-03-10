using System;

namespace Nautilus.Data
{
    public partial class U_Map_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Map_User";

        /// <summary>
        /// Gets or sets U_Map_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Map_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Path, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Path { get; set; }

        /// <summary>
        /// Gets or sets U_Number_Rooms, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Number_Rooms { get; set; }

    }
}
