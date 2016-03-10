using System;

namespace Nautilus.Data
{
    public partial class U_Evaluation_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Evaluation_User";

        /// <summary>
        /// Gets or sets U_Evaluation_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Evaluation_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Hb_Target, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Hb_Target { get; set; }

        /// <summary>
        /// Gets or sets U_Iron_Oxide_Target, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Iron_Oxide_Target { get; set; }

        /// <summary>
        /// Gets or sets U_Lsbr_Target, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Lsbr_Target { get; set; }

    }
}
