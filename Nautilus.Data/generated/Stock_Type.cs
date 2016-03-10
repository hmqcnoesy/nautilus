using System;

namespace Nautilus.Data
{
    public partial class Stock_Type : NautilusEntity
    {
        public const string TableName = "Stock_Type";
        public const string PrimaryKey = "Stock_Type_Id";
        public const string SequenceName = "Sq_Stock_Type";

        /// <summary>
        /// Gets or sets Stock_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stock_Type_Id { get; set; }

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
        /// Gets or sets Add_To_Menu, CHAR(1) (null)
        /// </summary>
        public string Add_To_Menu { get; set; }

        /// <summary>
        /// Gets or sets Is_Bought_In, CHAR(1) (null)
        /// </summary>
        public string Is_Bought_In { get; set; }

        /// <summary>
        /// Gets or sets Has_Formulation, CHAR(1) (null)
        /// </summary>
        public string Has_Formulation { get; set; }

        /// <summary>
        /// Gets or sets Has_Analytes, CHAR(1) (null)
        /// </summary>
        public string Has_Analytes { get; set; }

        /// <summary>
        /// Gets or sets Is_Chemical, CHAR(1) (null)
        /// </summary>
        public string Is_Chemical { get; set; }

    }
}
