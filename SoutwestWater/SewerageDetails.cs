using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class SewerageDetails
    {

        public SewerageDetails(string preDevWasteWaterDesign,
                               string preCombinedPartCombinedQuantity,
                               string preDevPeakDischarge,
                               string preDevAverageDischarge,
                               string postDevWasteWaterDesign,
                               string postCombinedPartCombinedQuantity,
                               string postDevPeakDischarge,
                               string postDevAverageDischarge
                               )
            {
                PreDevWasteWaterDesign = preDevWasteWaterDesign;
                PreCombinedPartCombinedQuantity = preCombinedPartCombinedQuantity;
                PreDevPeakDischarge = preDevPeakDischarge;
                PreDevAverageDischarge = preDevAverageDischarge;
                PostDevWasteWaterDesign = postDevWasteWaterDesign;
                PostCombinedPartCombinedQuantity = postCombinedPartCombinedQuantity;
                PostDevPeakDischarge = postDevPeakDischarge;
                PostDevAverageDischarge = postDevAverageDischarge;
            }

        public SewerageDetails()
            {

            }

        public string PreDevWasteWaterDesign { get; set; }
        public string PreCombinedPartCombinedQuantity { get; set; }
        public string PreDevPeakDischarge { get; set; }
        public string PreDevAverageDischarge { get; set; }
        public string PostDevWasteWaterDesign { get; set; }
        public string PostCombinedPartCombinedQuantity { get; set; }
        public string PostDevPeakDischarge { get; set; }
        public string PostDevAverageDischarge { get; set; }
        }
    
}
