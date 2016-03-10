using System;

namespace Nautilus.Data
{
    public partial class U_Software_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Software_User";

        /// <summary>
        /// Gets or sets U_Software_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Software_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Used_In_Areas, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Used_In_Areas { get; set; }

        /// <summary>
        /// Gets or sets U_New_Software, CHAR(1) (null)
        /// </summary>
        public string U_New_Software { get; set; }

        /// <summary>
        /// Gets or sets U_Change_Notice, CHAR(1) (null)
        /// </summary>
        public string U_Change_Notice { get; set; }

        /// <summary>
        /// Gets or sets U_File_Name, VARCHAR2(2000) (null)
        /// </summary>
        public string U_File_Name { get; set; }

        /// <summary>
        /// Gets or sets U_Type, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Requested_By, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Requested_By { get; set; }

        /// <summary>
        /// Gets or sets U_Requesting_Organization, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Requesting_Organization { get; set; }

        /// <summary>
        /// Gets or sets U_Requested_On, DATE (null)
        /// </summary>
        public DateTime? U_Requested_On { get; set; }

        /// <summary>
        /// Gets or sets U_Programmer, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Programmer { get; set; }

        /// <summary>
        /// Gets or sets U_Programming_Organization, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Programming_Organization { get; set; }

        /// <summary>
        /// Gets or sets U_Estimated_Completion, DATE (null)
        /// </summary>
        public DateTime? U_Estimated_Completion { get; set; }

        /// <summary>
        /// Gets or sets U_Change_Description, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Change_Description { get; set; }

        /// <summary>
        /// Gets or sets U_Change_Justification, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Change_Justification { get; set; }

        /// <summary>
        /// Gets or sets U_Proposed_Testing, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Proposed_Testing { get; set; }

        /// <summary>
        /// Gets or sets U_Testing_Results, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Testing_Results { get; set; }

        /// <summary>
        /// Gets or sets U_Tested_By, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Tested_By { get; set; }

        /// <summary>
        /// Gets or sets U_Tested_On, DATE (null)
        /// </summary>
        public DateTime? U_Tested_On { get; set; }

        /// <summary>
        /// Gets or sets U_Programmer_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Programmer_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Programmer_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_Programmer_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_User_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_User_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_User_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_User_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_Reviewer_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Reviewer_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Reviewer_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_Reviewer_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_Qe_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Qe_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Qe_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_Qe_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_Supervisor_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Supervisor_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Supervisor_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_Supervisor_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_Safety_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Safety_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Safety_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_Safety_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_Crb_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Crb_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Crb_Signed_On, DATE (null)
        /// </summary>
        public DateTime? U_Crb_Signed_On { get; set; }

        /// <summary>
        /// Gets or sets U_Ocr_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ocr_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Backup_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Backup_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Documentation_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Documentation_Location { get; set; }

        /// <summary>
        /// Gets or sets U_Gatekeeper_Signed_By, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Gatekeeper_Signed_By { get; set; }

        /// <summary>
        /// Gets or sets U_Revision, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Revision { get; set; }

        /// <summary>
        /// Gets or sets U_Released_On, DATE (null)
        /// </summary>
        public DateTime? U_Released_On { get; set; }

        /// <summary>
        /// Gets or sets U_Active, CHAR(1) (null)
        /// </summary>
        public string U_Active { get; set; }

    }
}
