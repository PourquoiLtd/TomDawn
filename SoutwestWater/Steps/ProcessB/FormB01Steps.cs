using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoutwestWater.Steps.SharedSteps;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SoutwestWater.Pages;
using SoutwestWater.Pages.ProcessF;
using SoutwestWater.Pages.ProcessA;
using SoutwestWater.Pages.ProcessB;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace SoutwestWater.Steps.ProcessB
{
    [Binding]
    public class FormB01Steps : SharedSpecflowSteps
    {
        public FormB01Steps()
        {

        }

        [Given(@"In the Metering work to be carried out section I select '(.*)'")]
        public void GivenInTheMeteringWorkToBeCarriedOutSectionISelect(string meterWorkOptionText)
        {
            var FormB01Page = new FormB01Page(driver);
            FormB01Page.CheckMeterWorkOption(meterWorkOptionText);
        }

        [Given(@"In the B Eligible Premise Details section I add the values")]
        public void GivenInTheBEligiblePremiseDetailsSectionIAddTheValues(Table eligiblePremiseDetailsTable)
        {
            var FormB01Page = new FormB01Page(driver);
            var eligiblePremiseDetails = eligiblePremiseDetailsTable.CreateInstance<Retailer.EligiblePremiseDetails>();
            FormB01Page.AddEligiblePremiseDetails(eligiblePremiseDetails);
        }

        [Given(@"In the Meter Installation section I add the values")]
        public void GivenInTheMeterInstallationSectionIAddTheValues(Table MeterInstallationTable)
        {
            var FormB01Page = new FormB01Page(driver);
            var meterInstallationDetails = MeterInstallationTable.CreateInstance<Meter.MeterInstallation>();
            FormB01Page.AddMeterInstallationDetails(meterInstallationDetails);
        }

        [Given(@"a retailer has created Process B request '(.*)'")]
        public void GivenARetailerHasCreatedProcessBRequest(string bProcess)
        {
            var LoginPage = new LoginPage(driver);
            LoginPage.LoginUser(sequenceUsers.retailer);
            LoginPage.GetPageByLinkText("Start Process");
            var BusinessProcessesPage = new BusinessProcessesPage(driver);
            BusinessProcessesPage.CreateInstanceOfProcess(bProcess);
            GivenIHaveAddedValidDataToAllSectionsOfTheProcessBForm();
            var FormB01Page = new FormF01Page(driver);
            FormB01Page.ClickButton("Submit");           
            LoginPage = new LoginPage(driver);
            LoginPage.Logout();
            LoginPage.CreateDriver();
            LoginPage = new LoginPage(driver);
            LoginPage.LoginUser(sequenceUsers.wsd);
            LoginPage.GetPageByLinkText("Processes");
            var ProcessesIStartedPage = new ProcessesIStartedPage(driver);            
            ProcessesIStartedPage.GetProcess("B. Metering", bProcess);
            var ProcessesIStartedSteps = new Steps.ProcessesIStartedSteps();
            ProcessesIStartedSteps.GivenIOpenTheProcess();
            FormB01Page = new FormF01Page(driver);
            FormB01Page.ClickTheWsdMenuItem();
        }


        [Given(@"a retailer has created a Process B1 request")]
        public void GivenARetailerHasCreatedAProcessBRequest()
        {
            var LoginPage = new LoginPage(driver);
            LoginPage.LoginUser(sequenceUsers.retailer);
            LoginPage.GetPageByLinkText("Start Process");
            var BusinessProcessesPage = new BusinessProcessesPage(driver);
            BusinessProcessesPage.CreateInstanceOfProcess("B01 Meter installation");
            GivenIHaveAddedValidDataToAllSectionsOfTheProcessBForm();
            var FormB01Page = new FormF01Page(driver);
            FormB01Page.ClickButton("Submit");           
            LoginPage = new LoginPage(driver);
            LoginPage.LogOutAnsSignInAsAnother();
            LoginPage.LoginUser(sequenceUsers.wsd);
            LoginPage.GetPageByLinkText("Processes");
            var ProcessesIStartedPage = new ProcessesIStartedPage(driver);
            ProcessesIStartedPage.GetProcess("B. Metering", "B01 Installation of a meter performed by the Wholesaler");
            var ProcessesIStartedSteps = new Steps.ProcessesIStartedSteps();
            ProcessesIStartedSteps.GivenIOpenTheProcess();
            FormB01Page = new FormF01Page(driver);
            FormB01Page.ClickTheWsdMenuItem();
        }

        public void GivenIHaveAddedValidDataToAllSectionsOfTheProcessBForm()
        {
            var FormF01Page = new FormF01Page(driver);
            var FormB01Page = new FormB01Page(driver);

            var retailerDetails = new Retailer.RetailDetails("ret", "id", "reference", "contact name", "0242420420", "gary@test.com");
            var eligiblePremiseDetails = new Retailer.EligiblePremiseDetails("1000000019S21", "uprn", "boaref", "23", "name", "add1", "add2", "add3", "town", "ba12 6jh", "banner", true, "", "", false);
            var declaration = new Retailer.Declaration("signature", DateTime.Now.ToString(), "", "arrrghghg");

            FormF01Page.AddRetailerDetails(retailerDetails);
            FormB01Page.AddEligiblePremiseDetails(eligiblePremiseDetails);
            FormF01Page.AddDeclaration(declaration);
        }

    }
}
