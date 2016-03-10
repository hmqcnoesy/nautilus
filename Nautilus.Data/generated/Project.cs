using System;

namespace Nautilus.Data
{
    public partial class Project : NautilusEntity
    {
        public const string TableName = "Project";
        public const string PrimaryKey = "Project_Id";
        public const string SequenceName = "Sq_Project";

        /// <summary>
        /// Gets or sets Project_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Project_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Active, CHAR(1) (null)
        /// </summary>
        public string Active { get; set; }

        /// <summary>
        /// Gets or sets Project_Status, VARCHAR2(255) (null)
        /// </summary>
        public string Project_Status { get; set; }

        /// <summary>
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

    }
}
