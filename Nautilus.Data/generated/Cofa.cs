using System;

namespace Nautilus.Data
{
    public partial class Cofa : NautilusEntity
    {
        public const string TableName = "Cofa";
        public const string PrimaryKey = "Cofa_Id";
        public const string SequenceName = "Sq_Cofa";

        /// <summary>
        /// Gets or sets Cofa_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cofa_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Cofa_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Cofa_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Cofa_Date, DATE (null)
        /// </summary>
        public DateTime? Cofa_Date { get; set; }

        /// <summary>
        /// Gets or sets Pin_Checked, CHAR(1) (null)
        /// </summary>
        public string Pin_Checked { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

    }
}
