using System;

namespace Nautilus.Data
{
    public partial class Aqc_Point : NautilusEntity
    {
        public const string TableName = "Aqc_Point";
        public const string PrimaryKey = "Aqc_Point_Id";
        public const string SequenceName = "Sq_Aqc_Point";

        /// <summary>
        /// Gets or sets Aqc_Point_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Point_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Block_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Block_Id { get; set; }

        /// <summary>
        /// Gets or sets Point_Number, NUMBER(16) (not null)
        /// </summary>
        public decimal Point_Number { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Failure, CHAR(1) (null)
        /// </summary>
        public string Aqc_Failure { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Exclude, CHAR(1) (null)
        /// </summary>
        public string Aqc_Exclude { get; set; }

        /// <summary>
        /// Gets or sets Count, NUMBER(16) (null)
        /// </summary>
        public decimal? Count { get; set; }

        /// <summary>
        /// Gets or sets Min, NUMBER(22) (null)
        /// </summary>
        public decimal? Min { get; set; }

        /// <summary>
        /// Gets or sets Max, NUMBER(22) (null)
        /// </summary>
        public decimal? Max { get; set; }

        /// <summary>
        /// Gets or sets Mean, NUMBER(22) (null)
        /// </summary>
        public decimal? Mean { get; set; }

        /// <summary>
        /// Gets or sets Range, NUMBER(22) (null)
        /// </summary>
        public decimal? Range { get; set; }

        /// <summary>
        /// Gets or sets Comments, VARCHAR2(4000) (null)
        /// </summary>
        public string Comments { get; set; }

    }
}
