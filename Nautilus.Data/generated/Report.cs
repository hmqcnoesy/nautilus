using System;

namespace Nautilus.Data
{
    public partial class Report : NautilusEntity
    {
        public const string TableName = "Report";
        public const string PrimaryKey = "Report_Id";
        public const string SequenceName = "Sq_Report";

        /// <summary>
        /// Gets or sets Report_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Report_Id { get; set; }

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets Report_Datawindow, VARCHAR2(255) (null)
        /// </summary>
        public string Report_Datawindow { get; set; }

        /// <summary>
        /// Gets or sets Report_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Report_Type { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Report_Format, VARCHAR2(255) (null)
        /// </summary>
        public string Report_Format { get; set; }

    }
}
