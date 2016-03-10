using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nautilus.Extensions.Qa.MicrotracResults
{
    public class DBaseRegEntry
    {
        public string Name { get; set; }
        public string Directory { get; set; }
        public string SlNumbers { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
