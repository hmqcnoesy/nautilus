using System;

namespace Nautilus.Data
{
    public partial class Plate_Template : NautilusEntity
    {
        public const string TableName = "Plate_Template";
        public const string PrimaryKey = "Plate_Template_Id";
        public const string SequenceName = "Sq_Plate_Template";

        /// <summary>
        /// Gets or sets Plate_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Plate_Template_Type, CHAR(1) (null)
        /// </summary>
        public string Plate_Template_Type { get; set; }

        /// <summary>
        /// Gets or sets Status, CHAR(1) (null)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Plate_Width, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Width { get; set; }

        /// <summary>
        /// Gets or sets Plate_Height, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Height { get; set; }

        /// <summary>
        /// Gets or sets Row_Label, CHAR(1) (null)
        /// </summary>
        public string Row_Label { get; set; }

        /// <summary>
        /// Gets or sets Col_Label, CHAR(1) (null)
        /// </summary>
        public string Col_Label { get; set; }

        /// <summary>
        /// Gets or sets Usable_Positions, NUMBER(10) (null)
        /// </summary>
        public decimal? Usable_Positions { get; set; }

        /// <summary>
        /// Gets or sets Load_Order, CHAR(1) (null)
        /// </summary>
        public string Load_Order { get; set; }

        /// <summary>
        /// Gets or sets Uses_Default_Syntax, CHAR(1) (null)
        /// </summary>
        public string Uses_Default_Syntax { get; set; }

    }
}
