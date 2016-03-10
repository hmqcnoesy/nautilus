using System;

namespace Nautilus.Data
{
    public partial class Schema_Prompt_Order : NautilusEntity
    {
        public const string TableName = "Schema_Prompt_Order";

        /// <summary>
        /// Gets or sets Schema_Entity_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Schema_Entity_Id { get; set; }

        /// <summary>
        /// Gets or sets Prompt_Order_Number, NUMBER(22) (not null)
        /// </summary>
        public decimal Prompt_Order_Number { get; set; }

        /// <summary>
        /// Gets or sets Schema_Field_Prompt_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Schema_Field_Prompt_Id { get; set; }

    }
}
