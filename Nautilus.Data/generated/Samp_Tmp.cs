using System;

namespace Nautilus.Data
{
    public partial class Samp_Tmp : NautilusEntity
    {
        public const string TableName = "Samp_Tmp";

        /// <summary>
        /// Gets or sets Sample_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Test_No, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Test_No { get; set; }

    }
}
