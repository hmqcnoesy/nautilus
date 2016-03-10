using System;

namespace Nautilus.Data
{
    public partial class Background_Log : NautilusEntity
    {
        public const string TableName = "Background_Log";
        public const string PrimaryKey = "Background_Log_Id";
        public const string SequenceName = "Sq_Background_Log";

        /// <summary>
        /// Gets or sets Background_Log_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Background_Log_Id { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Start_Time, DATE (null)
        /// </summary>
        public DateTime? Start_Time { get; set; }

        /// <summary>
        /// Gets or sets End_Time, DATE (null)
        /// </summary>
        public DateTime? End_Time { get; set; }

        /// <summary>
        /// Gets or sets Parameter, VARCHAR2(4000) (null)
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets Completed_Successfully, CHAR(1) (null)
        /// </summary>
        public string Completed_Successfully { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Schedule_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schedule_Id { get; set; }

        /// <summary>
        /// Gets or sets Background_Task_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Background_Task_Type_Id { get; set; }

    }
}
