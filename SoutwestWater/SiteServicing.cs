using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class SiteServicing
    {

        public SiteServicing(string landType,
                             string previousUse,
                             string dateLastOccupied)
            {
                LandType = landType;
                PreviousUseOfSite = previousUse;
                DateLastOccupied = dateLastOccupied;
                
            }

        public SiteServicing()
            {

            }

            public string LandType { get; set; }
            public string PreviousUseOfSite { get; set; }
            public string DateLastOccupied { get; set; }
        }
    
}
