using System;

namespace Nautilus.Data
{
    public partial class Calendar_Event_Type : NautilusEntity
    {
        public const string TableName = "Calendar_Event_Type";
        public const string PrimaryKey = "Calendar_Event_Type_Id";
        public const string SequenceName = "Sq_Calendar_Event_Type";

        /// <summary>
        /// Gets or sets Calendar_Event_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calendar_Event_Type_Id { get; set; }

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
        /// Gets or sets Prompt_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Object_Name { get; set; }

    }
}
