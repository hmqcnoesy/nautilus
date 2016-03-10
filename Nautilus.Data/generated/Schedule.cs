using System;

namespace Nautilus.Data
{
    public partial class Schedule : NautilusEntity
    {
        public const string TableName = "Schedule";
        public const string PrimaryKey = "Schedule_Id";
        public const string SequenceName = "Sq_Schedule";

        /// <summary>
        /// Gets or sets Schedule_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schedule_Id { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Id { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Last_Run_Time, DATE (null)
        /// </summary>
        public DateTime? Last_Run_Time { get; set; }

        /// <summary>
        /// Gets or sets Next_Run_Time, DATE (null)
        /// </summary>
        public DateTime? Next_Run_Time { get; set; }

        /// <summary>
        /// Gets or sets Schedule_Type, CHAR(1) (null)
        /// </summary>
        public string Schedule_Type { get; set; }

        /// <summary>
        /// Gets or sets Minute_Of_Hour, NUMBER(10) (null)
        /// </summary>
        public decimal? Minute_Of_Hour { get; set; }

        /// <summary>
        /// Gets or sets Hour_Of_Day, NUMBER(10) (null)
        /// </summary>
        public decimal? Hour_Of_Day { get; set; }

        /// <summary>
        /// Gets or sets Day_Of_Month, NUMBER(10) (null)
        /// </summary>
        public decimal? Day_Of_Month { get; set; }

        /// <summary>
        /// Gets or sets Week_Days, VARCHAR2(255) (null)
        /// </summary>
        public string Week_Days { get; set; }

        /// <summary>
        /// Gets or sets Run_If_Not_Complete, CHAR(1) (null)
        /// </summary>
        public string Run_If_Not_Complete { get; set; }

        /// <summary>
        /// Gets or sets Parameter, VARCHAR2(4000) (null)
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets Priority, NUMBER(22) (null)
        /// </summary>
        public decimal? Priority { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Active, CHAR(1) (null)
        /// </summary>
        public string Active { get; set; }

        /// <summary>
        /// Gets or sets Background_Task_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Background_Task_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Delete_On_Completion, CHAR(1) (null)
        /// </summary>
        public string Delete_On_Completion { get; set; }

    }
}
