using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoutwestWater.Steps.SharedSteps;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SoutwestWater.Pages.ProcessF;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using SoutwestWater.Pages;

namespace SoutwestWater.Steps
{
    [Binding]
    public class FormF4Steps: SharedSpecflowSteps
    {
        public FormF01Page FormF01Page;
        public LoginPage LoginPage;
        public BusinessProcessesPage BusinessProcessesPage;

        public FormF4Steps()
        {
        }

        [Given(@"I have added valid data to all sections of the Process F4 form")]
        public void GivenIHaveAddedValidDataToAllSectionsOfTheProcessF4Form()
        {
           
            var retailerDetails = new Retailer.RetailDetails("ret", "id", "reference", "contact name", "0242420420", "gary@test.com");
            var eligiblePremiseDetails = new Retailer.EligiblePremiseDetails("1000000019S21", "10", "prospect villa", "add1", "add2", "add3", "Mere", "BA12 6JH");
            var detailsOfEnquiry = new Retailer.DetailsOfEnquiry("details of enquiry text");
            var consentToContact = new Retailer.ConsentToContact("Yes", "contact name", "08293427487", "No");
            var declaration = new Retailer.Declaration("signature", DateTime.Now.ToString(), "Garth Vader", "The Boss");

            LoginPage = new LoginPage(driver);
            LoginPage.LoginUser(sequenceUsers.retailer);
            LoginPage.GetPageByLinkText("Start Process");
            BusinessProcessesPage = new BusinessProcessesPage(driver);
            BusinessProcessesPage.CreateInstanceOfProcess("F04B NHH customer enquiries received by Retailer");
            FormF01Page = new FormF01Page(driver);
            FormF01Page.AddRetailerDetails(retailerDetails);
            FormF01Page.AddEligiblePremiseDetails(eligiblePremiseDetails);
            FormF01Page.AddDetailsOfEnquiry(detailsOfEnquiry);
            FormF01Page.AddConsentToContactDetails(consentToContact);
            FormF01Page.AddDeclaration(declaration);
        }

        [Given(@"In the Eligible Premise Details section I add the values")]
        public void GivenInTheEligiblePremiseDetailsSectionIAddTheValues(Table eligiblePremiseDetailsTable)
        {
            FormF01Page = new Pages.ProcessF.FormF01Page(driver);
            var eligiblePremiseDetails = eligiblePremiseDetailsTable.CreateInstance<Retailer.EligiblePremiseDetails>();
            FormF01Page.AddEligiblePremiseDetails(eligiblePremiseDetails);
        }

        [Given(@"In the Drinking water enquiries or concerns section I select '(.*)'")]
        public void GivenInTheDrinkingWaterEnquiriesOrConcernsSectionISelect(string checkOption)
        {
            FormF01Page = new Pages.ProcessF.FormF01Page(driver);
            FormF01Page.CheckDrinkingWaterOption(checkOption);
        }

        [Given(@"In the Details Of Enquiry section I enter the text below")]
        public void GivenInTheDetailsOfEnquirySectionIEnterTheTextBelow(Table detailsOfEnquiryTable)
        {
            var enquiryDetails = detailsOfEnquiryTable.CreateInstance<Retailer.DetailsOfEnquiry>();
            var detailsOfEnquiry = new Retailer.DetailsOfEnquiry("details of enquiry text");
            FormF01Page.AddDetailsOfEnquiry(detailsOfEnquiry);
        }

        [Given(@"In the Consent to Contact the Non Household Customer section I add")]
        public void GivenInTheConsentToContactTheNonHouseholdCustomerSectionIAdd(Table addConsentToContactTable)
        {
            var consentToContact = addConsentToContactTable.CreateInstance<Retailer.ConsentToContact>();
            FormF01Page.AddConsentToContactDetails(consentToContact);
        }

        [Given(@"In the Declaration section I enter")]
        public void GivenInTheDeclarationSectionIEnter(Table declarationTable)
        {
            FormF01Page = new FormF01Page(driver);
            var declaration = declarationTable.CreateInstance<Retailer.Declaration>();
            FormF01Page.AddDeclaration(declaration);
        }

        [Given(@"In the Drinking water enquiries or concerns section I select all checkbox options")]
        [When(@"In the Drinking water enquiries or concerns section I select all checkbox options")]
        public void GivenInTheDrinkingWaterEnquiriesOrConcernsSectionISelectAllCheckboxOptions()
        {
            FormF01Page.CheckAllDrinkingWaterOptions();
        }
                

