using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class WaterDetails
    {

        public WaterDetails(string preDevPeak,
                                 string preDevAverage,
                                 string postDevPeak,
                                 string postDevAverage,
                                 string highestWaterFitting
                                )
            {
                PreDevPeak = preDevPeak;
                PreDevAverage = preDevAverage;
                PostDevPeak = postDevPeak;
                PostDevAverage = postDevAverage;
                HighestWaterFitting = highestWaterFitting;
            }

        public WaterDetails()
            {

            }

        public string PreDevPeak { get; set; }
        public string PreDevAverage { get; set; }
        public string PostDevPeak { get; set; }
        public string PostDevAverage { get; set; }
        public string HighestWaterFitting { get; set; }
        }
    
}
