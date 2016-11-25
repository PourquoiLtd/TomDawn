using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SoutwestWater.Pages;
using NUnit.Framework;

namespace SoutwestWater.Steps
{
    [Binding]
    public class ContentCheckingSteps : Common
    {
        InboxPage InboxPage;

        public ContentCheckingSteps()
        {
            InboxPage = new InboxPage(driver);
        }

        [Then(@"the header bar displays the following")]
        public void ThenTheHeaderBarDisplaysTheFollowing(Table headerLinks)
        {            
            InboxPage.WaitForPageToLoad();
            var headerText = headerLinks.CreateInstance<HeaderLinkText>();
            Assert.AreEqual(headerText.InboxText, InboxPage._inbox.Text);
            Assert.AreEqual(headerText.TaskDueText, InboxPage._tasksDue.Text);
            Assert.AreEqual(headerText.OverDueText, InboxPage._overdueTasks.Text);
        }
        
        [Then(@"the left side bar link details are")]
        public void ThenTheLeftSideBarLinkDetailsAre(Table linkDetails)
        {
            var expectedResults = linkDetails.CreateSet<Navigation.LinkDetails>();
            var actualLinks = InboxPage.GetLeftHandMenuItems();

            var count = 0;
            foreach (var row in expectedResults)
            {   
                Assert.AreEqual(row.LinkText, actualLinks[count].LinkText);
                Assert.AreEqual(row.Url, actualLinks[count].Url);
                count++;
            }
        }


       


        private class HeaderLinkText
        {
            public HeaderLinkText(string inboxText, string taskDueText, string overDueText)
            {
                InboxText = inboxText;
                TaskDueText = taskDueText;
                OverDueText = overDueText;
            }

            public HeaderLinkText()
            {

            }
            public string InboxText;
            public string TaskDueText;
            public string OverDueText;
        }

    }
}
