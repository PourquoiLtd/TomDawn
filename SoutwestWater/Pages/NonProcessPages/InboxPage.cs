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
    public class InboxPage : BasePage
    {
        ChromeDriver Driver;

        #region PageElements
        [FindsBy(How = How.CssSelector, Using = "#ctl00_m_g_1b0a38fa_d70a_4e53_87f6_9ceec4090f75_ctl00_aggregatedPanel > table > tbody > tr > td:nth-child(1) > div > span > span.aggregated-title-label.open-aggregated-title-label")]
        public IWebElement _inbox;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_m_g_1b0a38fa_d70a_4e53_87f6_9ceec4090f75_ctl00_aggregatedPanel > table > tbody > tr > td:nth-child(2) > div > span > span.aggregated-title-label.dueDate-aggregated-title-label")]
        public IWebElement _tasksDue;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_m_g_1b0a38fa_d70a_4e53_87f6_9ceec4090f75_ctl00_aggregatedPanel > table > tbody > tr > td:nth-child(3) > div > span > span.aggregated-title-label.overdue-aggregated-title-label")]
        public IWebElement _overdueTasks;

        [FindsBy(How = How.Id, Using = "titleGrid")]
        public IWebElement _inboxBanner;
        #endregion

        public InboxPage(ChromeDriver driver)
        {
            Driver = driver;
            InitialisePageElements();
        }

        public void WaitForPageToLoad()
        {
            var wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(30));
            wait.Until(drv => drv.FindElement(By.CssSelector("#ctl00_m_g_1b0a38fa_d70a_4e53_87f6_9ceec4090f75_ctl00_aggregatedPanel > table > tbody > tr > td:nth-child(1) > div > span > span.aggregated-title-label.open-aggregated-title-label")).Text == "Inbox Items");
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
