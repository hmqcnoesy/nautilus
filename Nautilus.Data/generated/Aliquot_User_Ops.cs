using System;

namespace Nautilus.Data
{
    public partial class Aliquot_User_Ops : NautilusEntity
    {
        public const string TableName = "Aliquot_User";

        /// <summary>
        /// Gets or sets Aliquot_Id, NUMBER(16) (not null)
        /// </summary>
        public decimal Aliquot_Id { get; set; }

        /// <summary>
        /// Gets or sets U_Ref_Sample, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Ref_Sample { get; set; }

        /// <summary>
        /// Gets or sets U_Material_Shape, NUMBER(16) (null)
        /// </summary>
        public decimal? U_Material_Shape { get; set; }

        /// <summary>
        /// Gets or sets U_Material, VARCHAR2(2000) (null)
        /// </summary>
        public string U_Material { get; set; }

        /// <summary>
        /// Gets or sets U_Machine, VARCHAR2(30) (null)
        /// </summary>
        public string U_Machine { get; set; }

        /// <summary>
        /// Gets or sets U_Mcc_Transfer, CHAR(1) (null)
        /// </summary>
        public string U_Mcc_Transfer { get; set; }

    }
}
