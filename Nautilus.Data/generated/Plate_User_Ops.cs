using System;

namespace Nautilus.Data
{
    public partial class Plate_User_Ops : NautilusEntity
    {
        public const string TableName = "Plate_User";

        /// <summary>
        /// Gets or sets Plate_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Plate_Id { get; set; }

    }
}
