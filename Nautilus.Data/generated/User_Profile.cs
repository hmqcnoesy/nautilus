using System;

namespace Nautilus.Data
{
    public partial class User_Profile : NautilusEntity
    {
        public const string TableName = "User_Profile";
        public const string PrimaryKey = "Profile_Id";
        public const string SequenceName = "Sq_User_Profile";

        /// <summary>
        /// Gets or sets Profile_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Profile_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Database_Name, VARCHAR2(30) (null)
        /// </summary>
        public string Database_Name { get; set; }

        /// <summary>
        /// Gets or sets Sessions_Per_User, NUMBER(10) (null)
        /// </summary>
        public decimal? Sessions_Per_User { get; set; }

    }
}
