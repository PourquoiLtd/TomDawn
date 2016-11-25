using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SoutwestWater.Steps;
using SoutwestWater.Steps.SharedSteps;
using SoutwestWater.Pages;
using SoutwestWater.Pages.ProcessA;
using SoutwestWater.Pages.ProcessF;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace SoutwestWater.Steps.ProcessA
{
    [Binding]
    public class FormA01Steps : SharedSpecflowSteps
    {
        public FormA01Page FormA01Page;
        public FormF01Page FormF01Page;
        public FormF4Steps FormF4Steps;
        public LoginSteps LoginSteps;
        public LoginPage LoginPage;
        public ProcessesIStartedPage ProcessesIStartedPage;
        public MateriallyCompletePage MateriallyCompletePage;
        public ReviewProposedReportPage ReviewProposedReportPage;
        public BusinessProcessesPage BusinessProcessesPage;
        public ProcessesIStartedSteps ProcessesIStartedSteps;

        public FormA01Steps()
        {
        }

        [Given(@"a retailer has created a Process A1 request")]
        public void GivenARetailerHasCreatedAProcessARequest()
        {
            LoginPage = new LoginPage(driver);
            LoginPage.LoginUser(sequenceUsers.retailer);
            LoginPage.GetPageByLinkText("Start Process");
            BusinessProcessesPage = new BusinessProcessesPage(driver);
            BusinessProcessesPage.CreateInstanceOfProcess("A01 Pre application enquiries");
            GivenIHaveAddedValidDataToAllSectionsOfTheProcessAForm();
            FormF01Page = new FormF01Page(driver);
            FormF01Page.ClickButton("Save & Submit");
            LoginSteps = new LoginSteps();
            LoginSteps.GivenILogInAsAWholesaler();
            LoginPage = new LoginPage(driver);
            LoginPage.GetPageByLinkText("Processes");
            ProcessesIStartedPage = new ProcessesIStartedPage(driver);
            ProcessesIStartedPage.GetProcess("A. New Connections", "A01 Pre-Application enquiry in relation to a new connection or connections");
            ProcessesIStartedSteps = new Steps.ProcessesIStartedSteps();
            ProcessesIStartedSteps.GivenIOpenTheProcess();
            var givenSteps = new SharedSpecflowSteps.GivenSteps();
            givenSteps.GivenIExpandTheLeftHandColumn();
            givenSteps.GivenIClickOnTheWSDLinkToProgressTheProcess();
        }

        [Given(@"In the Developement Details section I add the values")]
        public void GivenInTheDevelopementDetailsSectionIAddTheValues(Table developmentDetails)
        {
            var devDetails = developmentDetails.CreateInstance<DevelopmentDetails>();
            FormA01Page.AddDevelopmentDetails(devDetails);
        }

        [Given(@"In the Planning Information section I add the values")]
        public void GivenInThePlanningInformationSectionIAddTheValues(Table planningInformationDetails)
        {
            var planningInformation = planningInformationDetails.CreateInstance<PlanningInformation>();
            FormA01Page.AddPlanningInformationDetails(planningInformation);
        }

        [Given(@"In the Site Servicing Details section I add the values")]
        public void GivenInTheSiteServicingDetailsSectionIAddTheValues(Table siteServicingDetails)
        {
            var siteServicing = siteServicingDetails.CreateInstance<SiteServicing>();
            FormA01Page.AddSiteServicingDetails(siteServicing);
        }

        [Given(@"In the Development Levels section I add the values")]
        public void GivenInTheDevelopmentLevelsSectionIAddTheValues(Table developmentLevelsDetails)
        {
            var developmentLevels = developmentLevelsDetails.CreateInstance<DevelopmentLevels>();
            FormA01Page.AddDevelopmentLevels(developmentLevels);
        }

        [Given(@"In the Water Details section I add the details")]
        public void GivenInTheWaterDetailsSectionIAddTheDetails(Table waterDetails)
        {
            var waterDetail = waterDetails.CreateInstance<WaterDetails>();
            FormA01Page.AddWaterDetails(waterDetail);
        }

        [Given(@"In the Sewerage Details section I add the details")]
        public void GivenInTheSewerageDetailsSectionIAddTheDetails(Table sewerageDetails)
        {
            var sewerageDetail = sewerageDetails.CreateInstance<SewerageDetails>();
            FormA01Page.AddSewerageDetails(sewerageDetail);
        }

        [Given(@"In the Surface Water Drainage section I add the details")]
        public void GivenInTheSurfaceWaterDrainageSectionIAddTheDetails(Table surfaceWaterDrainage)
        {
            var surfaceWater = surfaceWaterDrainage.CreateInstance<SurfaceWaterDrainage>();
            FormA01Page.AddSurfaceWaterDrainage(surfaceWater);
        }

        [Given(@"In the Surface Water Design section I add the details")]
        public void GivenInTheSurfaceWaterDesignSectionIAddTheDetails(Table surfaceWaterDesign)
        {
            var surfaceWaterDes = surfaceWaterDesign.CreateInstance<SurfaceWaterDesign>();
            FormA01Page.AddSurfaceWaterDesign(surfaceWaterDes);
        }

        [Given(@"In the Trade Effluent section I add the details")]
        public void GivenInTheTradeEffluentSectionIAddTheDetails(Table tradeEffluentDetails)
        {
            var tradeEffluent = tradeEffluentDetails.CreateInstance<TradeEffluent>();
            FormA01Page.AddTradeEffluent(tradeEffluent);
        }

        [Given(@"In the Special Requirements sections I enter")]
        public void GivenInTheSpecialRequirementsSectionsIEnter(Table specialRequirements)
        {
            var gar = specialRequirements.Rows[0].ElementAt(0).Value;
            FormA01Page.AddSpecialRequirements(gar);
        }

        [Given(@"In the Process A Declaration section I enter")]
        public void GivenInTheProcessADeclarationSectionIEnter(Table declarationTable)
        {
            var declaration = declarationTable.CreateInstance<Retailer.Declaration>();
            FormA01Page.AddDeclaration(declaration);
        }

        [Given(@"I have added valid data to all sections of the Process A1 form")]
        public void GivenIHaveAddedValidDataToAllSectionsOfTheProcessAForm()
        {
            FormF01Page = new FormF01Page(driver);
            FormA01Page = new FormA01Page(driver);

            var retailerDetails = new Retailer.RetailDetails("ret", "id", "reference", "contact name", "0242420420", "gary@test.com");
            var developmentDetails = new DevelopmentDetails("School", "", "500", "1000", "200000", DateTime.Now.ToString(), "previous reference value", "this is sitename", "Site addres", "orsurveyRef", "location", "TR10 8JD", "development name", "contact", "07818192929", "email@email.co.uk");
            var planningInformation = new PlanningInformation("localAuthority", "Yes", "No", "Yes", "", "planRef");
            var siteServingDetails = new SiteServicing("Greenfield", "dump", DateTime.Now.ToString());
            var waterDetails = new WaterDetails("1000", "300", "2000", "400", "10");
            var sewerageDetails = new SewerageDetails("Totally separate Foul Sewage and Surface Water", "", "350", "400", "Combined", "30", "80", "100");
            var surfaceWaterDrainage = new SurfaceWaterDrainage("100", "Rain water harvesting", "", "", "", "200", "300", "Soak-away","", "", "", "", "processa1.txt");
            var surfaceWaterDesign = new SurfaceWaterDesign("All", "");
            var tradeEffluent = new TradeEffluent("No", "", "", "", "", "");
            var declaration = new Retailer.Declaration("locationPlan", "drawings", "calculations", "supportingDocs", "", DateTime.Now.ToString(), "", "arrrghghg");

            FormF01Page.AddRetailerDetails(retailerDetails);
            FormA01Page.AddDevelopmentDetails(developmentDetails);
            FormA01Page.AddPlanningInformationDetails(planningInformation);
            FormA01Page.AddSiteServicingDetails(siteServingDetails);
            FormA01Page.AddWaterDetails(waterDetails);
            FormA01Page.AddSewerageDetails(sewerageDetails);
            FormA01Page.AddSurfaceWaterDrainage(surfaceWaterDrainage);
            FormA01Page.AddSurfaceWaterDesign(surfaceWaterDesign);
            FormA01Page.AddTradeEffluent(tradeEffluent);
            FormA01Page.AddDeclaration(declaration);
        }

        [Given(@"i select '(.*)' as an initial response")]
        [When(@"i select '(.*)' as an initial response")]
        public void WhenISelectAsAnInitialResponse(string initialResponseChoice)
        {
            FormA01Page.MakeInitialResponse(initialResponseChoice);
            FormA01Page.AddInstructions("my instructions");
        }

        [When(@"the retailer resubmits the form A1")]
        public void WhenTheRetailerResubmitsTheFormA1()
        {
            FormF01Page = new FormF01Page(driver);
            FormA01Page.FetchTask();
            FormF01Page.ClickButton("Save & Submit");
        }

        [When(@"developer services deem it materially complete")]
        public void WhenDeveloperServicesDeemItMateriallyComplete()
        {
            LoginSteps = new LoginSteps();
            FormA01Page = new FormA01Page(driver);
            LoginSteps.GivenILogInAsADeveloperServicesUser();
            OpenInstanceOfProcessAndExpandMenu();
            FormA01Page = new FormA01Page(driver);
            FormA01Page.ClickProcessMateriallyComplete();
            MateriallyCompletePage = new MateriallyCompletePage(driver);
            MateriallyCompletePage.SelectDecision("Form A01 is materially complete");
            MateriallyCompletePage.ClickButton("Save & Submit");
        }

        [Then(@"the retailer must review proposed DIA/Pre-development details")]
        public void ThenTheRetailerMustReviewProposedDIAPre_DevelopmentDetails()
        {
            LoginSteps = new LoginSteps();
            LoginSteps.GivenIAmLoggedInAsASWWBSUser();
            OpenInstanceOfProcessAndExpandMenu();
            FormA01Page = new FormA01Page(driver);
            FormA01Page.ClickConfirmAgreementToDiaReport();
            ReviewProposedReportPage = new ReviewProposedReportPage(driver);
            Assert.AreEqual("Review Proposed Report Details", ReviewProposedReportPage._lblHeader.Text);
        }

        private void OpenInstanceOfProcessAndExpandMenu()
        {
            LoginPage = new LoginPage(driver);
            LoginPage.GetPageByLinkText("Processes");
            ProcessesIStartedPage = new ProcessesIStartedPage(driver);
            ProcessesIStartedPage.GetProcess("A. New Connections", "A01 Pre-Application enquiry in relation to a new connection or connections");
            ProcessesIStartedPage.OpenAProcess(ScenarioContext.Current.Get<string>());
            FormF01Page = new FormF01Page(driver);
            FormF01Page.ExpandTheLeftMenu();
        }

   }
}
