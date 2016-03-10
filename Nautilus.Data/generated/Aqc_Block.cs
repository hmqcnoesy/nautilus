using System;

namespace Nautilus.Data
{
    public partial class Aqc_Block : NautilusEntity
    {
        public const string TableName = "Aqc_Block";
        public const string PrimaryKey = "Aqc_Block_Id";
        public const string SequenceName = "Sq_Aqc_Block";

        /// <summary>
        /// Gets or sets Aqc_Chart_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Chart_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Block_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Block_Id { get; set; }

        /// <summary>
        /// Gets or sets Block_Number, NUMBER(16) (not null)
        /// </summary>
        public decimal Block_Number { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

    }
}
