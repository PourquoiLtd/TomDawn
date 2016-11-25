using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace SoutwestWater.Pages
{
    public class VerifyRequestPage : BasePage
    {
        ChromeDriver Driver;

        public VerifyRequestPage(ChromeDriver driver)
        {            
            FetchTask();
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void RejectAProcessRequest(string rejectReason)
        {
            ExposeAcceptDropDownList();
            SelectRejectReason(rejectReason);
            System.Threading.Thread.Sleep(500);
        }

        public void AddRejectReason(string reasonText)
        {
            var element = _driver.FindElementByCssSelector("textarea[id*=_txtaRejectReason]");
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            ClearAndSendKeys(element, reasonText);
        }

        public void AcceptAProcessRequest()
        {
           ExposeAcceptDropDownList();
           Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_DropDown\"]/div/ul/li[2]").Click();
           System.Threading.Thread.Sleep(500);
           EnterCrmNumber(); 
        }

        private void SelectRejectReason(string reason)
        {
            var rejectReasons = new Dictionary<string, string>();

            rejectReasons.Add("Incomplete form (Reject)", "3");
            rejectReasons.Add("Incorrect form used (Reject)", "4");
            rejectReasons.Add("Wrong wholesaler (Reject)", "5");
            rejectReasons.Add("Further clarification required (Reject)", "6");
            rejectReasons.Add("Other - refer to explanatory text (Reject)", "7");

            var item = rejectReasons[reason];
            Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_DropDown\"]/div/ul/li[" + item + "]").Click();
        }

        private void ExposeAcceptDropDownList()
        {
            Actions builder = new Actions(_driver);
            System.Threading.Thread.Sleep(500);
            builder.MoveToElement(_driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_Input")).Perform();
            Driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_Arrow").Click();
            System.Threading.Thread.Sleep(500);
        }


        public void EnterCrmNumber()
        {
            var crm = new Random();
            var crmNumber = crm.Next(10000).ToString();
            ClearAndSendKeys(_driver.FindElementByCssSelector("input[id*=_txtnCRMCaseNumber]"), crmNumber);    
        }

        public string GetValidationMessages()
        {
            return Driver.FindElementByCssSelector("#ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_ValidationSummary1 > ul > li").Text;
        }
    }
}
