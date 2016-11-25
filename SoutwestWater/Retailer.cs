using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoutwestWater
{
    public class Retailer
    {

        public class RetailDetails
        {
            public RetailDetails(
                    string retailerName,
                    string retailerId,
                    string retailersReference,
                    string contactName,
                    string contactNumber,
                    string contactEmail)
            {
                RetailerName = retailerName;
                RetailerId = retailerId;
                RetailersOwnReference = retailersReference;
                ContactName = contactName;
                ContactNumber = contactNumber;
                ContactEmail = contactEmail;
            }

            public RetailDetails()
            {
            }

            public string RetailerName { get; set; }
            public string RetailerId { get; set; }
            public string RetailersOwnReference { get; set; }
            public string ContactName { get; set; }
            public string ContactNumber { get; set; }
            public string ContactEmail { get; set; }
        }

        public class EligiblePremiseDetails
        {
            public EligiblePremiseDetails(string spid, string buildingNumber, string buildingName, string add1, string add2, string add3, string town, string postCode)
            {
                Spid = spid;
                BuildingNumber = buildingNumber;
                BuildingName = buildingName;
                AddressLine1 = add1;
                AddressLine2 = add2;
                AddressLine3 = add3;
                Town = town;
                Postcode = postCode;
            }

            public EligiblePremiseDetails(string spid, string uprn, string voaBaReference, string buildingNumber, string buildingName
                                          , string add1, string add2, string add3, string town, string postCode, string customerBannerName
                                          , bool sameAddress, string newAddress, string meterAddressPostCode, bool sensitiveCustomer)
            {
                Spid = spid;
                Uprn = uprn;
                VoaBaReference = voaBaReference;
                BuildingNumber = buildingNumber;
                BuildingName = buildingName;
                AddressLine1 = add1;
                AddressLine2 = add2;
                AddressLine3 = add3;
                Town = town;
                Postcode = postCode;
                CustomerBannerName = customerBannerName;
                SameAddress = sameAddress;
                NewAddress = newAddress;
                MeterAddressPostCode = meterAddressPostCode;
                SensitiveCustomer = sensitiveCustomer;
            }

            public EligiblePremiseDetails()
            {

            }

            public string Spid { get; set; }
            public string Uprn { get; set; }
            public string VoaBaReference { get; set; }
            public string BuildingNumber { get; set; }
            public string BuildingName { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string AddressLine3 { get; set; }
            public string Town { get; set; }
            public string Postcode { get; set; }
            public string CustomerBannerName { get; set; }
            public bool SameAddress { get; set; }
            public string NewAddress { get; set; }
            public string MeterAddressPostCode { get; set; }
            public bool SensitiveCustomer { get; set; }
        }

        public class DetailsOfEnquiry
        {
            public DetailsOfEnquiry(string enquiryDetails)
            {
                DetailsEnquiry = enquiryDetails;
            }

            public DetailsOfEnquiry()
            {

            }

            public string DetailsEnquiry { get; set; }
        }

        public class ConsentToContact
        {
            public ConsentToContact(string giveConsent, string contactName, string contactNumber, string notifiedOfVisitDate)
            {
                GiveConsent = giveConsent;
                ContactName = contactName;
                ContactNumber = contactNumber;
                NotifiedOfVisitDate = notifiedOfVisitDate;
            }

            public ConsentToContact()
            {

            }

            public string GiveConsent { get; set; }
            public string ContactName { get; set; }
            public string ContactNumber { get; set; }
            public string NotifiedOfVisitDate { get; set; }
        }

        public class Declaration
        {
            public Declaration(string signature, string date, string fullName, string roleInCompany)
            {
                Signature = signature;
                Date = date;
                FullName = fullName;
                RoleInTheCompany = roleInCompany;
            }

            public Declaration(string locationPlan, string drawings, string calculations, string supportingDocs, string signature, string date, string fullName, string roleInCompany)
            {
                LocationPlan = locationPlan;
                Drawings = drawings;
                Calculations = calculations;
                SupportingDocs = supportingDocs;
                Signature = signature;
                Date = date;
                FullName = fullName;
                RoleInTheCompany = roleInCompany;
            }

            public Declaration()
            {

            }

            public string LocationPlan { get; set; }
            public string Drawings { get; set; }
            public string Calculations { get; set; }
            public string SupportingDocs { get; set; }
            public string Signature { get; set; }
            public string Date { get; set; }
            public string FullName { get; set; }
            public string RoleInTheCompany { get; set; }
        }

        public class NotificationDetails
        {
            public NotificationDetails(string to, string from, string subject, string message)
            {
                To = to;
                From = from;
                Subject = subject;
                Message = message;
            }

            public NotificationDetails()
            {

            }

            public string To { get; set; }
            public string From { get; set; }
            public string Subject { get; set; }
            public string Message { get; set; }
        }
    }
}
