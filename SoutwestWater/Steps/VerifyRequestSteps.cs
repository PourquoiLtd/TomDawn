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
    public class VerifyRequestSteps : SharedSpecflowSteps
    {
        public VerifyRequestPage VerifyRequestPage;

        public VerifyRequestSteps()
        {
            VerifyRequestPage = new VerifyRequestPage(driver);
        }

        [Given(@"As a WSD user I reject the process and add the reason '(.*)'")]
        public void GivenAsAWSDUserIRejectTheProcessAndAddTheReason(string reasonText)
        {
            VerifyRequestPage.RejectAProcessRequest("Incomplete form (Reject)");
            VerifyRequestPage.AddRejectReason(reasonText);
        }

        [Given(@"a wholesaler accepts the process")]
        public void GivenAWholesalerAcceptsTheProcess()
        {
            VerifyRequestPage.AcceptAProcessRequest();
        }

        [Given(@"As a WSD user I reject the process and fail to add a reason")]
        public void GivenAsAWSDUserIRejectTheProcessAndFailToAddAReason()
        {
            VerifyRequestPage.RejectAProcessRequest("Incomplete form (Reject)");
            VerifyRequestPage.AddRejectReason("");
        }

        [Given(@"As a WSD user I accept the process")]
        public void GivenAsAWSDUserIAcceptTheProcess()
        {
            VerifyRequestPage.AcceptAProcessRequest();
        }

        [Then(@"an the verify request error messages is relayed to the user")]
        public void ThenAnTheVerifyRequestErrorMessagesIsRelayedToTheUser(Table validationMessages)
        {
            var expectedMessage = validationMessages.Rows.Select(x => x["errormessage"]).First();
            var actualMessage = VerifyRequestPage.GetValidationMessages();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
