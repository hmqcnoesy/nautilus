using System;

namespace Nautilus.Data
{
    public partial class Workstation : NautilusEntity
    {
        public const string TableName = "Workstation";
        public const string PrimaryKey = "Workstation_Id";
        public const string SequenceName = "Sq_Workstation";

        /// <summary>
        /// Gets or sets Workstation_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Workstation_Id { get; set; }

        /// <summary>
        /// Gets or sets Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Name, VARCHAR2(255) (null)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Version, VARCHAR2(10) (null)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Description, VARCHAR2(4000) (null)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Version_Status, CHAR(1) (null)
        /// </summary>
        public string Version_Status { get; set; }

        /// <summary>
        /// Gets or sets Computer_Name, VARCHAR2(255) (null)
        /// </summary>
        public string Computer_Name { get; set; }

        /// <summary>
        /// Gets or sets Serial_Number, VARCHAR2(255) (null)
        /// </summary>
        public string Serial_Number { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Type, VARCHAR2(255) (null)
        /// </summary>
        public string Workstation_Type { get; set; }

        /// <summary>
        /// Gets or sets Allow_User_Login, CHAR(1) (null)
        /// </summary>
        public string Allow_User_Login { get; set; }

        /// <summary>
        /// Gets or sets Allow_Background, CHAR(1) (null)
        /// </summary>
        public string Allow_Background { get; set; }

        /// <summary>
        /// Gets or sets Allow_Instruments, CHAR(1) (null)
        /// </summary>
        public string Allow_Instruments { get; set; }

        /// <summary>
        /// Gets or sets Location_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Location_Id { get; set; }

        /// <summary>
        /// Gets or sets Workstation_Group_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Workstation_Group_Id { get; set; }

        /// <summary>
        /// Gets or sets Parent_Version_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Parent_Version_Id { get; set; }

        /// <summary>
        /// Gets or sets Destination_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets Auto_Exit, CHAR(1) (null)
        /// </summary>
        public string Auto_Exit { get; set; }

        /// <summary>
        /// Gets or sets Inactivity_Timer, NUMBER(10) (null)
        /// </summary>
        public decimal? Inactivity_Timer { get; set; }

        /// <summary>
        /// Gets or sets Max_Retries, NUMBER(10) (null)
        /// </summary>
        public decimal? Max_Retries { get; set; }

        /// <summary>
        /// Gets or sets Security_Server, VARCHAR2(255) (null)
        /// </summary>
        public string Security_Server { get; set; }

        /// <summary>
        /// Gets or sets Background_Instruments, CHAR(1) (null)
        /// </summary>
        public string Background_Instruments { get; set; }

        /// <summary>
        /// Gets or sets Freeze_On_Lockout, CHAR(1) (null)
        /// </summary>
        public string Freeze_On_Lockout { get; set; }

        /// <summary>
        /// Gets or sets Naming_Context, VARCHAR2(255) (null)
        /// </summary>
        public string Naming_Context { get; set; }

        /// <summary>
        /// Gets or sets Auto_Operator, CHAR(1) (null)
        /// </summary>
        public string Auto_Operator { get; set; }

        /// <summary>
        /// Gets or sets Default_Operator_Id, NUMBER(16) (null)
        /// </summary>
        public decimal? Default_Operator_Id { get; set; }

    }
}
