using System;

namespace Nautilus.Data
{
    public partial class Calculation_Node_Type : NautilusEntity
    {
        public const string TableName = "Calculation_Node_Type";
        public const string PrimaryKey = "Calculation_Node_Type_Id";
        public const string SequenceName = "Sq_Calculation_Node_Type";

        /// <summary>
        /// Gets or sets Calculation_Node_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calculation_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Calculation_Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Object_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Prompt_Object_Name { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

    }
}
