using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class DevelopmentLevels
    {

        public DevelopmentLevels(string lowestGroundLevel,
                                 string lowestRoadLevel,
                                 string lowesterFloorLevel,
                                 string quoteForInvestigation
                                )
            {
                LowestGroundLevel = lowestGroundLevel;
                LowestRoadLevel = lowestRoadLevel;
                LowesterFloorLevel = lowesterFloorLevel;
                QuoteForInvestigation = quoteForInvestigation;
            }

        public DevelopmentLevels()
            {

            }

            public string LowestGroundLevel { get; set; }
            public string LowestRoadLevel { get; set; }
            public string LowesterFloorLevel { get; set; }
            public string QuoteForInvestigation { get; set; }
        }
    
}
