using System;

namespace Nautilus.Data
{
    public partial class Plate_Plan_User_Ops : NautilusEntity
    {
        public const string TableName = "Plate_Plan_User";

        /// <summary>
        /// Gets or sets Plate_Plan_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Plan_Id { get; set; }

    }
}
