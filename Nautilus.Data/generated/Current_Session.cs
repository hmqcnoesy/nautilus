using System;

namespace Nautilus.Data
{
    public partial class Current_Session : NautilusEntity
    {
        public const string TableName = "Current_Session";
        public const string PrimaryKey = "Session_Id";
        public const string SequenceName = "Sq_Current_Session";

        /// <summary>
        /// Gets or sets Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Session_Id { get; set; }

        /// <summary>
        /// Gets or sets Database_Session_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Database_Session_Id { get; set; }

    }
}
