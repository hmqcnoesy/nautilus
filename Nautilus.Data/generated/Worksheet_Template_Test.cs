using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Template_Test : NautilusEntity
    {
        public const string TableName = "Worksheet_Template_Test";

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Test_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Template_Id { get; set; }

    }
}
