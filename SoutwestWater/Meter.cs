using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class Meter
    {
        public class MeterInstallation
        {
            public MeterInstallation(string physicalSize, 
                                     string other, 
                                     string model, 
                                     string meterMenuReference,
                                     string locationOfMeter,
                                     string locationDescription,
                                     string additionInformation)
            {
                PhysicalSize = physicalSize;
                Other = other;
                Model = model;
                MeterMenuReference = meterMenuReference;
                LocationOfMeter = locationOfMeter;
                LocationDescription = locationDescription;
                AdditionInformation = additionInformation;
            }

            public MeterInstallation()
            {

            }

            public string PhysicalSize { get; set; }
            public string Other { get; set; }
            public string Model { get; set; }
            public string MeterMenuReference { get; set; }
            public string LocationOfMeter { get; set; }
            public string LocationDescription { get; set; }
            public string AdditionInformation { get; set; }
        }
    }
}
