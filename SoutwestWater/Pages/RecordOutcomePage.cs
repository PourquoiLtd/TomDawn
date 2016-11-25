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
    public class RecordOutcomePage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "input[id*=_dtpEffectiveCompleteDate_dateInput")]
        public IWebElement _txtEffectiveDate;

        ChromeDriver Driver;

        public RecordOutcomePage(ChromeDriver driver)
        {            
            FetchTask();
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

    }
}
