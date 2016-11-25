using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace SoutwestWater
{
    [Binding]
    public class Common
    {
        public static ChromeDriver driver; 
        public enum sequenceUsers
        {
            wsd,
            developerServices,
            metering,
            retailer
        }

        [BeforeScenario]
        public static void BeforeUiFeature()
        {
            CreateDriver();
            
            //Gurock.TestRail.APIClient client = new Gurock.TestRail.APIClient("https://pourquoi.testrail.com/");
            //client.User = "info@pourquoi.org.uk"; //Put the e-mail of your user here
            //client.Password = "Suzukig5xr75082108019"; //Put the password of your user here

            //var hold = client.SendGet("https://pourquoi.testrail.net/index.php?/api/v2/get_case/25");

            //Dictionary<string, object> testResult = new Dictionary<string, object>();
            //testResult["status_id"] = "1";
            //testResult["comment"] = "WOOO";
            //client.SendPost("add_result/5/1", testResult);
        }

        [AfterScenario]
        public static void AfterUiFeature()
        {
            if (ScenarioContext.Current.ContainsKey("OpenQA.Selenium.Chrome.ChromeDriver"))
            {
                ScenarioContext.Current.Get<ChromeDriver>().Quit();
                driver.Quit();
            }
            driver.Quit();
        }

        public static void CreateDriver()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\SWW\\");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(100));
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(100));
            driver.Manage().Window.Maximize();
        }
        
    }
}
