using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nautilus.Data
{
    public class Ecms_Part : NautilusEntity
    {
        public const string TableName = "Ecms_Item_Master";

        public string Part_Nbr { get; set; }
        public string Part_Dsc { get; set; }
    }
}
