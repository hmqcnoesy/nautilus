using System;

namespace Nautilus.Data
{
    public partial class Aliquot : NautilusEntity
    {
        public const string TableName = "Aliquot";
        public const string PrimaryKey = "Aliquot_Id";
        public const string SequenceName = "Sq_Aliquot";

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets Sample_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Priority, NUMBER(22) (null)
        /// </summary>
        public decimal? Priority { get; set; }

        /// <summary>
        /// Gets or sets Matrix_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Matrix_Type { get; set; }

        /// <summary>
        /// Gets or sets Conclusion, VARCHAR2(255) (null)
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// Gets or sets Condition, VARCHAR2(255) (null)
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets Amount, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets Date_Results_Required, DATE (null)
        /// </summary>
        public DateTime? Date_Results_Required { get; set; }

        /// <summary>
        /// Gets or sets Expected_On, DATE (null)
        /// </summary>
        public DateTime? Expected_On { get; set; }

        /// <summary>
        /// Gets or sets Expires_On, DATE (null)
        /// </summary>
        public DateTime? Expires_On { get; set; }

        /// <summary>
        /// Gets or sets Container_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Container_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Aliquot_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Id { get; set; }

        /// <summary>
        /// Gets or sets Usage_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Usage_Count { get; set; }

        /// <summary>
        /// Gets or sets Stock_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Status, CHAR(1) (null)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Old_Status, VARCHAR2(255) (null)
        /// </summary>
        public string Old_Status { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Completed_On, DATE (null)
        /// </summary>
        public DateTime? Completed_On { get; set; }

        /// <summary>
        /// Gets or sets Authorised_On, DATE (null)
        /// </summary>
        public DateTime? Authorised_On { get; set; }

        /// <summary>
        /// Gets or sets Events, VARCHAR2(4000) (null)
        /// </summary>
        public string Events { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Needs_Review, CHAR(1) (null)
        /// </summary>
        public string Needs_Review { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Inspection_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Received_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Received_By { get; set; }

        /// <summary>
        /// Gets or sets Received_On, DATE (null)
        /// </summary>
        public DateTime? Received_On { get; set; }

        /// <summary>
        /// Gets or sets Reported, CHAR(1) (null)
        /// </summary>
        public string Reported { get; set; }

        /// <summary>
        /// Gets or sets Has_Notes, CHAR(1) (null)
        /// </summary>
        public string Has_Notes { get; set; }

        /// <summary>
        /// Gets or sets Has_Audits, CHAR(1) (null)
        /// </summary>
        public string Has_Audits { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Aliquot_Type { get; set; }

        /// <summary>
        /// Gets or sets Storage, VARCHAR2(4000) (null)
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

        /// <summary>
        /// Gets or sets Created_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Created_By { get; set; }

        /// <summary>
        /// Gets or sets Completed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Completed_By { get; set; }

        /// <summary>
        /// Gets or sets Authorised_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Authorised_By { get; set; }

        /// <summary>
        /// Gets or sets Supplier_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Supplier_Id { get; set; }

        /// <summary>
        /// Gets or sets Chemical_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Chemical_Id { get; set; }

        /// <summary>
        /// Gets or sets Stock_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Stock_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Grade, VARCHAR2(255) (null)
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets Batch_Number, VARCHAR2(255) (null)
        /// </summary>
        public string Batch_Number { get; set; }

        /// <summary>
        /// Gets or sets Purity, NUMBER(22) (null)
        /// </summary>
        public decimal? Purity { get; set; }

        /// <summary>
        /// Gets or sets Plate_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Plate_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Order, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Order { get; set; }

        /// <summary>
        /// Gets or sets Plate_Row, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Row { get; set; }

        /// <summary>
        /// Gets or sets Plate_Column, NUMBER(10) (null)
        /// </summary>
        public decimal? Plate_Column { get; set; }

        /// <summary>
        /// Gets or sets Plate_Aliquot_Type, NUMBER(16) (null)
        /// </summary>
        public decimal? Plate_Aliquot_Type { get; set; }

        /// <summary>
        /// Gets or sets Archived_Child_Complete, CHAR(1) (null)
        /// </summary>
        public string Archived_Child_Complete { get; set; }

        /// <summary>
        /// Gets or sets Plate_Editor_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Plate_Editor_Id { get; set; }

    }
}
