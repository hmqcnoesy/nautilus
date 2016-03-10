using System;

namespace Nautilus.Data
{
    public partial class U_Material_Shape_User_Ops : NautilusEntity
    {
        public const string TableName = "U_Material_Shape_User";

        /// <summary>
        /// Gets or sets U_Material_Shape_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal U_Material_Shape_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Default_Workflow, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Default_Workflow { get; set; }

        /// <summary>
        /// Gets or sets U_Volume, NUMBER(22) (null)
        /// </summary>
        public decimal? U_Volume { get; set; }

    }
}
