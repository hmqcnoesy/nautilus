using System;

namespace Nautilus.Data
{
    public partial class Result_User_Qa : NautilusEntity
    {
        public const string TableName = "Result_User";

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Bacchusanalyst, VARCHAR2(30) (null)
        /// </summary>
        public string U_Bacchusanalyst { get; set; }

        /// <summary>
        /// Gets or sets U_Comments, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Comments { get; set; }

        /// <summary>
        /// Gets or sets U_Specimen_Id, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Specimen_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Specimen_Dimension, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Specimen_Dimension { get; set; }

        /// <summary>
        /// Gets or sets U_Specimen_Max, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Specimen_Max { get; set; }

        /// <summary>
        /// Gets or sets U_Failure_Mode, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Failure_Mode { get; set; }

        /// <summary>
        /// Gets or sets U_Specimen_Failure_Mode, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Specimen_Failure_Mode { get; set; }

        /// <summary>
        /// Gets or sets U_Needs_Spec_Check, CHAR(1) (null)
        /// </summary>
        public string U_Needs_Spec_Check { get; set; }

        /// <summary>
        /// Gets or sets U_Spec_Violation, CHAR(1) (null)
        /// </summary>
        public string U_Spec_Violation { get; set; }

        /// <summary>
        /// Gets or sets U_Checked_On, DATE (null)
        /// </summary>
        public DateTime? U_Checked_On { get; set; }

        /// <summary>
        /// Gets or sets U_Unauthorization, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Unauthorization { get; set; }

        /// <summary>
        /// Gets or sets U_External_Reference, VARCHAR2(2000) (null)
        /// </summary>
        public string U_External_Reference { get; set; }

    }
}
