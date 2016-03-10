using System;

namespace Nautilus.Data
{
    public partial class Instrument_File : NautilusEntity
    {
        public const string TableName = "Instrument_File";
        public const string PrimaryKey = "Instrument_File_Id";
        public const string SequenceName = "Sq_Instrument_File";

        /// <summary>
        /// Gets or sets Instrument_File_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Instrument_File_Id { get; set; }

        /// <summary>
        /// Gets or sets Details, LONG RAW(0) (null)
        /// </summary>
        public byte[] Details { get; set; }

        /// <summary>
        /// Gets or sets Instrument_File_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Instrument_File_Name { get; set; }

        /// <summary>
        /// Gets or sets Original_File_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Original_File_Name { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Operator_Name { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Unit_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Unit_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Unit_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Instrument_Unit_Name { get; set; }

        /// <summary>
        /// Gets or sets File_Date, DATE (null)
        /// </summary>
        public DateTime? File_Date { get; set; }

    }
}
