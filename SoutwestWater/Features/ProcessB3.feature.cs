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
    public partial class ProcessB3Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProcessB3.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProcessB3", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ProcessB3")))
            {
                SoutwestWater.Features.ProcessB3Feature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Retailer Name and Retailer Id are prepopulated")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        public virtual void RetailerNameAndRetailerIdArePrepopulated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retailer Name and Retailer Id are prepopulated", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("I am logged in as a SWWBS user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("I choose the \'Start Process\' link in the left hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.When("I select create a new instance of process \'B03 Meter accuracy test performed by t" +
                    "he Wholesaler\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("the retailer name field and retailer id field are not empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A new B3 service request can be created")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        public virtual void ANewB3ServiceRequestCanBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new B3 service request can be created", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("I am logged in as a SWWBS user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I choose the \'Start Process\' link in the left hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I select create a new instance of process \'B03 Meter accuracy test performed by t" +
                    "he Wholesaler\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "RetailerName",
                        "RetailerID",
                        "RetailersOwnReference",
                        "ContactName",
                        "ContactNumber",
                        "ContactEmail"});
            table1.AddRow(new string[] {
                        "SWWBS",
                        "ret000000001",
                        "retailerOwnRef",
                        "contactName",
                        "071825728282",
                        "colinmontgomery@swwbs.co.uk"});
#line 13
 testRunner.And("In the Retailer Details section I add the values", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SPID",
                        "BuildingNumber",
                        "BuildingName",
                        "AddressLine1",
                        "AddressLine2",
                        "AddressLine3",
                        "Town",
                        "Postcode",
                        "customerBannerName"});
            table2.AddRow(new string[] {
                        "1000000019S21",
                        "40",
                        "BuildingName",
                        "add 1",
                        "add2",
                        "add 3",
                        "London",
                        "BA12 6JH",
                        "banner Name"});
#line 16
 testRunner.And("In the B Eligible Premise Details section I add the values", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Signature",
                        "Date",
                        "FullName",
                        "RoleInTheCompany"});
            table3.AddRow(new string[] {
                        "signature",
                        "now",
                        "gary t gibbons",
                        "tester"});
#line 19
 testRunner.And("In the Declaration section I enter", ((string)(null)), table3, "And ");
#line 22
 testRunner.When("I click the \'Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("\'Your data was successfully submitted.\' message is displayed to the user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("I choose the \'Processes\' link in the left hand menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I select \'B. Metering\' and sub process \'B03 Meter accuracy test performed by the " +
                    "Wholesaler\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("the submitted process can be seen in the processes I started list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue(string rejectType, string page, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
                    "process can continue", exampleTags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("a retailer has created Process B request \'B03 Meter accuracy test performed by th" +
                    "e Wholesaler\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.When(string.Format("a wholesaler rejects the process instance with reason \'unknown contact is the rea" +
                        "son\' and \'{0}\'", rejectType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("As a WSD I click the \'Save & Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("An Update Service Request item is created informing the retailer group that the p" +
                    "rocess has been rejected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.And("the rejection reason is \'unknown contact is the reason\' \'Page\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
            "process can continue: Incomplete form (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Incomplete form (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:rejectType", "Incomplete form (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:page", "")]
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue_IncompleteFormReject()
        {
            this.AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue("Incomplete form (Reject)", "", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
            "process can continue: Further clarification required (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Further clarification required (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:rejectType", "Further clarification required (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:page", "")]
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue_FurtherClarificationRequiredReject()
        {
            this.AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue("Further clarification required (Reject)", "", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
            "process can continue: Other - refer to explanatory text (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Other - refer to explanatory text (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:rejectType", "Other - refer to explanatory text (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:page", "")]
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue_Other_ReferToExplanatoryTextReject()
        {
            this.AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessCanContinue("Other - refer to explanatory text (Reject)", "", ((string[])(null)));
#line hidden
        }
        
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessEnds(string rejectType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
                    "process ends", exampleTags);
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
 testRunner.Given("a retailer has created Process B request \'B03 Meter accuracy test performed by th" +
                    "e Wholesaler\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.When(string.Format("a wholesaler rejects the process instance with reason \'unknown contact is the rea" +
                        "son\' and \'{0}\'", rejectType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.And("As a WSD I click the \'Save & Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("An Update Service Request item is created informing the retailer group that the p" +
                    "rocess has been closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
            "process ends: Incorrect form used (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Incorrect form used (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:rejectType", "Incorrect form used (Reject)")]
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessEnds_IncorrectFormUsedReject()
        {
            this.AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessEnds("Incorrect form used (Reject)", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A wholesaler can reject a B3 process from a retailer using all reasons where the " +
            "process ends: Wrong wholesaler (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Wrong wholesaler (Reject)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:rejectType", "Wrong wholesaler (Reject)")]
        public virtual void AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessEnds_WrongWholesalerReject()
        {
            this.AWholesalerCanRejectAB3ProcessFromARetailerUsingAllReasonsWhereTheProcessEnds("Wrong wholesaler (Reject)", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A retailer initiated Process B3 is Accepted and processed by the Wholesaler")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProcessB3")]
        public virtual void ARetailerInitiatedProcessB3IsAcceptedAndProcessedByTheWholesaler()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A retailer initiated Process B3 is Accepted and processed by the Wholesaler", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
 testRunner.Given("a retailer has created Process B request \'B03 Meter accuracy test performed by th" +
                    "e Wholesaler\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
 testRunner.And("the wholesaler accepts the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("As a WSD I click the \'Save & Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.When("the wholesaler Record outcome", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("the retailer is notified that the process is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
