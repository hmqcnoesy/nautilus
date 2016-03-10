using System;

namespace Nautilus.Data
{
    public partial class Worksheet_User_Ops : NautilusEntity
    {
        public const string TableName = "Worksheet_User";

        /// <summary>
        /// Gets or sets Worksheet_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Worksheet_Id { get; set; }

    }
}
