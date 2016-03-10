using System;

namespace Nautilus.Data
{
    public partial class Workflow_Node_Type : NautilusEntity
    {
        public const string TableName = "Workflow_Node_Type";
        public const string PrimaryKey = "Workflow_Node_Type_Id";
        public const string SequenceName = "Sq_Workflow_Node_Type";

        /// <summary>
        /// Gets or sets Workflow_Node_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Object_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Object_Type { get; set; }

        /// <summary>
        /// Gets or sets Object_Property_Sheet, VARCHAR2(255) (null)
        /// </summary>
        public string Object_Property_Sheet { get; set; }

        /// <summary>
        /// Gets or sets Picture_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Picture_Icon { get; set; }

        /// <summary>
        /// Gets or sets Usage, VARCHAR2(255) (null)
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Argument_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Calculation_Argument_Object { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

    }
}
