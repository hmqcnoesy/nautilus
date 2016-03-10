using System;

namespace Nautilus.Data
{
    public partial class Worksheet : NautilusEntity
    {
        public const string TableName = "Worksheet";
        public const string PrimaryKey = "Worksheet_Id";
        public const string SequenceName = "Sq_Worksheet";

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Status, CHAR(1) (null)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Session_Number, NUMBER(10) (null)
        /// </summary>
        public decimal? Session_Number { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Aliquot_Count { get; set; }

        /// <summary>
        /// Gets or sets Aliquot_Number, NUMBER(10) (null)
        /// </summary>
        public decimal? Aliquot_Number { get; set; }

        /// <summary>
        /// Gets or sets Priority, NUMBER(22) (null)
        /// </summary>
        public decimal? Priority { get; set; }

        /// <summary>
        /// Gets or sets Date_Results_Required, DATE (null)
        /// </summary>
        public DateTime? Date_Results_Required { get; set; }

        /// <summary>
        /// Gets or sets Conclusion, VARCHAR2(255) (null)
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// Gets or sets Acquired_Count, NUMBER(10) (null)
        /// </summary>
        public decimal? Acquired_Count { get; set; }

        /// <summary>
        /// Gets or sets Created_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Created_By { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Worksheet_Type { get; set; }

        /// <summary>
        /// Gets or sets Def_Test_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Def_Test_Template_Id { get; set; }

    }
}
