using System;

namespace Nautilus.Data
{
    public partial class Operator : NautilusEntity
    {
        public const string TableName = "Operator";
        public const string PrimaryKey = "Operator_Id";
        public const string SequenceName = "Sq_Operator";

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Role_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Role_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Allow_Login, CHAR(1) (null)
        /// </summary>
        public string Allow_Login { get; set; }

        /// <summary>
        /// Gets or sets Job_Title, VARCHAR2(255) (null)
        /// </summary>
        public string Job_Title { get; set; }

        /// <summary>
        /// Gets or sets Qualifications, VARCHAR2(4000) (null)
        /// </summary>
        public string Qualifications { get; set; }

        /// <summary>
        /// Gets or sets Database_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Database_Id { get; set; }

        /// <summary>
        /// Gets or sets Database_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Database_Name { get; set; }

        /// <summary>
        /// Gets or sets Full_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Full_Name { get; set; }

        /// <summary>
        /// Gets or sets Profile_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Profile_Id { get; set; }

    }
}
