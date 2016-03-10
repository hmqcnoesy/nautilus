using System;

namespace Nautilus.Data
{
    public partial class Workflow_Node_Follower : NautilusEntity
    {
        public const string TableName = "Workflow_Node_Follower";

        /// <summary>
        /// Gets or sets Workflow_Node_Type_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Type_Id { get; set; }

        /// <summary>
        /// Gets or sets Workflow_Node_Follower_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workflow_Node_Follower_Id { get; set; }

        /// <summary>
        /// Gets or sets Order_Number, NUMBER(22) (null)
        /// </summary>
        public decimal? Order_Number { get; set; }

    }
}
