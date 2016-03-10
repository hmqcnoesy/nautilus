using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Data
{
    public partial class Sample
    {
        public Sample()
        {
            Aliquots = new List<Aliquot>();
        }


        public IEnumerable<Aliquot> Aliquots { get; set; }

        public List<Result> GetResultsProgeny()
        {
            var progeny = new List<Result>();
            foreach(var aliquot in this.Aliquots)
            {
                foreach(var test in aliquot.Tests)
                {
                    foreach(var result in test.Results)
                    {
                        progeny.Add(result);
                    }
                }
            }

            return progeny;
        }
    }
}
