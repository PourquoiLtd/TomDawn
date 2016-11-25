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

namespace SoutwestWater.Pages
{
    public class CancelRequestPage
    {
        ChromeDriver Driver;

        #region PageElements
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_rblCancelRequest_0")]
        public IWebElement _RadioNo;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_rblCancelRequest_1")]
        public IWebElement _RadioYes;   

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_txtaCancelReason")]
        public IWebElement _txtReason;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_ctlSubmit_input")]
        private IWebElement _btnSubmit;
        #endregion

        public CancelRequestPage(ChromeDriver driver)
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

        public void SetRadioOption(bool radioOption)
        {
            var select = new Dictionary<bool, IWebElement>();

            select.Add(true, _RadioYes);
            select.Add(false, _RadioNo);
            
            if(select[radioOption].GetAttribute("checked") != "checked")
                select[radioOption].Click();        
        }

        public void EnterReason(string reasonForCancel)
        {
            _txtReason.SendKeys(reasonForCancel);
        }

        public void ClickSubmit()
        {
            _btnSubmit.Click();
        }

        public string GetStatusFromHeader()
        {
            System.Threading.Thread.Sleep(500);
            return Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_ctl00\"]/tbody/tr[1]/td/table/tbody/tr/td[1]/div/div/ul/li[6]/div/div").Text;
        }

        
    }
}
