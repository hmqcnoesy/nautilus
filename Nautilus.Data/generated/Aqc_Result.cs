using System;

namespace Nautilus.Data
{
    public partial class Aqc_Result : NautilusEntity
    {
        public const string TableName = "Aqc_Result";

        /// <summary>
        /// Gets or sets Aqc_Point_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aqc_Point_Id { get; set; }

        /// <summary>
        /// Gets or sets Result_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Result_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Entry_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Entry_Id { get; set; }

    }
}
