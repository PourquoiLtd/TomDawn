﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SoutwestWater.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SouthwestWaterBusinessServicesExtranetHomePageContentIsCorrectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SwwbsExtranetContent.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Southwest Water Business Services Extranet Home Page content is correct", "In order to create / manage / maintain and view service request\r\n\tAs a SWWBS user" +
                    " \r\n\tI want to the extranet page to display and expose the functionality in order" +
                    " to achieve this  ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Southwest Water Business Services Extranet Home Page content is correct")))
            {
                SoutwestWater.Features.SouthwestWaterBusinessServicesExtranetHomePageContentIsCorrectFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Inbox Header displays the corect values")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Southwest Water Business Services Extranet Home Page content is correct")]
        public virtual void InboxHeaderDisplaysTheCorectValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inbox Header displays the corect values", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("I am logged in as a SWWBS user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.When("I choose the \'Inbox\' link in the left hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "InboxText",
                        "TaskDueText",
                        "OverDueText"});
            table1.AddRow(new string[] {
                        "Inbox Items",
                        "Tasks Due Today",
                        "Overdue Tasks"});
#line 9
testRunner.Then("the header bar displays the following", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SideBarNavigationalLinksAreDisplayed(string page, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Side bar navigational links are displayed", exampleTags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
testRunner.Given("I am logged in as a SWWBS user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
testRunner.When(string.Format("I choose the \'{0}\' link in the left hand menu", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "linkText",
                        "url"});
            table2.AddRow(new string[] {
                        "Inbox",
                        "http://wsddev.swwater.co.uk/Pages/Inbox.aspx"});
            table2.AddRow(new string[] {
                        "Processes",
                        "http://wsddev.swwater.co.uk/Pages/Processes.aspx"});
            table2.AddRow(new string[] {
                        "Start Process",
                        "http://wsddev.swwater.co.uk/Pages/StartProcess.aspx"});
#line 17
testRunner.Then("the left side bar link details are", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Side bar navigational links are displayed: Inbox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Southwest Water Business Services Extranet Home Page content is correct")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Inbox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:page", "Inbox")]
        public virtual void SideBarNavigationalLinksAreDisplayed_Inbox()
        {
            this.SideBarNavigationalLinksAreDisplayed("Inbox", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Side bar navigational links are displayed: Processes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Southwest Water Business Services Extranet Home Page content is correct")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Processes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:page", "Processes")]
        public virtual void SideBarNavigationalLinksAreDisplayed_Processes()
        {
            this.SideBarNavigationalLinksAreDisplayed("Processes", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Side bar navigational links are displayed: Start Process")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Southwest Water Business Services Extranet Home Page content is correct")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Start Process")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:page", "Start Process")]
        public virtual void SideBarNavigationalLinksAreDisplayed_StartProcess()
        {
            this.SideBarNavigationalLinksAreDisplayed("Start Process", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion