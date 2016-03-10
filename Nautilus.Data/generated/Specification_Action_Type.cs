using System;

namespace Nautilus.Data
{
    public partial class Specification_Action_Type : NautilusEntity
    {
        public const string TableName = "Specification_Action_Type";
        public const string PrimaryKey = "Specification_Action_Type_Id";
        public const string SequenceName = "Sq_Specification_Action_Type";

        /// <summary>
        /// Gets or sets Specification_Action_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Specification_Action_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Icon_Filename, VARCHAR2(255) (null)
        /// </summary>
        public string Icon_Filename { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

    }
}
