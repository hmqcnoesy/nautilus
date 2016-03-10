using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nautilus.Data
{
    public class OpsInstrument : NautilusEntity
    {
        public const string TableName = "Ops_Instrument";

        public string In_Use { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Input_File_Directory { get; set; }
    }
}
