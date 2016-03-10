using System;

namespace Nautilus.Data
{
    public partial class Aqc_Failure : NautilusEntity
    {
        public const string TableName = "Aqc_Failure";
        public const string PrimaryKey = "Aqc_Failure_Id";
        public const string SequenceName = "Sq_Aqc_Failure";

        /// <summary>
        /// Gets or sets Aqc_Failure_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Failure_Id { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Rule_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Aqc_Rule_Id { get; set; }

        /// <summary>
        /// Gets or sets Failure_Type, VARCHAR2(255) (not null)
        /// </summary>
        public string Failure_Type { get; set; }

        /// <summary>
        /// Gets or sets Comments, VARCHAR2(4000) (null)
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets Aqc_Point_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Point_Id { get; set; }

        /// <summary>
        /// Gets or sets Lims_Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Lims_Session_Id { get; set; }

    }
}
