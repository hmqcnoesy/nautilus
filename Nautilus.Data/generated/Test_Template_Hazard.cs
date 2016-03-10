using System;

namespace Nautilus.Data
{
    public partial class Test_Template_Hazard : NautilusEntity
    {
        public const string TableName = "Test_Template_Hazard";

        /// <summary>
        /// Gets or sets Hazard_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Hazard_Id { get; set; }

        /// <summary>
        /// Gets or sets Test_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Hazard_Usage, CHAR(1) (not null)
        /// </summary>
        public string Hazard_Usage { get; set; }

    }
}
