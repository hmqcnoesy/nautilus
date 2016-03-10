using System;

namespace Nautilus.Data
{
    public partial class Test_Template : NautilusEntity
    {
        public const string TableName = "Test_Template";
        public const string PrimaryKey = "Test_Template_Id";
        public const string SequenceName = "Sq_Test_Template";

        /// <summary>
        /// Gets or sets Test_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Test_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

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
        /// Gets or sets Duration, NUMBER(22) (null)
        /// </summary>
        public decimal? Duration { get; set; }

        /// <summary>
        /// Gets or sets Test_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Test_Type { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Classification, VARCHAR2(255) (null)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets Amount_Used, NUMBER(22) (null)
        /// </summary>
        public decimal? Amount_Used { get; set; }

        /// <summary>
        /// Gets or sets Destructive, CHAR(1) (null)
        /// </summary>
        public string Destructive { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Plan_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Inspection_Plan_Id { get; set; }

        /// <summary>
        /// Gets or sets Rounding_Method, CHAR(1) (null)
        /// </summary>
        public string Rounding_Method { get; set; }

    }
}
