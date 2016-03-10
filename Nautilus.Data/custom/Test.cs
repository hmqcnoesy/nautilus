using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Data
{
    public partial class Test
    {
        public Test()
        {
            Results = new List<Result>();
        }


        public IEnumerable<Result> Results { get; set; }
    }
}
