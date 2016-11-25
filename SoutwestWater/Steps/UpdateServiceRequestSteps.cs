using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SoutwestWater.Pages;
using SoutwestWater.Pages.ProcessF;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace SoutwestWater.Steps
{
    [Binding]
    public class UpdateServiceRequestSteps: Common
    {
        UpdateServiceRequestPage UpdateServiceRequestPage;
        FormF01Page FormF01Page;

        public UpdateServiceRequestSteps()
        {
            UpdateServiceRequestPage = new UpdateServiceRequestPage(driver);
            FormF01Page = new FormF01Page(driver);
        }

        [Then(@"An Update Service Request item is created informing the retailer group that the process has been rejected")]
        public void ThenAnUpdateServiceRequestItemIsCreatedInformingTheRetailerGroupThatTheProcessHasBeenRejected()
        {
            FormF01Page.ClickUser("Sequence Retailer 1 User 1");
            System.Threading.Thread.Sleep(500);
            Assert.AreEqual("Rejected", UpdateServiceRequestPage._header.Text);
        }

        [Then(@"An Update Service Request item is created informing the retailer group that the process has been closed")]
        public void ThenAnUpdateServiceRequestItemIsCreatedInformingTheRetailerGroupThatTheProcessHasBeenClosed()
        {
            var processNumber = ScenarioContext.Current.Get<string>();
            FormF01Page.ClickUser("Sequence Retailer 1 User 1");
            System.Threading.Thread.Sleep(500);
            Assert.AreEqual("Notification: #" + processNumber + " - Service Request Closed", UpdateServiceRequestPage._subject.Text);
        }


        [Then(@"the text '(.*)' is displayed")]
        public void ThenTheTextIsDisplayed(string decision)
        {
            Assert.AreEqual(decision, UpdateServiceRequestPage._decision.Text);
        }

        [Then(@"the rejection reason is '(.*)' '(.*)'")]
        public void ThenTheRejectionReasonIs(string rejectReason, string page)
        {
            UpdateServiceRequestPage = new Pages.UpdateServiceRequestPage(driver);
            if (page == "f4")
                Assert.AreEqual(rejectReason, UpdateServiceRequestPage._rejectionReason.Text);
            else
                Assert.AreEqual(rejectReason, UpdateServiceRequestPage._reject2.Text);
        }

    }

}
