using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nautilus.Extensions.Qa.MicrotracResults
{
    public class MicrotracResult
    {
        public string AliquotName { get; set; }
        public string ResultName { get; set; }
        public string DbTag1 { get; set; }
        public string DbTag2 { get; set; }
        public string DbTag3 { get; set; }
        public string Note { get; set; }
        public string[] Percentiles { get; set; }
        public string[] PercentileValues { get; set; }
        public string MeanVolume { get; set; }

        public MicrotracResult()
        {
            // each value indicates the particle size in microns where that corresponding percentage of total particles is equal size or smaller
            Percentiles = new string[10];
            PercentileValues = new string[10];
        }
    }
}
