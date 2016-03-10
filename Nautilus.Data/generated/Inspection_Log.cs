using System;

namespace Nautilus.Data
{
    public partial class Inspection_Log : NautilusEntity
    {
        public const string TableName = "Inspection_Log";
        public const string PrimaryKey = "Inspection_Log_Id";
        public const string SequenceName = "Sq_Inspection_Log";

        /// <summary>
        /// Gets or sets Inspection_Log_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Inspection_Log_Id { get; set; }

        /// <summary>
        /// Gets or sets Role_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Role_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Table_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Table_Name { get; set; }

        /// <summary>
        /// Gets or sets Table_Key, NUMBER(16) (null)
        /// </summary>
        public decimal? Table_Key { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Type, CHAR(1) (null)
        /// </summary>
        public string Inspection_Type { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Inspection_Date, DATE (null)
        /// </summary>
        public DateTime? Inspection_Date { get; set; }

    }
}
