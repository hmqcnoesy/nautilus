using System;

namespace Nautilus.Data
{
    public partial class Parsing_Command : NautilusEntity
    {
        public const string TableName = "Parsing_Command";
        public const string PrimaryKey = "Parsing_Command_Id";
        public const string SequenceName = "Sq_Parsing_Command";

        /// <summary>
        /// Gets or sets Parsing_Command_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Parsing_Command_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (not null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Command_Name, VARCHAR2(255) (not null)
        /// </summary>
        public string Command_Name { get; set; }

        /// <summary>
        /// Gets or sets Command_Type, CHAR(1) (null)
        /// </summary>
        public string Command_Type { get; set; }

        /// <summary>
        /// Gets or sets Has_Parameter_1, CHAR(1) (null)
        /// </summary>
        public string Has_Parameter_1 { get; set; }

        /// <summary>
        /// Gets or sets Has_Parameter_2, CHAR(1) (null)
        /// </summary>
        public string Has_Parameter_2 { get; set; }

        /// <summary>
        /// Gets or sets Has_Parameter_3, CHAR(1) (null)
        /// </summary>
        public string Has_Parameter_3 { get; set; }

        /// <summary>
        /// Gets or sets Has_Parameter_4, CHAR(1) (null)
        /// </summary>
        public string Has_Parameter_4 { get; set; }

    }
}
