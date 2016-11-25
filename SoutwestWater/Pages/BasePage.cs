using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace SoutwestWater.Pages
{
    public class BasePage : Common
    {        
        protected static ChromeDriver _driver;

        protected BasePage()
        {
            _driver = driver;
        }

        protected int GetNumberOfLinks()
        {
            return _driver.FindElementsByXPath("//*[@id=\"zz12_V4QuickLaunchMenu\"]/div/ul/li/").Count;
        }

        public void GetPageByLinkText(string linkText)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[0]);
            var count = 1;
            while (_driver.FindElementByLinkText(linkText).Displayed == false)
            {
                System.Threading.Thread.Sleep(2000);
                count++;
                if (count == 10) break;
            }
            _driver.FindElementByLinkText(linkText).Click();
        }

        public void ExpandTheLeftMenu()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
            _driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_ctl00\"]/tbody/tr[2]/td[2]/img").Click();
        }

        public void ClickTheWsdMenuItem()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
            _driver.FindElementByLinkText("Sequence WSD User 2").Click();
        }

        public void ClickUser(string username)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
            _driver.FindElementByLinkText(username).Click();
        }

        public int GetCountOfLeftHandLinks()
        {
            return _driver.FindElementsByCssSelector("#zz19_V4QuickLaunchMenu > div > ul > li").Count;
        }

        public List<Navigation.LinkDetails> GetLeftHandMenuItems()
        {
            var listOfLeftHandMenuLinks = new List<Navigation.LinkDetails>();

            for (var i = 1; i <= GetCountOfLeftHandLinks();i++ )
            {
                listOfLeftHandMenuLinks.Add(new Navigation.LinkDetails
                                                (_driver.FindElementByXPath("//*[@id=\"zz19_V4QuickLaunchMenu\"]/div/ul/li[" + i + "]/a/span/span").Text,
                                                 _driver.FindElementByXPath("//*[@id=\"zz19_V4QuickLaunchMenu\"]/div/ul/li[" + i + "]/a").GetAttribute("href")
                                                )
                                            );
            }
            return listOfLeftHandMenuLinks;
        }

        public void ClearAndSendKeys(IWebElement element, string stringToEnter)
        {
            if (stringToEnter != string.Empty)
            {
                element.Clear();
                element.SendKeys(stringToEnter);
            }
        }

        public void FetchTask()
        {
            System.Threading.Thread.Sleep(500);
            _driver.FindElementByCssSelector("img[src='/Shared%20Resources/Themes/SharePoint2010/WorkflowExplorer/ToolBar/Images/FetchTask.png']").Click();
            System.Threading.Thread.Sleep(800);
        }

        public void ClickButton(string buttonName)
        {
            var buttons = new Dictionary<string, IWebElement>();

            if (buttonName == "Save & Submit")
            {
                IWebElement saveAndSubmit = _driver.FindElementByCssSelector("input[value='Save & Submit']");
                buttons.Add("Save & Submit", saveAndSubmit);
            }
            
            buttons[buttonName].Click();
            System.Threading.Thread.Sleep(500);
        }

        public void AddInstructions(string instructions)
        {
            var element = _driver.FindElementByCssSelector("textarea[id*=_txtaInstructions");
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            ClearAndSendKeys(element, instructions);
        }

        private void ExposeMakeInitialResponseDropDownList()
        {
            Actions builder = new Actions(_driver);
            System.Threading.Thread.Sleep(500);
            builder.MoveToElement(_driver.FindElementById("ctl00_ctl03_fvlc_Form1_cboDecision_Input")).Perform();
            _driver.FindElementById("ctl00_ctl03_fvlc_Form1_cboDecision_Arrow").Click();
            System.Threading.Thread.Sleep(500);
        }

        private void SelectInitialReponse(string response)
        {
            var responses = new Dictionary<string, string>();

            responses.Add("Further information required", "1");
            responses.Add("Sufficient capacity", "2");
            responses.Add("DIA/Pre-development report required", "3");

            var item = responses[response];
            _driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1_cboDecision_DropDown\"]/div/ul/li[" + item + "]").Click();
           
        }

        public void MakeInitialResponse(string responseDecision)
        {
            FetchTask();
            ExposeMakeInitialResponseDropDownList();
            SelectInitialReponse(responseDecision);
        }

        public void UploadDocument(string fileName, IWebElement loadFileSelect)
        {
            loadFileSelect.Click();
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait(fileName);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
        }

       
    }
}
