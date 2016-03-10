using System;

namespace Nautilus.Data
{
    public partial class Cherrypick_Link : NautilusEntity
    {
        public const string TableName = "Cherrypick_Link";
        public const string PrimaryKey = "Cherrypick_Link_Id";
        public const string SequenceName = "Sq_Cherrypick_Link";

        /// <summary>
        /// Gets or sets Cherrypick_Link_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cherrypick_Link_Id { get; set; }

        /// <summary>
        /// Gets or sets Cherrypick_Parent_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cherrypick_Parent_Id { get; set; }

        /// <summary>
        /// Gets or sets Cherrypick_Child_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Cherrypick_Child_Id { get; set; }

    }
}
