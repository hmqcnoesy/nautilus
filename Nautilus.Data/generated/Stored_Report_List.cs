using System;

namespace Nautilus.Data
{
    public partial class Stored_Report_List : NautilusEntity
    {
        public const string TableName = "Stored_Report_List";

        /// <summary>
        /// Gets or sets Stored_Report_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Stored_Report_Id { get; set; }

        /// <summary>
        /// Gets or sets Reported_Item_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Reported_Item_Id { get; set; }

        /// <summary>
        /// Gets or sets Reported_Table_Name, VARCHAR2(30) (not null)
        /// </summary>
        public string Reported_Table_Name { get; set; }

    }
}
