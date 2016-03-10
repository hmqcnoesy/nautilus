using System;

namespace Nautilus.Data
{
    public partial class Sample : NautilusEntity
    {
        public const string TableName = "Sample";
        public const string PrimaryKey = "Sample_Id";
        public const string SequenceName = "Sq_Sample";

        /// <summary>
        /// Gets or sets Sample_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets Priority, NUMBER(22) (null)
        /// </summary>
        public decimal? Priority { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Product_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Product_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Sdg_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Sdg_Id { get; set; }

        /// <summary>
        /// Gets or sets Previous_Sample, NUMBER(16) (null)
        /// </summary>
        public decimal? Previous_Sample { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Client_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Client_Id { get; set; }

        /// <summary>
        /// Gets or sets Sampled_On, DATE (null)
        /// </summary>
        public DateTime? Sampled_On { get; set; }

        /// <summary>
        /// Gets or sets Sampled_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Sampled_By { get; set; }

        /// <summary>
        /// Gets or sets Date_Results_Required, DATE (null)
        /// </summary>
        public DateTime? Date_Results_Required { get; set; }

        /// <summary>
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

        /// <summary>
        /// Gets or sets Conclusion, VARCHAR2(255) (null)
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// Gets or sets Expected_On, DATE (null)
        /// </summary>
        public DateTime? Expected_On { get; set; }

        /// <summary>
        /// Gets or sets Sample_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Sample_Type { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Inspection_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Sample_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Sample_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Id { get; set; }

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
        /// Gets or sets Blind_Sample, CHAR(1) (null)
        /// </summary>
        public string Blind_Sample { get; set; }

        /// <summary>
        /// Gets or sets Needs_Review, CHAR(1) (null)
        /// </summary>
        public string Needs_Review { get; set; }

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
        /// Gets or sets Study_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Study_Id { get; set; }

        /// <summary>
        /// Gets or sets Cofa_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Cofa_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Review_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Review_Template_Id { get; set; }

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
        /// Gets or sets Archived_Child_Complete, CHAR(1) (null)
        /// </summary>
        public string Archived_Child_Complete { get; set; }

    }
}
