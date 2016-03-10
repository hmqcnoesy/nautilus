using System;

namespace Nautilus.Data
{
    public partial class Rack_Type : NautilusEntity
    {
        public const string TableName = "Rack_Type";
        public const string PrimaryKey = "Rack_Type_Id";
        public const string SequenceName = "Sq_Rack_Type";

        /// <summary>
        /// Gets or sets Rack_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Rack_Width, NUMBER(10) (null)
        /// </summary>
        public decimal? Rack_Width { get; set; }

        /// <summary>
        /// Gets or sets Rack_Height, NUMBER(10) (null)
        /// </summary>
        public decimal? Rack_Height { get; set; }

        /// <summary>
        /// Gets or sets Load_Order, CHAR(1) (null)
        /// </summary>
        public string Load_Order { get; set; }

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
        /// Gets or sets Enable_Usage_Tracking, CHAR(1) (null)
        /// </summary>
        public string Enable_Usage_Tracking { get; set; }

        /// <summary>
        /// Gets or sets New_Usage_On_Empty, CHAR(1) (null)
        /// </summary>
        public string New_Usage_On_Empty { get; set; }

        /// <summary>
        /// Gets or sets New_Usage_On_Addition, CHAR(1) (null)
        /// </summary>
        public string New_Usage_On_Addition { get; set; }

        /// <summary>
        /// Gets or sets New_Usage_On_Removal, CHAR(1) (null)
        /// </summary>
        public string New_Usage_On_Removal { get; set; }

        /// <summary>
        /// Gets or sets New_Usage_On_User, CHAR(1) (null)
        /// </summary>
        public string New_Usage_On_User { get; set; }

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
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Add_To_Menu, CHAR(1) (null)
        /// </summary>
        public string Add_To_Menu { get; set; }

    }
}
