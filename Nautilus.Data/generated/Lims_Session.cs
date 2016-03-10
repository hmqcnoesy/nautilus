using System;

namespace Nautilus.Data
{
    public partial class Lims_Session : NautilusEntity
    {
        public const string TableName = "Lims_Session";
        public const string PrimaryKey = "Session_Id";
        public const string SequenceName = "Sq_Lims_Session";

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Logged_On, DATE (null)
        /// </summary>
        public DateTime? Logged_On { get; set; }

        /// <summary>
        /// Gets or sets Logged_Off, DATE (null)
        /// </summary>
        public DateTime? Logged_Off { get; set; }

        /// <summary>
        /// Gets or sets Client_Version, VARCHAR2(255) (null)
        /// </summary>
        public string Client_Version { get; set; }

        /// <summary>
        /// Gets or sets Server_Version, VARCHAR2(255) (null)
        /// </summary>
        public string Server_Version { get; set; }

        /// <summary>
        /// Gets or sets Computer_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Computer_Name { get; set; }

        /// <summary>
        /// Gets or sets Terminal_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Terminal_Name { get; set; }

        /// <summary>
        /// Gets or sets Os_User_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Os_User_Name { get; set; }

        /// <summary>
        /// Gets or sets Parent_Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Submit_Session_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Submit_Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Session_Type, CHAR(1) (null)
        /// </summary>
        public string Session_Type { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Id { get; set; }

    }
}
