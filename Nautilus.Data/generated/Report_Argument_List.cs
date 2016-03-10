using System;

namespace Nautilus.Data
{
    public partial class Report_Argument_List : NautilusEntity
    {
        public const string TableName = "Report_Argument_List";

        /// <summary>
        /// Gets or sets Report_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Report_Id { get; set; }

        /// <summary>
        /// Gets or sets Argument_Order, NUMBER(22) (not null)
        /// </summary>
        public decimal Argument_Order { get; set; }

        /// <summary>
        /// Gets or sets Report_Argument_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Report_Argument_Id { get; set; }

    }
}
