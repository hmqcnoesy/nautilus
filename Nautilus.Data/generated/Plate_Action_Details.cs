using System;

namespace Nautilus.Data
{
    public partial class Plate_Action_Details : NautilusEntity
    {
        public const string TableName = "Plate_Action_Details";

        /// <summary>
        /// Gets or sets Plate_Action_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Action_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Id { get; set; }

        /// <summary>
        /// Gets or sets Plate_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Plate_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Parameter_1, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_1 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_2, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_2 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_3, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_3 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_4, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_4 { get; set; }

        /// <summary>
        /// Gets or sets Parameter_5, VARCHAR2(255) (null)
        /// </summary>
        public string Parameter_5 { get; set; }

    }
}
