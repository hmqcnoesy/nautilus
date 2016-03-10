using System;

namespace Nautilus.Data
{
    public partial class Test_Specification : NautilusEntity
    {
        public const string TableName = "Test_Specification";
        public const string PrimaryKey = "Test_Specification_Id";
        public const string SequenceName = "Sq_Test_Specification";

        /// <summary>
        /// Gets or sets Test_Specification_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Specification_Id { get; set; }

        /// <summary>
        /// Gets or sets Test_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Test_Id { get; set; }

        /// <summary>
        /// Gets or sets Specification_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Specification_Id { get; set; }

    }
}
