using System;

namespace Nautilus.Data
{
    public partial class Calendar_Event : NautilusEntity
    {
        public const string TableName = "Calendar_Event";
        public const string PrimaryKey = "Calendar_Event_Id";
        public const string SequenceName = "Sq_Calendar_Event";

        /// <summary>
        /// Gets or sets Calendar_Event_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calendar_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Next_Calendar_Event_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Next_Calendar_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Prev_Calendar_Event_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Prev_Calendar_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Event_Date, DATE (null)
        /// </summary>
        public DateTime? Event_Date { get; set; }

        /// <summary>
        /// Gets or sets Calendar_Event_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Calendar_Event_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets First_Calendar_Event_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? First_Calendar_Event_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

    }
}
