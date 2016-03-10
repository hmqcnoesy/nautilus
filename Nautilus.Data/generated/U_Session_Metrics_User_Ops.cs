using System;

namespace Nautilus.Data
{
    public partial class U_Session_Metrics_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Session_Metrics_User";

        /// <summary>
        /// Gets or sets U_Session_Metrics_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Session_Metrics_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Timestamp, DATE (null)
        /// </summary>
        public DateTime? U_Timestamp { get; set; }

        /// <summary>
        /// Gets or sets U_Env_Count, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Env_Count { get; set; }

        /// <summary>
        /// Gets or sets U_Ops_Count, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Ops_Count { get; set; }

        /// <summary>
        /// Gets or sets U_Qa_Count, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Qa_Count { get; set; }

    }
}
