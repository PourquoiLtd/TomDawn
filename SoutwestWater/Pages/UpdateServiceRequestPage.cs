using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SoutwestWater;

namespace SoutwestWater.Pages
{
    public class UpdateServiceRequestPage
    {
        ChromeDriver Driver;

        #region Page Elements
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl03_fvlc_Form1\"]/tbody/tr/td/table[1]/tbody/tr[1]/td/h2")]
        public IWebElement _header;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_lblApproved")]
        public IWebElement _rejectionIntro;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_lblRejectReason")]
        public IWebElement _rejectionReason;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_Label2")]
        public IWebElement _reject2;
        

        [FindsBy(How = How.CssSelector, Using = "#ctl00_ctl03_ContentFrame > table > tbody > tr:nth-child(4) > td.messageDetailsCell")]
        public IWebElement _subject;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_lblDecision")]
        public IWebElement _decision;

        
        #endregion

        public UpdateServiceRequestPage(ChromeDriver driver)
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

    }
}
