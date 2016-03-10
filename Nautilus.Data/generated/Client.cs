using System;

namespace Nautilus.Data
{
    public partial class Client : NautilusEntity
    {
        public const string TableName = "Client";
        public const string PrimaryKey = "Client_Id";
        public const string SequenceName = "Sq_Client";

        /// <summary>
        /// Gets or sets Client_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Client_Id { get; set; }

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
        /// Gets or sets Bad_Debt, CHAR(1) (null)
        /// </summary>
        public string Bad_Debt { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Client_Discount, FLOAT(126) (null)
        /// </summary>
        public double? Client_Discount { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Client_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Client_Type { get; set; }

        /// <summary>
        /// Gets or sets Client_Code, VARCHAR2(255) (null)
        /// </summary>
        public string Client_Code { get; set; }

    }
}
