using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SoutwestWater;

namespace SoutwestWater.Pages.ProcessA
{
    public class ReviewProposedReportPage : BasePage
    {
        ChromeDriver Driver;

        #region pageElements
        [FindsBy(How = How.CssSelector, Using = "a[id*=_cboAcceptDetails_Arrow]")]
        public  IWebElement _btnExposeDropDownList;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_ctl03_fvlc_Form1 > tbody > tr > td > table > tbody > tr:nth-child(1) > td > h1")]
        public IWebElement _lblHeader;
        #endregion

        public ReviewProposedReportPage(ChromeDriver driver)
        {
            Driver = driver;
            InitialisePageElements();
        }

        private void InitialisePageElements()
        {
            while (Driver.Title == "")
            {
                System.Threading.Thread.Sleep(300);
            }
            PageFactory.InitElements(Driver, this);
        }

        public void SelectDecision(string reportProposal)
        {
            FetchTask();
            _btnExposeDropDownList.Click();
            ClickDropDown(reportProposal);
        }

        private void ClickDropDown(string reportProposal)
        {
            System.Threading.Thread.Sleep(500);
            var decision = new Dictionary<string, string>();

            decision.Add("Accept", "1");
            decision.Add("Reject - provide more info", "2");
            decision.Add("Reject - end request", "3");
            Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1_cboAcceptDetails_DropDown\"]/div/ul/li[" + decision[reportProposal] + "]").Click();           
        }
    }
}
