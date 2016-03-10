using System;

namespace Nautilus.Data
{
    public partial class Config_Operator : NautilusEntity
    {
        public const string TableName = "Config_Operator";

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

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
