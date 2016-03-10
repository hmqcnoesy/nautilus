using System;

namespace Nautilus.Data
{
    public partial class Pbcatvld : NautilusEntity
    {
        public const string TableName = "Pbcatvld";

        /// <summary>
        /// Gets or sets Pbv_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Pbv_Name { get; set; }

        /// <summary>
        /// Gets or sets Pbv_Vald, VARCHAR2(254) (null)
        /// </summary>
        public string Pbv_Vald { get; set; }

        /// <summary>
        /// Gets or sets Pbv_Type, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbv_Type { get; set; }

        /// <summary>
        /// Gets or sets Pbv_Cntr, NUMBER(22) (null)
        /// </summary>
        public decimal? Pbv_Cntr { get; set; }

        /// <summary>
        /// Gets or sets Pbv_Msg, VARCHAR2(254) (null)
        /// </summary>
        public string Pbv_Msg { get; set; }

    }
}
