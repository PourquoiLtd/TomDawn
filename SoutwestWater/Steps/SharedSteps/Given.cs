using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SoutwestWater.Pages;
using SoutwestWater.Pages.ProcessF;
using SoutwestWater.Pages.ProcessA;
using SoutwestWater.Steps.ProcessA;
using SoutwestWater.Steps.ProcessB;

namespace SoutwestWater.Steps
{
    [Binding]
    public class Given : Common
    {
        public LoginPage LoginPage;
        public BusinessProcessesPage BusinessProcessesPage;
        public FormF01Page FormF01Page;
        public FormA01Steps FormA01Steps;
        public FormA01Page FormA01Page;
        public FormF4Steps FormF4Steps;
        public FormB01Steps FormB01Steps;
        public ProcessesIStartedSteps ProcessesIStartedSteps;
        public LoginSteps LoginSteps;
        public ProcessesIStartedPage ProcessesIStartedPage;

        

      

       

        //[Given(@"a retailer has created a Processs B1 request")]
        //public void GivenARetailerHasCreatedAProcessBRequest()
        //{
        //    LoginPage.LogOutAndCreateNewDriver(sequenceUsers.retailer);
        //    GivenIChooseTheLinkInTheLeftHandMenu("Start Process");
        //    BusinessProcessesPage = new BusinessProcessesPage(driver);
        //    BusinessProcessesPage.CreateInstanceOfProcess("B01 Meter installation");
        //    FormB01Steps = new FormB01Steps();
        //    FormA01Steps.GivenIHaveAddedValidDataToAllSectionsOfTheProcessAForm();
        //    FormF01Page = new FormF01Page(driver);
        //    FormF01Page.ClickButton("Save & Submit");
        //    LoginSteps = new LoginSteps();
        //    LoginSteps.GivenILogInAsAWholesaler();
        //    GivenIChooseTheLinkInTheLeftHandMenu("Processes");
        //    ProcessesIStartedPage = new Pages.ProcessesIStartedPage(driver);
        //    ProcessesIStartedPage.GetProcess("A. New Connections", "A01 Pre-Application enquiry in relation to a new connection or connections");
        //    ProcessesIStartedSteps = new Steps.ProcessesIStartedSteps();
        //    ProcessesIStartedSteps.GivenIOpenTheProcess();
        //    FormF4Steps = new Steps.FormF4Steps();
        //    FormF4Steps.GivenIExpandTheLeftHandColumn();
        //    FormF4Steps.GivenIClickOnTheWSDLinkToProgressTheProcess();
        //}

        

        //[Given(@"the process is accepted and developer services ask for '(.*)'")]
        //[When(@"the process is accepted and developer services ask for '(.*)'")]
        //public void WhenTheProcessIsAcceptedAndDeveloperServicesAskFor(string developerServicesInitialResponse)
        //{
        //    FormF01Page = new FormF01Page(driver);
        //    FormF01Page.AcceptAProcessRequest();
        //    FormF01Page.ClickButton("Save & Submit");
        //    LoginSteps = new LoginSteps();
        //    LoginSteps.GivenILogInAsADeveloperServicesUser();
        //    GivenIChooseTheLinkInTheLeftHandMenu("Processes");
        //    ProcessesIStartedPage = new Pages.ProcessesIStartedPage(driver);
        //    ProcessesIStartedPage.GetProcess("A. New Connections", "A01 Pre-Application enquiry in relation to a new connection or connections");
        //    ProcessesIStartedSteps = new Steps.ProcessesIStartedSteps();
        //    ProcessesIStartedSteps.GivenIOpenTheProcess();
        //    FormF4Steps = new FormF4Steps();
        //    FormF4Steps.GivenIExpandTheLeftHandColumn();
        //    FormF01Page = new FormF01Page(driver);
        //    FormF01Page.ClickUser("Sequence New Connections User 2");
        //    FormA01Page = new FormA01Page(driver);
        //    FormA01Page.MakeInitialResponse(developerServicesInitialResponse);
        //    FormA01Page.AddInstructions("my instructions");
        //    FormF01Page.ClickButton("Save & Submit");
        //}
        
        //[Given(@"the retailer opens and resubmits the A1 form")]
        //public void GivenTheRetailerOpensAndResubmitsTheA1Form()
        //{
        //    GivenTheRetailerOpensTheProcess();
        //}

        //[Given(@"the retailer opens the process")]
        //[When(@"the retailer opens the process")]
        //public void GivenTheRetailerOpensTheProcess()
        //{
        //    LoginSteps.GivenIAmLoggedInAsASWWBSUser();
        //    GivenIChooseTheLinkInTheLeftHandMenu("Processes");
        //    ProcessesIStartedPage = new ProcessesIStartedPage(driver);
        //    ProcessesIStartedPage.GetProcess("A. New Connections", "A01 Pre-Application enquiry in relation to a new connection or connections");
        //    ProcessesIStartedSteps = new Steps.ProcessesIStartedSteps();
        //    ProcessesIStartedSteps.GivenIOpenTheProcess();
        //    FormF4Steps = new FormF4Steps();
        //    FormF4Steps.GivenIExpandTheLeftHandColumn();
        //    FormF01Page = new FormF01Page(driver);
        //    FormF01Page.ClickOnTheResubmitFormNode();
        //}







    }
}
