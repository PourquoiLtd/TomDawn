using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SoutwestWater.Pages;


namespace SoutwestWater.Steps
{
    [Binding]
    public class BusinessProcessSteps : Common
    {
        public BusinessProcessesPage BusinessProcessesPage;

        public BusinessProcessSteps()
        {
            BusinessProcessesPage = new BusinessProcessesPage(driver);
        }

        [Given(@"I select create a new instance of process '(.*)'")]
        [When(@"I select create a new instance of process '(.*)'")]
        public void GivenISelectCreateANewInstanceOfProcess(string processName)
        {
            BusinessProcessesPage.CreateInstanceOfProcess(processName);
        }

    }
}
