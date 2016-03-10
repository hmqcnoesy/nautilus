using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Data
{
    public partial class Aliquot
    {
        public Aliquot()
        {
            Tests = new List<Test>();
        }


        public IEnumerable<Test> Tests { get; set; }
    }
}
