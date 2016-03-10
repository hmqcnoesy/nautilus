using System;

namespace Nautilus.Data
{
    public partial class Destination : NautilusEntity
    {
        public const string TableName = "Destination";
        public const string PrimaryKey = "Destination_Id";
        public const string SequenceName = "Sq_Destination";

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets Destination_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Destination_Type { get; set; }

        /// <summary>
        /// Gets or sets Info_Text1, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text1 { get; set; }

        /// <summary>
        /// Gets or sets Info_Text2, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text2 { get; set; }

        /// <summary>
        /// Gets or sets Prompt_For_Destination, CHAR(1) (null)
        /// </summary>
        public string Prompt_For_Destination { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Info_Text3, VARCHAR2(4000) (null)
        /// </summary>
        public string Info_Text3 { get; set; }

        /// <summary>
        /// Gets or sets Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Object_Name { get; set; }

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
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Extension_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Number_Of_Copies, NUMBER(10) (null)
        /// </summary>
        public decimal? Number_Of_Copies { get; set; }

    }
}
