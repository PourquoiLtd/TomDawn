using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace SoutwestWater.Pages
{
    public class LoginPage : BasePage
    {
        #region pageElements
                [FindsBy(How = How.Id, Using = "username")]
                private IWebElement _username;

                [FindsBy(How = How.Id, Using = "password")]
                private IWebElement _password;

                [FindsBy(How = How.Id, Using = "chSWW")]
                private IWebElement _tsandcs;

                [FindsBy(How = How.Id, Using = "rdoPrvt")]
                private IWebElement _privateNetwork;

                [FindsBy(How = How.Name, Using = "loginButton")]
                private IWebElement _submitBtn;

                [FindsBy(How = How.Id, Using = "zz10_Menu")]
                private IWebElement _signInAsAnotherUser;

                [FindsBy(How = How.Id, Using = "zz9_ID_Logout")]
                private IWebElement _logOut;
        #endregion
        ChromeDriver Driver;
        WebDriverWait Wait;
        public string externalUrl = "https://wsddev.southwestwater.co.uk/";

        public LoginPage(ChromeDriver driver)
        {
            Driver = driver;
            InitialisePageElements();
        }

        private void InitialisePageElements()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void LoginUser(sequenceUsers user)
        {
            var url = GetLoginUrl(user);
            Driver.Url = url;
            if (url == externalUrl)
            {
                _privateNetwork.Click();
                _username.SendKeys("squsrrt11");
                _password.SendKeys("Qwerty04");
                _tsandcs.Click();
                System.Threading.Thread.Sleep(100);
                driver.FindElementById("SubmitCreds").Click();
            }

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("processes_a")));
        }

        public void Logout()
        {
            Driver.SwitchTo().Window(driver.WindowHandles[0]);
            Driver.FindElementById("zz10_Menu").Click();
            Driver.Quit();
        }


        public void LogOutAnsSignInAsAnother()
        {
            var windows = Driver.WindowHandles.Count;
            Driver.SwitchTo().Window(Driver.WindowHandles[1]).Close();
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            _signInAsAnotherUser.Click();
        }


        public string GetLoginUrl(sequenceUsers user)
        {
            Dictionary<sequenceUsers, string> userLoginDetails;
            userLoginDetails = new Dictionary<sequenceUsers, string>();

            userLoginDetails.Add(sequenceUsers.wsd, "http://SqUsrwsd2:Qwerty03@wsddev2.swwater.co.uk/");
            userLoginDetails.Add(sequenceUsers.developerServices, "http://SqUsrnc2:Qwerty03@wsddev2.swwater.co.uk/");
            userLoginDetails.Add(sequenceUsers.metering, "http://SqUsrmt1:Qwerty03@wsddev2.swwater.co.uk/");
            userLoginDetails.Add(sequenceUsers.retailer, externalUrl);

            return userLoginDetails[user];
        }

        public void LogOutAndCreateNewDriver(sequenceUsers user)
        {         
            Logout();
            CreateDriver();
            driver.Url = GetLoginUrl(user);
        }
    }
}
