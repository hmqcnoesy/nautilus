using System;

namespace Nautilus.Data
{
    public partial class Operator_Group : NautilusEntity
    {
        public const string TableName = "Operator_Group";

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Operator_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Operator_Id { get; set; }

        /// <summary>
        /// Gets or sets Access_Level, CHAR(1) (null)
        /// </summary>
        public string Access_Level { get; set; }

    }
}
