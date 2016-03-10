using System;

namespace Nautilus.Data
{
    public partial class Xml_Transaction : NautilusEntity
    {
        public const string TableName = "Xml_Transaction";
        public const string PrimaryKey = "Xml_Transaction_Id";
        public const string SequenceName = "Sq_Xml_Transaction";

        /// <summary>
        /// Gets or sets Xml_Transaction_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Xml_Transaction_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Session_Id, VARCHAR2(255) (not null)
        /// </summary>
        public string Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Created_On, DATE (null)
        /// </summary>
        public DateTime? Created_On { get; set; }

        /// <summary>
        /// Gets or sets Processed_On, DATE (null)
        /// </summary>
        public DateTime? Processed_On { get; set; }

        /// <summary>
        /// Gets or sets Transaction_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Transaction_Type { get; set; }

        /// <summary>
        /// Gets or sets Transaction_Status, CHAR(1) (null)
        /// </summary>
        public string Transaction_Status { get; set; }

        /// <summary>
        /// Gets or sets Errors, VARCHAR2(4000) (null)
        /// </summary>
        public string Errors { get; set; }

        /// <summary>
        /// Gets or sets Xml_Request, CLOB(4000) (null)
        /// </summary>
        public string Xml_Request { get; set; }

        /// <summary>
        /// Gets or sets Xml_Response, CLOB(4000) (null)
        /// </summary>
        public string Xml_Response { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets External_Reference, VARCHAR2(255) (null)
        /// </summary>
        public string External_Reference { get; set; }

    }
}
