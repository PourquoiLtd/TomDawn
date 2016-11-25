using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SoutwestWater.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;
namespace SoutwestWater.Steps
{
    [Binding]
    public class ProcessesIStartedSteps: Common
    {

        public ProcessesIStartedPage ProcessesIStartedPage;
        public string ProcessIdNumber;

        public ProcessesIStartedSteps()
        {
            ProcessesIStartedPage = new ProcessesIStartedPage(driver);
            ProcessIdNumber = ScenarioContext.Current.Get<string>();
        }

        [Then(@"the submitted process can be seen in the processes I started list")]
        public void ThenTheSubmittedProcessCanBeSeenInTheProcessesIStartedList()
        {            
            Assert.IsTrue(ProcessesIStartedPage.ProcessExists(ProcessIdNumber));
        }

        [Then(@"I select '(.*)' and sub process '(.*)'")]
        [Given(@"I select '(.*)' and sub process '(.*)'")]
        [When(@"I select '(.*)' and sub process '(.*)'")]
        public void ThenISelectAndSubProcess(string Process, string subProcessName)
        {
            ProcessesIStartedPage = new ProcessesIStartedPage(driver);
            ProcessesIStartedPage.GetProcess(Process, subProcessName);
        }

        [Given(@"I open the process")]
        [When(@"I open the process")]
        [When(@"I view the details of the form")]
        public void GivenIOpenTheProcess()
        {
            ProcessesIStartedPage.OpenAProcess(ProcessIdNumber);
        }


    }
}
