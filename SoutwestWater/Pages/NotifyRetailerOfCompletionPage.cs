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
    public class NotifyRetailerOfCompletionPage
    {
        ChromeDriver Driver;

        #region Page Elements
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl03_ContentFrame\"]/table/tbody/tr[1]/td[2]")]
        public IWebElement _to;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl03_ContentFrame\"]/table/tbody/tr[2]/td[2]")]
        public IWebElement _from;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl03_ContentFrame\"]/table/tbody/tr[4]/td[2]")]
        public IWebElement _subject;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl03_ContentFrame\"]/table/tbody/tr[6]/td/div")]
        public IWebElement _messageBody;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_ef_subject")]
        public IWebElement _rejectSubject;

        public NotifyRetailerOfCompletionPage(ChromeDriver driver)
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

        public string GetRejectHeader()
        {
            return Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1\"]/tbody/tr/td/table[1]/tbody/tr[1]/td/h2").Text;
        }

        
        #endregion


    }
}
