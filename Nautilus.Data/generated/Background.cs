using System;

namespace Nautilus.Data
{
    public partial class Background : NautilusEntity
    {
        public const string TableName = "Background";
        public const string PrimaryKey = "Background_Id";
        public const string SequenceName = "Sq_Background";

        /// <summary>
        /// Gets or sets Background_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Background_Id { get; set; }

        /// <summary>
        /// Gets or sets Priority, NUMBER(22) (null)
        /// </summary>
        public decimal? Priority { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Schedule_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schedule_Id { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Id { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Parameter, VARCHAR2(4000) (null)
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets Active, CHAR(1) (null)
        /// </summary>
        public string Active { get; set; }

        /// <summary>
        /// Gets or sets Background_Task_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Background_Task_Type_Id { get; set; }

    }
}
