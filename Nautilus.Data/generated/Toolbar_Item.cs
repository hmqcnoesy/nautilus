using System;

namespace Nautilus.Data
{
    public partial class Toolbar_Item : NautilusEntity
    {
        public const string TableName = "Toolbar_Item";

        /// <summary>
        /// Gets or sets Toolbar_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Toolbar_Id { get; set; }

        /// <summary>
        /// Gets or sets Toolbar_Order, NUMBER(22) (not null)
        /// </summary>
        public decimal Toolbar_Order { get; set; }

        /// <summary>
        /// Gets or sets Command_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Command_Id { get; set; }

        /// <summary>
        /// Gets or sets Separator_Flag, CHAR(1) (null)
        /// </summary>
        public string Separator_Flag { get; set; }

        /// <summary>
        /// Gets or sets Enabled, CHAR(1) (null)
        /// </summary>
        public string Enabled { get; set; }

    }
}
