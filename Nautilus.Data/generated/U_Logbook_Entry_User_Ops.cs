using System;

namespace Nautilus.Data
{
    public partial class U_Logbook_Entry_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Logbook_Entry_User";

        /// <summary>
        /// Gets or sets U_Logbook_Entry_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Logbook_Entry_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Analyst, VARCHAR2(30) (null)
        /// </summary>
        public string U_Analyst { get; set; }

        /// <summary>
        /// Gets or sets U_Created_On, DATE (null)
        /// </summary>
        public DateTime? U_Created_On { get; set; }

        /// <summary>
        /// Gets or sets U_Sdg_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Sdg_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Instrument, VARCHAR2(30) (null)
        /// </summary>
        public string U_Instrument { get; set; }

        /// <summary>
        /// Gets or sets U_Entry_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Entry_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Action_Status, VARCHAR2(30) (null)
        /// </summary>
        public string U_Action_Status { get; set; }

        /// <summary>
        /// Gets or sets U_Action_Assigned_To, VARCHAR2(30) (null)
        /// </summary>
        public string U_Action_Assigned_To { get; set; }

    }
}
