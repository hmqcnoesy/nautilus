using System;

namespace Nautilus.Data
{
    public partial class Schema_Entity : NautilusEntity
    {
        public const string TableName = "Schema_Entity";
        public const string PrimaryKey = "Schema_Entity_Id";
        public const string SequenceName = "Sq_Schema_Entity";

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Datastore_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Datastore_Object { get; set; }

        /// <summary>
        /// Gets or sets Interface_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Interface_Object { get; set; }

        /// <summary>
        /// Gets or sets Default_Selected_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Default_Selected_Icon { get; set; }

        /// <summary>
        /// Gets or sets Default_Unselected_Icon, VARCHAR2(255) (null)
        /// </summary>
        public string Default_Unselected_Icon { get; set; }

        /// <summary>
        /// Gets or sets Security_Item_Prefix, VARCHAR2(4000) (null)
        /// </summary>
        public string Security_Item_Prefix { get; set; }

        /// <summary>
        /// Gets or sets Default_Text_Colour, NUMBER(10) (null)
        /// </summary>
        public decimal? Default_Text_Colour { get; set; }

        /// <summary>
        /// Gets or sets Schema_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets User_Defined, CHAR(1) (null)
        /// </summary>
        public string User_Defined { get; set; }

        /// <summary>
        /// Gets or sets Name_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Name_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Colour_Index_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Colour_Index_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Icon_Index_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Icon_Index_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Infotip_Index_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Infotip_Index_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Field_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Order_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Order_Ascending, CHAR(1) (null)
        /// </summary>
        public string Order_Ascending { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Signature_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Signature_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Collection_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Collection_Object { get; set; }

        /// <summary>
        /// Gets or sets Entity_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Entity_Object { get; set; }

        /// <summary>
        /// Gets or sets Factory_Object, VARCHAR2(255) (null)
        /// </summary>
        public string Factory_Object { get; set; }

        /// <summary>
        /// Gets or sets Active_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Active_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Template_Entity, VARCHAR2(255) (null)
        /// </summary>
        public string Template_Entity { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Entity, VARCHAR2(255) (null)
        /// </summary>
        public string Workflow_Entity { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Entity, VARCHAR2(255) (null)
        /// </summary>
        public string Syntax_Entity { get; set; }

        /// <summary>
        /// Gets or sets Apply_Template, CHAR(1) (null)
        /// </summary>
        public string Apply_Template { get; set; }

    }
}
