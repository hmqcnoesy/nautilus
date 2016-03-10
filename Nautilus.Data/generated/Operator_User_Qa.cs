using System;

namespace Nautilus.Data
{
    public partial class Operator_User_Qa : NautilusEntity
    {
        public const string TableName = "Operator_User";

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Employee_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Employee_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Badge_Number, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Badge_Number { get; set; }

        /// <summary>
        /// Gets or sets U_Email_Address, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Email_Address { get; set; }

    }
}
