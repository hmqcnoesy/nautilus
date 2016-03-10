using System;

namespace Nautilus.Data
{
    public partial class U_Location_Info_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Location_Info_User";

        /// <summary>
        /// Gets or sets U_Location_Info_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Location_Info_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Map, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Map { get; set; }

        /// <summary>
        /// Gets or sets U_Location, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Height, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Height { get; set; }

        /// <summary>
        /// Gets or sets U_Width, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Width { get; set; }

        /// <summary>
        /// Gets or sets U_Top, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Top { get; set; }

        /// <summary>
        /// Gets or sets U_Left, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Left { get; set; }

    }
}
