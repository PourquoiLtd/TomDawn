using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace SoutwestWater.Pages
{
    public class AnswerEnquiryPage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "textarea[id*=_txtaAnswer")]
        public IWebElement _txtAnswer;

        [FindsBy(How = How.CssSelector, Using = "input[value='Save & Submit']")]
        public IWebElement _btnSubmit;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_fupAnswerFilefile0")]
        public IWebElement _btnUpload;

        ChromeDriver Driver;

        public AnswerEnquiryPage(ChromeDriver driver)
        {            
            FetchTask();
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void AnswerEnquiryAndSubmit(string enquiryResponse)
        {
            _txtAnswer.SendKeys(enquiryResponse);
            UploadDocument("drawings", _btnUpload);
            _btnSubmit.Click();
        }


    }
}
