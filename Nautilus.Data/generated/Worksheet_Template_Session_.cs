using System;

namespace Nautilus.Data
{
    public partial class Worksheet_Template_Session_ : NautilusEntity
    {
        public const string TableName = "Worksheet_Template_Session";
        public const string PrimaryKey = "Worksheet_Template_Session_Id";
        public const string SequenceName = "Sq_Worksheet_Template_Session";

        /// <summary>
        /// Gets or sets Worksheet_Template_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Session, NUMBER(22) (not null)
        /// </summary>
        public decimal Worksheet_Template_Session { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Type_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Instrument_Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Instrument_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Prep_Test_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Prep_Test_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Def_Test_Template_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Def_Test_Template_Id { get; set; }

        /// <summary>
        /// Gets or sets Classification, VARCHAR2(255) (null)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets Worksheet_Template_Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Template_Session_Id { get; set; }

    }
}
