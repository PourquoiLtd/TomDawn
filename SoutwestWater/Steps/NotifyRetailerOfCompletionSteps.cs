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
    public class NotifyRetailerOfCompletionSteps: Common
    {
        public NotifyRetailerOfCompletionPage NotifyRetailerOfCompletionPage;

        public NotifyRetailerOfCompletionSteps()
        {
            NotifyRetailerOfCompletionPage = new NotifyRetailerOfCompletionPage(driver);

        }

        [Then(@"the retailer will receive notification of completion")]
        public void ThenTheRetailerWillReceiveNotificationOfCompletion(Table notificationDetailsTable)
        {
            var notification = notificationDetailsTable.CreateInstance<Retailer.NotificationDetails>();

            Assert.AreEqual(notification.From, NotifyRetailerOfCompletionPage._from.Text);
           // Assert.AreEqual(notification.To, NotifyRetailerOfCompletionPage._to.Text);
            Assert.AreEqual(notification.Subject + " #" + ScenarioContext.Current.Get<string>(), NotifyRetailerOfCompletionPage._subject.Text);
        }

        [Then(@"the retailer is notified that the process is complete")]
        public void ThenTheRetailerIsNotifiedThatTheProcessIsComplete()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
