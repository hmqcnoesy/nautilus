using System;

namespace Nautilus.Data
{
    public partial class U_Client_Test_Template_Ops : NautilusEntity
    {
        public const string TableName = "U_Client_Test_Template";

        /// <summary>
        /// Gets or sets Client_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Client_Id { get; set; }

        /// <summary>
        /// Gets or sets Test_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Primary_Test, CHAR(1) (null)
        /// </summary>
        public string Primary_Test { get; set; }

    }
}
