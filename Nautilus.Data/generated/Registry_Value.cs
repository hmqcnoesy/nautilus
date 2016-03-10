using System;

namespace Nautilus.Data
{
    public partial class Registry_Value : NautilusEntity
    {
        public const string TableName = "Registry_Value";

        /// <summary>
        /// Gets or sets Registry_Key_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Registry_Key_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Data, CHAR(10) (null)
        /// </summary>
        public string Data { get; set; }

    }
}
