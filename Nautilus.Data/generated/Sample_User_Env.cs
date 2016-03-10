using System;

namespace Nautilus.Data
{
    public partial class Sample_User_Env : NautilusEntity
    {
        public const string TableName = "Sample_User";

        /// <summary>
        /// Gets or sets Sample_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Sample_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Project_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Project_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Invoice_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Invoice_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Invoice, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Invoice { get; set; }

    }
}
