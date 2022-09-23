﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorMLNetWASMHost.Shared
{
    public class PredictionData
    {
        public List<PredictionChartData> ChartData { get; set; }

        public List<PredictionChartDataMinMax> ChartDataMinMax { get; set; }

        public List<MLBBaseballBatterSeasonPrediction> MLBBaseballBatterSeasonPredictions {get; set;}
    }
 }
