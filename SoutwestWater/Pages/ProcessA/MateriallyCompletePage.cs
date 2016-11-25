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
    public class MateriallyCompletePage : BasePage
    {
        ChromeDriver Driver;

        #region pageElements
        [FindsBy(How = How.CssSelector, Using = "a[id*=_cboDecision_Arrow]")]
        private IWebElement _btnExposeDropDownList;

        [FindsBy(How = How.CssSelector, Using = "textarea[id*=_txtaTechnicalDetails]")]
        private IWebElement _txtTechnicalDetails;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_ntxtDaysForReport]")]
        private IWebElement _txtDaysForReport;

        [FindsBy(How = How.CssSelector, Using = "textarea[id*=_txtaReasons]")]
        private IWebElement _txtReasons;

        #endregion

        public MateriallyCompletePage(ChromeDriver driver)
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

        public void SelectDecision(string materiallyCompleteDecision)
        {
            FetchTask();
            _btnExposeDropDownList.Click();
            ClickDropDown(materiallyCompleteDecision);
        }

        public void AddTechincalDetails(string techDetails)
        {
            ClearAndSendKeys(_txtTechnicalDetails, techDetails);
        }

        public void AddDaysToCarryOutDia(string days)
        {
            ClearAndSendKeys(_txtDaysForReport, days);
        }

        public void AddReasons(string reasons)
        {
            ClearAndSendKeys(_txtReasons, reasons);
        }

        private void ClickDropDown(string materiallyCompleteDecision)
        {
            System.Threading.Thread.Sleep(500);
            var decision = new Dictionary<string, string>();

            decision.Add("Form A01 is materially complete", "1");
            decision.Add("Form A01 is not materially complete", "2");

            Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1_cboDecision_DropDown\"]/div/ul/li[" + decision[materiallyCompleteDecision] + "]").Click();           
        }
    }
}
