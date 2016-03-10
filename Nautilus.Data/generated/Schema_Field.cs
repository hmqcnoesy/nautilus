using System;

namespace Nautilus.Data
{
    public partial class Schema_Field : NautilusEntity
    {
        public const string TableName = "Schema_Field";
        public const string PrimaryKey = "Schema_Field_Id";
        public const string SequenceName = "Sq_Schema_Field";

        /// <summary>
        /// Gets or sets Schema_Field_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Field_Id { get; set; }

        /// <summary>
        /// Gets or sets Schema_Table_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Phrase_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Phrase_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Database_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Database_Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Use_Phrase_Name, CHAR(1) (null)
        /// </summary>
        public string Use_Phrase_Name { get; set; }

        /// <summary>
        /// Gets or sets User_Defined, CHAR(1) (null)
        /// </summary>
        public string User_Defined { get; set; }

        /// <summary>
        /// Gets or sets Datatype, CHAR(1) (null)
        /// </summary>
        public string Datatype { get; set; }

        /// <summary>
        /// Gets or sets Unique_Key, CHAR(1) (null)
        /// </summary>
        public string Unique_Key { get; set; }

        /// <summary>
        /// Gets or sets Lookup_Schema_Table_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Lookup_Schema_Table_Id { get; set; }

        /// <summary>
        /// Gets or sets Master_Table, CHAR(1) (null)
        /// </summary>
        public string Master_Table { get; set; }

        /// <summary>
        /// Gets or sets Read_Only, CHAR(1) (null)
        /// </summary>
        public string Read_Only { get; set; }

        /// <summary>
        /// Gets or sets Data_Length, NUMBER(10) (null)
        /// </summary>
        public decimal? Data_Length { get; set; }

    }
}
