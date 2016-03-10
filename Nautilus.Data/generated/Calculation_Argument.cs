using System;

namespace Nautilus.Data
{
    public partial class Calculation_Argument : NautilusEntity
    {
        public const string TableName = "Calculation_Argument";
        public const string PrimaryKey = "Calculation_Argument_Id";
        public const string SequenceName = "Sq_Calculation_Argument";

        /// <summary>
        /// Gets or sets Calculation_Argument_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Calculation_Argument_Id { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Calculation_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Calculation_Value_Type, CHAR(1) (null)
        /// </summary>
        public string Calculation_Value_Type { get; set; }

    }
}
