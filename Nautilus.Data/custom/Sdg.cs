using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Data
{
    public partial class Sdg
    {
        public Sdg()
        {
            Samples = new List<Sample>();
        }


        public IEnumerable<Sample> Samples { get; set; }
    }
}
