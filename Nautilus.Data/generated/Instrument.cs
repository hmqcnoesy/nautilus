using System;

namespace Nautilus.Data
{
    public partial class Instrument : NautilusEntity
    {
        public const string TableName = "Instrument";
        public const string PrimaryKey = "Instrument_Id";
        public const string SequenceName = "Sq_Instrument";

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Is_Part, CHAR(1) (null)
        /// </summary>
        public string Is_Part { get; set; }

        /// <summary>
        /// Gets or sets Requires_Approval, CHAR(1) (null)
        /// </summary>
        public string Requires_Approval { get; set; }

        /// <summary>
        /// Gets or sets In_Use, CHAR(1) (null)
        /// </summary>
        public string In_Use { get; set; }

        /// <summary>
        /// Gets or sets Out_Of_Service, CHAR(1) (null)
        /// </summary>
        public string Out_Of_Service { get; set; }

        /// <summary>
        /// Gets or sets Out_Of_Calibration, CHAR(1) (null)
        /// </summary>
        public string Out_Of_Calibration { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Control_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Control_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Serial_Number, VARCHAR2(255) (null)
        /// </summary>
        public string Serial_Number { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Service_Interval, NUMBER(22) (null)
        /// </summary>
        public decimal? Service_Interval { get; set; }

        /// <summary>
        /// Gets or sets Calibration_Interval, NUMBER(22) (null)
        /// </summary>
        public decimal? Calibration_Interval { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

    }
}
