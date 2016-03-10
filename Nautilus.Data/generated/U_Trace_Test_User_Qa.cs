using System;

namespace Nautilus.Data
{
    public partial class U_Trace_Test_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Trace_Test_User";

        /// <summary>
        /// Gets or sets U_Trace_Test_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Trace_Test_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Trace_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Trace_Code { get; set; }

    }
}
