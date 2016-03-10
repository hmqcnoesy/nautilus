using System;

namespace Nautilus.Data
{
    public partial class Stock_Template : NautilusEntity
    {
        public const string TableName = "Stock_Template";
        public const string PrimaryKey = "Stock_Template_Id";
        public const string SequenceName = "Sq_Stock_Template";

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workflow_Id { get; set; }

        /// <summary>
        /// Gets or sets Usage_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Usage_Count { get; set; }

        /// <summary>
        /// Gets or sets Usage_Interval, NUMBER(22) (null)
        /// </summary>
        public decimal? Usage_Interval { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Amount, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets Container_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Container_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Storage, VARCHAR2(4000) (null)
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets Stock_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Chemical_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Aliquot_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Aliquot_Type { get; set; }

        /// <summary>
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

        /// <summary>
        /// Gets or sets Application, VARCHAR2(4000) (null)
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Gets or sets Grade, VARCHAR2(255) (null)
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets Auto_Authorise, CHAR(1) (null)
        /// </summary>
        public string Auto_Authorise { get; set; }

        /// <summary>
        /// Gets or sets Unit_Quantity, VARCHAR2(255) (null)
        /// </summary>
        public string Unit_Quantity { get; set; }

        /// <summary>
        /// Gets or sets Reorder_Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Reorder_Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Reorder_Amount, NUMBER(10) (null)
        /// </summary>
        public decimal? Reorder_Amount { get; set; }

    }
}
