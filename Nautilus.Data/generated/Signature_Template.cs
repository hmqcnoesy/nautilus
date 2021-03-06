using System;

namespace Nautilus.Data
{
    public partial class Signature_Template : NautilusEntity
    {
        public const string TableName = "Signature_Template";
        public const string PrimaryKey = "Signature_Template_Id";
        public const string SequenceName = "Sq_Signature_Template";

        /// <summary>
        /// Gets or sets Signature_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Signature_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

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
        /// Gets or sets Create_Note, CHAR(1) (null)
        /// </summary>
        public string Create_Note { get; set; }

        /// <summary>
        /// Gets or sets Sql_Syntax, VARCHAR2(4000) (null)
        /// </summary>
        public string Sql_Syntax { get; set; }

        /// <summary>
        /// Gets or sets Syntax_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Syntax_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

    }
}
