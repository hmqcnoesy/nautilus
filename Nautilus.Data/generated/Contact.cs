using System;

namespace Nautilus.Data
{
    public partial class Contact : NautilusEntity
    {
        public const string TableName = "Contact";

        /// <summary>
        /// Gets or sets Address_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Address_Id { get; set; }

        /// <summary>
        /// Gets or sets Contact_Name, VARCHAR2(255) (not null)
        /// </summary>
        public string Contact_Name { get; set; }

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

    }
}
