using System;

namespace Nautilus.Data
{
    public partial class U_Control_Material_User_Qa : NautilusEntity
    {
        public const string TableName = "U_Control_Material_User";

        /// <summary>
        /// Gets or sets U_Control_Material_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Control_Material_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Type, VARCHAR2(30) (null)
        /// </summary>
        public string U_Material_Type { get; set; }

        /// <summary>
        /// Gets or sets U_Standard_Control, CHAR(1) (null)
        /// </summary>
        public string U_Standard_Control { get; set; }

        /// <summary>
        /// Gets or sets U_Charge_Code, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Charge_Code { get; set; }

        /// <summary>
        /// Gets or sets U_Program, VARCHAR2(30) (null)
        /// </summary>
        public string U_Program { get; set; }

        /// <summary>
        /// Gets or sets U_Active, CHAR(1) (null)
        /// </summary>
        public string U_Active { get; set; }

    }
}