        [Given(@"I close the form window")]
        public void GivenICloseTheFormWindow()
        {
            FormF01Page = new FormF01Page(driver);
            FormF01Page.CloseWindow();
        }
        
        [Then(@"the Retailer Details values have been saved")]
        public void ThenTheRetailerDetailsValuesHaveBeenSaved(Table retailerDetails)
        {
            FormF01Page.WaitForPageToLoad();
            var retDetails = retailerDetails.CreateInstance<Retailer.RetailDetails>();
            Assert.AreEqual(retDetails.RetailersOwnReference, FormF01Page._txtRetailerReference.GetAttribute("value"));
            Assert.AreEqual(retDetails.ContactName, FormF01Page._txtContactName.GetAttribute("value"));
            Assert.AreEqual(retDetails.ContactNumber, FormF01Page._txtContactNumber.GetAttribute("value"));
            Assert.AreEqual(retDetails.ContactEmail, FormF01Page._txtContactEmail.GetAttribute("value"));
        }

        [Then(@"the retailer name field and retailer id field are not empty")]
        public void ThenTheRetailerNameFieldAndRetailerIdFieldAreNotEmpty()
        {
            FormF01Page = new FormF01Page(driver);
            FormF01Page.WaitForPageToLoad();
            Assert.IsTrue(FormF01Page._txtRetailerName.GetAttribute("value") != string.Empty);
            Assert.IsTrue(FormF01Page._txtRetailerID.GetAttribute("value") != string.Empty);
        }


        [Given(@"I click the Cancel Request option in the left hand column")]
        public void GivenIClickTheCancelRequestOptionInTheLeftHandColumn()
        {
            FormF01Page.ClickCancelRequest();
        }


        

        [Given(@"I Click the Make initial Response user")]
        public void GivenIClickTheMakeInitialResponseUser()
        {
            FormF01Page.ClickUser("Sequence New Connections User 2");
        }

        [When(@"I click on the notify sufficient capacity node")]
        public void WhenIClickOnTheNotifySufficientCapacityNode()
        {
            FormF01Page.ClickTheNotifySufficientCapacityNode();
        }

        [Given(@"I click on the resubmit form node")]
        [When(@"I click on the resubmit form node")]
        public void WhenIClickOnTheResubmitFormNode()
        {
            FormF01Page.ClickOnTheResubmitFormNode();
        }

        [Given(@"I click the '(.*)' option in the left hand column")]
        public void GivenIClickTheOptionInTheLeftHandColumn(string menuItem)
        {
            FormF01Page.ClickMenuItem(menuItem);
        }

        [When(@"I go to the retailer notification page")]
        public void WhenIGoToTheRetailerNotificationPage()
        {
            FormF01Page = new FormF01Page(driver);
            FormF01Page._notificationUser.Click();
        }

        [When(@"I add an invalid '(.*)'")]
        public void WhenIAddAnInvalid(string spid)
        {
            FormF01Page = new FormF01Page(driver);
            var eligibleDetailsWithInvalidSpid = new Retailer.EligiblePremiseDetails(spid, "10", "name", "add1", "add2", "add3", "town", "BA126JH");
            FormF01Page.AddEligiblePremiseDetails(eligibleDetailsWithInvalidSpid);
        }
          
        [Then(@"'(.*)' message is displayed to the user")]
        [Given(@"'(.*)' message is displayed to the user")]
        public void ThenMessageIsDisplayedToTheUser(string successMessage)
        {
            FormF01Page = new FormF01Page(driver);
            Assert.AreEqual(successMessage, FormF01Page.GetUserMessage());
            FormF01Page.ClosePage();
        }

        [Then(@"an the error messages below are relayed to the user")]
        public void ThenAnTheErrorMessagesBelowAreRelayedToTheUser(Table validationMessages)
        {
            var listOfValidationMessages = validationMessages.Rows.Select(x => x["errormessage"]);
            var actualMessages = FormF01Page.GetValidationMessages(validationMessages.Rows[0].Value().ToString());
            Assert.IsTrue(listOfValidationMessages.SequenceEqual(actualMessages));
        }

        [Then(@"The Invalid SPID error message is desplayed to the user")]
        public void ThenTheInvalidSPIDErrorMessageIsDesplayedToTheUser()
        {
            var actualMessages = FormF01Page.GetValidationMessages("retailer");
            Assert.IsTrue(actualMessages.Contains("Invalid SPID"));
        }


    }
}
