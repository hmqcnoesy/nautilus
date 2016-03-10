using System;

namespace Nautilus.Data
{
    public partial class Grade_Action : NautilusEntity
    {
        public const string TableName = "Grade_Action";
        public const string PrimaryKey = "Grade_Action_Id";
        public const string SequenceName = "Sq_Grade_Action";

        /// <summary>
        /// Gets or sets Grade_Action_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Grade_Action_Id { get; set; }

        /// <summary>
        /// Gets or sets Grade_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Grade_Id { get; set; }

        /// <summary>
        /// Gets or sets Specification_Action_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Specification_Action_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Parameter, VARCHAR2(4000) (null)
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets Pass, CHAR(1) (null)
        /// </summary>
        public string Pass { get; set; }

    }
}
