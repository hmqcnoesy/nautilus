using System;

namespace Nautilus.Data
{
    public partial class Config_Role : NautilusEntity
    {
        public const string TableName = "Config_Role";

        /// <summary>
        /// Gets or sets Role_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Role_Id { get; set; }

        /// <summary>
        /// Gets or sets Config_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Config_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Config_Value, VARCHAR2(255) (null)
        /// </summary>
        public string Config_Value { get; set; }

    }
}
