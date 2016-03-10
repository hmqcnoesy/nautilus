using System;

namespace Nautilus.Data
{
    public partial class Instrument_Parameters : NautilusEntity
    {
        public const string TableName = "Instrument_Parameters";
        public const string PrimaryKey = "Instrument_Control_Id";
        public const string SequenceName = "Sq_Instrument_Parameters";

        /// <summary>
        /// Gets or sets Instrument_Control_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Control_Id { get; set; }

        /// <summary>
        /// Gets or sets Threshold, NUMBER(22) (null)
        /// </summary>
        public decimal? Threshold { get; set; }

        /// <summary>
        /// Gets or sets Tolerance, NUMBER(22) (null)
        /// </summary>
        public decimal? Tolerance { get; set; }

        /// <summary>
        /// Gets or sets Number_Of_Values, NUMBER(10) (null)
        /// </summary>
        public decimal? Number_Of_Values { get; set; }

        /// <summary>
        /// Gets or sets Time_Interval, NUMBER(22) (null)
        /// </summary>
        public decimal? Time_Interval { get; set; }

        /// <summary>
        /// Gets or sets Reported_Value, VARCHAR2(255) (null)
        /// </summary>
        public string Reported_Value { get; set; }

    }
}
