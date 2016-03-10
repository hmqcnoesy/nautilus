using System;

namespace Nautilus.Data
{
    public partial class Rack_Usage : NautilusEntity
    {
        public const string TableName = "Rack_Usage";
        public const string PrimaryKey = "Rack_Usage_Id";
        public const string SequenceName = "Sq_Rack_Usage";

        /// <summary>
        /// Gets or sets Rack_Usage_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Usage_Id { get; set; }

        /// <summary>
        /// Gets or sets Rack_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Rack_Id { get; set; }

        /// <summary>
        /// Gets or sets Start_Date, DATE (null)
        /// </summary>
        public DateTime? Start_Date { get; set; }

        /// <summary>
        /// Gets or sets End_Date, DATE (null)
        /// </summary>
        public DateTime? End_Date { get; set; }

        /// <summary>
        /// Gets or sets Emptied_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Emptied_By { get; set; }

        /// <summary>
        /// Gets or sets Is_Current, CHAR(1) (null)
        /// </summary>
        public string Is_Current { get; set; }

        /// <summary>
        /// Gets or sets Filled_By, NUMBER(16) (null)
        /// </summary>
        public decimal? Filled_By { get; set; }

        /// <summary>
        /// Gets or sets Sdg_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Sdg_Id { get; set; }

        /// <summary>
        /// Gets or sets Study_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Study_Id { get; set; }

    }
}
