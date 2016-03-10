using System;

namespace Nautilus.Data
{
    public partial class Background_Task_Type : NautilusEntity
    {
        public const string TableName = "Background_Task_Type";
        public const string PrimaryKey = "Background_Task_Type_Id";
        public const string SequenceName = "Sq_Background_Task_Type";

        /// <summary>
        /// Gets or sets Background_Task_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Background_Task_Type_Id { get; set; }

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

        /// <summary>
        /// Gets or sets Background_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Background_Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Can_Schedule, CHAR(1) (null)
        /// </summary>
        public string Can_Schedule { get; set; }

    }
}
