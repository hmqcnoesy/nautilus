using System;

namespace Nautilus.Data
{
    public partial class Address : NautilusEntity
    {
        public const string TableName = "Address";
        public const string PrimaryKey = "Address_Id";
        public const string SequenceName = "Sq_Address";

        /// <summary>
        /// Gets or sets Address_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Address_Id { get; set; }

        /// <summary>
        /// Gets or sets Address_Table_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Address_Table_Name { get; set; }

        /// <summary>
        /// Gets or sets Address_Item_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Address_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Country, VARCHAR2(50) (null)
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Postal_Code, VARCHAR2(20) (null)
        /// </summary>
        public string Postal_Code { get; set; }

        /// <summary>
        /// Gets or sets Phone, VARCHAR2(20) (null)
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets Fax, VARCHAR2(20) (null)
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets Email, VARCHAR2(255) (null)
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Address_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Address_Type { get; set; }

        /// <summary>
        /// Gets or sets Address_Line_1, VARCHAR2(200) (null)
        /// </summary>
        public string Address_Line_1 { get; set; }

        /// <summary>
        /// Gets or sets Address_Line_2, VARCHAR2(50) (null)
        /// </summary>
        public string Address_Line_2 { get; set; }

        /// <summary>
        /// Gets or sets Address_Line_3, VARCHAR2(50) (null)
        /// </summary>
        public string Address_Line_3 { get; set; }

        /// <summary>
        /// Gets or sets Address_Line_4, VARCHAR2(50) (null)
        /// </summary>
        public string Address_Line_4 { get; set; }

        /// <summary>
        /// Gets or sets Address_Line_5, VARCHAR2(50) (null)
        /// </summary>
        public string Address_Line_5 { get; set; }

    }
}
