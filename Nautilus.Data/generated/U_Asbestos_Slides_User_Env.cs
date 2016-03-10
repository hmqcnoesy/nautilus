using System;

namespace Nautilus.Data
{
    public partial class U_Asbestos_Slides_User_Env : NautilusEntity
    {
        public const string TableName = "U_Asbestos_Slides_User";

        /// <summary>
        /// Gets or sets U_Asbestos_Slides_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Asbestos_Slides_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Number { get; set; }

    }
}
