using System;

namespace Nautilus.Data
{
    public partial class Calendar_Day : NautilusEntity
    {
        public const string TableName = "Calendar_Day";
        public const string PrimaryKey = "Calendar_Day_Id";
        public const string SequenceName = "Sq_Calendar_Day";

        /// <summary>
        /// Gets or sets Calendar_Day_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calendar_Day_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Is_Holiday, CHAR(1) (null)
        /// </summary>
        public string Is_Holiday { get; set; }

        /// <summary>
        /// Gets or sets Calendar_Date, DATE (null)
        /// </summary>
        public DateTime? Calendar_Date { get; set; }

    }
}
