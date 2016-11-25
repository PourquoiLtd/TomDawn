using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SoutwestWater.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;


namespace SoutwestWater.Steps
{
    [Binding]
    public class CancelRequestSteps : Common
    {
        CancelRequestPage CancelRequestPage;

        public CancelRequestSteps()
        {
            CancelRequestPage = new CancelRequestPage(driver);
        }
        
        [When(@"I select the yes cancel radio button")]
        public void WhenISelectTheYesCancelRadioButton()
        {
            CancelRequestPage.SetRadioOption(true);
        }

        [When(@"I enter the reason '(.*)'cancel reason'")]
        public void WhenIEnterTheReasonCancelReason(string reason)
        {
            CancelRequestPage.EnterReason(reason);
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            CancelRequestPage.ClickSubmit();
        }

        [Then(@"the request will be cancelled")]
        public void ThenTheRequestWillBeCancelled()
        {
            Assert.AreEqual("Cancelled", CancelRequestPage.GetStatusFromHeader());
        }



    }
}
