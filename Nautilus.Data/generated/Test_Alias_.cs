using System;

namespace Nautilus.Data
{
    public partial class Test_Alias_ : NautilusEntity
    {
        public const string TableName = "Test_Alias";

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Id { get; set; }

        /// <summary>
        /// Gets or sets Test_Alias, VARCHAR2(255) (not null)
        /// </summary>
        public string Test_Alias { get; set; }

        /// <summary>
        /// Gets or sets Test_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Test_Template_Id { get; set; }

    }
}
