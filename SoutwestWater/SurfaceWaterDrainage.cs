using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class SurfaceWaterDrainage
    {

        public SurfaceWaterDrainage(string preDevSurfaceWaterDischarge,
                               string currentSWDischarge,
                               string directToWaterCourse,
                               string rainWater,
                               string other,
                               string postDevPreAttSW,
                               string postDevAttSW,
                               string proposedDischargeSW,
                               string selectedDirect,
                               string selectedRainWater,
                               string relevantInfo,
                               string oOther,
                               string plans
                               )
            {
                PreDevSurfaceWaterDischarge = preDevSurfaceWaterDischarge;
                CurrentSWDischarge = currentSWDischarge;
                DirectToWaterCourse = directToWaterCourse;
                RainWater = rainWater;
                Other = other;
                PostDevPreAttSW = postDevPreAttSW;
                PostDevAttSW = postDevAttSW;
                ProposedDischargeSW = proposedDischargeSW;
                SelectedDirect = selectedDirect;
                SelectedRainWater = selectedRainWater;
                RelevantInfo = relevantInfo;
                OOther = oOther;
                Plans = plans;
            }

        public SurfaceWaterDrainage()
            {

            }

        public string PreDevSurfaceWaterDischarge { get; set; }
        public string CurrentSWDischarge { get; set; }
        public string DirectToWaterCourse { get; set; }
        public string RainWater { get; set; }
        public string Other { get; set; }
        public string PostDevPreAttSW { get; set; }
        public string PostDevAttSW { get; set; }
        public string ProposedDischargeSW { get; set; }
        public string SelectedDirect { get; set; }        
        public string SelectedRainWater { get; set; }
        public string RelevantInfo { get; set; }
        public string OOther { get; set; }
        public string Plans { get; set; }
        }
    
}
