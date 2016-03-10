using System;

namespace Nautilus.Data
{
    public partial class Specification_Grade : NautilusEntity
    {
        public const string TableName = "Specification_Grade";
        public const string PrimaryKey = "Specification_Grade_Id";
        public const string SequenceName = "Sq_Specification_Grade";

        /// <summary>
        /// Gets or sets Specification_Grade_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Specification_Grade_Id { get; set; }

        /// <summary>
        /// Gets or sets Specification_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Specification_Id { get; set; }

        /// <summary>
        /// Gets or sets Grade_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Grade_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

    }
}
