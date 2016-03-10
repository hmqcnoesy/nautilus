using System;

namespace Nautilus.Data
{
    public partial class Folder : NautilusEntity
    {
        public const string TableName = "Folder";
        public const string PrimaryKey = "Folder_Id";
        public const string SequenceName = "Sq_Folder";

        /// <summary>
        /// Gets or sets Folder_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Folder_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Access_Level, CHAR(1) (null)
        /// </summary>
        public string Operator_Access_Level { get; set; }

        /// <summary>
        /// Gets or sets Group_Access_Level, CHAR(1) (null)
        /// </summary>
        public string Group_Access_Level { get; set; }

        /// <summary>
        /// Gets or sets Standard_Access_Level, CHAR(1) (null)
        /// </summary>
        public string Standard_Access_Level { get; set; }

        /// <summary>
        /// Gets or sets Filter_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Filter_Id { get; set; }

        /// <summary>
        /// Gets or sets Report_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Report_Id { get; set; }

        /// <summary>
        /// Gets or sets Allow_Create, CHAR(1) (null)
        /// </summary>
        public string Allow_Create { get; set; }

        /// <summary>
        /// Gets or sets Refresh_Time, NUMBER(10) (null)
        /// </summary>
        public decimal? Refresh_Time { get; set; }

        /// <summary>
        /// Gets or sets Inherit_Filter, CHAR(1) (null)
        /// </summary>
        public string Inherit_Filter { get; set; }

        /// <summary>
        /// Gets or sets Explorer_Extension_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Explorer_Extension_Id { get; set; }

        /// <summary>
        /// Gets or sets Allow_Detail_Extensions, CHAR(1) (null)
        /// </summary>
        public string Allow_Detail_Extensions { get; set; }

    }
}
