using System;

namespace Nautilus.Data
{
    public partial class U_Sampling_Container_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Sampling_Container_User";

        /// <summary>
        /// Gets or sets U_Sampling_Container_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Sampling_Container_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Sampling_Info_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Sampling_Info_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Container_Description, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Container_Description { get; set; }

        /// <summary>
        /// Gets or sets U_Qty, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Qty { get; set; }

        /// <summary>
        /// Gets or sets U_Location, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Location { get; set; }

    }
}
