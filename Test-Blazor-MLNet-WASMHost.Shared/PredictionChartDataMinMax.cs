using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorMLNetWASMHost.Shared
{
    public class PredictionChartDataMinMax
    {
        public string Algorithm { get; set; }

        public double Min { get; set; }

        public double Max { get; set; }

        public int SeasonPlayed { get; set; }
    }
}
