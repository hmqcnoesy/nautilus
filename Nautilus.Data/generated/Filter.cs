using System;

namespace Nautilus.Data
{
    public partial class Filter : NautilusEntity
    {
        public const string TableName = "Filter";
        public const string PrimaryKey = "Filter_Id";
        public const string SequenceName = "Sq_Filter";

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Where_Statement, VARCHAR2(4000) (null)
        /// </summary>
        public string Where_Statement { get; set; }

        /// <summary>
        /// Gets or sets Schema_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets User_Defined, CHAR(1) (null)
        /// </summary>
        public string User_Defined { get; set; }

        /// <summary>
        /// Gets or sets Use_In_Search_Window, CHAR(1) (null)
        /// </summary>
        public string Use_In_Search_Window { get; set; }

    }
}
