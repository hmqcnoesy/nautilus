using System;

namespace Nautilus.Data
{
    public partial class Cherrypick_Template : NautilusEntity
    {
        public const string TableName = "Cherrypick_Template";
        public const string PrimaryKey = "Cherrypick_Template_Id";
        public const string SequenceName = "Sq_Cherrypick_Template";

        /// <summary>
        /// Gets or sets Cherrypick_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cherrypick_Template_Id { get; set; }

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
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Hit_Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Hit_Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Hit, CHAR(1) (null)
        /// </summary>
        public string Prompt_Hit { get; set; }

        /// <summary>
        /// Gets or sets Current_Plate, CHAR(1) (null)
        /// </summary>
        public string Current_Plate { get; set; }

        /// <summary>
        /// Gets or sets Lookup_Where, VARCHAR2(4000) (null)
        /// </summary>
        public string Lookup_Where { get; set; }

        /// <summary>
        /// Gets or sets Lookup_Level, NUMBER(10) (null)
        /// </summary>
        public decimal? Lookup_Level { get; set; }

        /// <summary>
        /// Gets or sets Ignore_Multiple_Hits, CHAR(1) (null)
        /// </summary>
        public string Ignore_Multiple_Hits { get; set; }

        /// <summary>
        /// Gets or sets Destination_Wrk_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Destination_Wrk_Id { get; set; }

        /// <summary>
        /// Gets or sets Destination_Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Destination_Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Destination_Prompt, CHAR(1) (null)
        /// </summary>
        public string Destination_Prompt { get; set; }

        /// <summary>
        /// Gets or sets Create_Always, CHAR(1) (null)
        /// </summary>
        public string Create_Always { get; set; }

    }
}
