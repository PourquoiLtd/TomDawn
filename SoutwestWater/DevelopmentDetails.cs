using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class DevelopmentDetails
    {
             
            public DevelopmentDetails(string typeOfDevelopement, 
                                      string otherType, 
                                      string numberOfCommercialUnits, 
                                      string numberOfIndustrialUnits,
                                      string siteArea,
                                      string startDate,
                                      string previousWholesaleRef,
                                      string siteName,
                                      string siteAddress,
                                      string ordSurveyRef,
                                      string location,
                                      string postcodeOut,
                                      string devName,
                                      string siteContactName,
                                      string contactNumber, 
                                      string contactEmail)
            {
                TypeOfDevelopement = typeOfDevelopement;
                OtherType = otherType;
                NumberOfCommercialUnits = numberOfCommercialUnits;
                NumberOfIndustrialUnits = numberOfIndustrialUnits;
                SiteArea = siteArea;
                StartDate = startDate;
                PreviousWholesaleRef = previousWholesaleRef;
                SiteName = siteName;
                SiteAddress = siteAddress;
                OrdSurveyRef = ordSurveyRef;
                Location = location;
                PostcodeOut = postcodeOut;
                DevName = devName;
                SiteContactName = siteContactName;
                ContactNumber = contactNumber;
                ContactEmail = contactEmail;
            }

            public DevelopmentDetails()
            {

            }

            public string TypeOfDevelopement { get; set; }
            public string OtherType { get; set; }
            public string NumberOfCommercialUnits { get; set; }
            public string NumberOfIndustrialUnits { get; set; }
            public string SiteArea { get; set; }
            public string StartDate { get; set; }
            public string PreviousWholesaleRef { get; set; }
            public string SiteName { get; set; }
            public string SiteAddress { get; set; }
            public string OrdSurveyRef { get; set; }
            public string Location { get; set; }
            public string PostcodeOut { get; set; }
            public string DevName { get; set; }
            public string SiteContactName { get; set; }
            public string ContactNumber { get; set; }
            public string ContactEmail { get; set ; }
        }
    
}
