using System;

namespace Nautilus.Data
{
    public partial class Aqc_Limit : NautilusEntity
    {
        public const string TableName = "Aqc_Limit";
        public const string PrimaryKey = "Aqc_Limit_Id";
        public const string SequenceName = "Sq_Aqc_Limit";

        /// <summary>
        /// Gets or sets Aqc_Block_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Block_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Limit_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Limit_Id { get; set; }

        /// <summary>
        /// Gets or sets Limit_Number, NUMBER(16) (not null)
        /// </summary>
        public decimal Limit_Number { get; set; }

        /// <summary>
        /// Gets or sets Count, NUMBER(16) (null)
        /// </summary>
        public decimal? Count { get; set; }

        /// <summary>
        /// Gets or sets Sd, NUMBER(22) (null)
        /// </summary>
        public decimal? Sd { get; set; }

        /// <summary>
        /// Gets or sets Mean, NUMBER(22) (null)
        /// </summary>
        public decimal? Mean { get; set; }

        /// <summary>
        /// Gets or sets Lower_Action_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Lower_Action_Limit { get; set; }

        /// <summary>
        /// Gets or sets Upper_Action_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Upper_Action_Limit { get; set; }

        /// <summary>
        /// Gets or sets Lower_Warning_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Lower_Warning_Limit { get; set; }

        /// <summary>
        /// Gets or sets Upper_Warning_Limit, NUMBER(22) (null)
        /// </summary>
        public decimal? Upper_Warning_Limit { get; set; }

    }
}
