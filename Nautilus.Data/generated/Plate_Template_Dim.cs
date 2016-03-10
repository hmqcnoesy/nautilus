using System;

namespace Nautilus.Data
{
    public partial class Plate_Template_Dim : NautilusEntity
    {
        public const string TableName = "Plate_Template_Dim";

        /// <summary>
        /// Gets or sets Plate_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Level, NUMBER(10) (not null)
        /// </summary>
        public decimal Plate_Level { get; set; }

        /// <summary>
        /// Gets or sets Level_Width, NUMBER(10) (null)
        /// </summary>
        public decimal? Level_Width { get; set; }

        /// <summary>
        /// Gets or sets Level_Height, NUMBER(10) (null)
        /// </summary>
        public decimal? Level_Height { get; set; }

    }
}
