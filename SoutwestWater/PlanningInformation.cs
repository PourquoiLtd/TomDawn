using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class PlanningInformation
    {

        public PlanningInformation(string localAuthority,
                                   string inTheCurrentLocalPlan,
                                   string outlinePlanning,
                                   string detailedPlanning,
                                   string detailedPlanningDate,
                                   string planningReferenceNumber
                                   )
            {
                LocalAuthority = localAuthority;
                InTheCurrentLocalPlan = inTheCurrentLocalPlan;
                OutlinePlanning = outlinePlanning;
                DetailedPlanning = detailedPlanning;
                DetailedPlanningDate = detailedPlanningDate;
                PlanningReferenceNumber = planningReferenceNumber;
                
            }

            public PlanningInformation()
            {

            }

            public string LocalAuthority { get; set; }
            public string InTheCurrentLocalPlan { get; set; }
            public string OutlinePlanning { get; set; }
            public string DetailedPlanning { get; set; }
            public string DetailedPlanningDate { get; set; }
            public string PlanningReferenceNumber { get; set; }
        }
    
}
