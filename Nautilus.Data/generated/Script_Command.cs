using System;

namespace Nautilus.Data
{
    public partial class Script_Command : NautilusEntity
    {
        public const string TableName = "Script_Command";

        /// <summary>
        /// Gets or sets Script_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Script_Id { get; set; }

        /// <summary>
        /// Gets or sets Entry_Number, NUMBER(22) (not null)
        /// </summary>
        public decimal Entry_Number { get; set; }

        /// <summary>
        /// Gets or sets Entry_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Entry_Name { get; set; }

        /// <summary>
        /// Gets or sets Command, VARCHAR2(255) (not null)
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Gets or sets Parameter_1, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_1 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_2, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_2 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_3, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_3 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_4, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_4 { get; set; }

    }
}
