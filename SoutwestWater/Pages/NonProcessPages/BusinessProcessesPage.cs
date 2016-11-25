using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SoutwestWater.Pages
{
    public class BusinessProcessesPage : BasePage
    {

        string idForProcessesData = "ctl00_m_g_0feb139a_5c4d_4a19_8850_22e9c22c310e_ctl00_baseSPGridView";
        WebDriverWait wait;
        ChromeDriver Driver;
        public List<BusinessProcess> AllBusinessProcesses { get; private set; }

        public BusinessProcessesPage(ChromeDriver driver)
        {
            Driver = driver;
        }


        public int GetNumberOfProcesses()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"grid\"]/table/tbody/tr")));
            while (Driver.FindElementsByXPath("//*[@id=\"grid\"]/table/tbody/tr").Count == 0)
            {
                System.Threading.Thread.Sleep(100);
            }
            return Driver.FindElementsByXPath("//*[@id=\"grid\"]/table/tbody/tr").Count;
        }

        public void CreateInstanceOfProcess(string processName)
        {
            GetListOfBusinessProcesses();
            var process = AllBusinessProcesses.First(x => x.ProcessName == processName);
            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + process.RowNumberOnPage + "]/td[2]/span").Click();
            Driver.FindElementById("StartNewInstance").Click();

            
            while (Driver.WindowHandles.Count == 1)
            {
                System.Threading.Thread.Sleep(200);
            }

            Driver.SwitchTo().Window(Driver.WindowHandles[1]);

        }

        public List<BusinessProcess> GetListOfBusinessProcesses() //only 10 at the moment not looking at pagination
        {
            AllBusinessProcesses = new List<BusinessProcess>();

            for (var i = 1; i <= GetNumberOfProcesses(); i++)
            {
                AllBusinessProcesses.Add(
                                        new BusinessProcess(
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[1]/span").Text,
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[3]/span").Text,
                                            i.ToString(),
                                            GetPageNumber()
                                                           )
                                        );
            }

            return AllBusinessProcesses;
        }

        public string GetPageNumber()
        {
            var PageNumber = new Dictionary<string, string>();
            var page = Driver.FindElementByXPath("//*[@id=\"grid\"]/div[2]/span").Text;
            
            PageNumber.Add("1 - 10 ","1");
            PageNumber.Add("11 - 20","2" );
            PageNumber.Add("21 - 30","3");

            if (PageNumber.ContainsKey(page.Substring(0, 5)))
                return PageNumber[page.Substring(0, 5)];
            else
                return "1";
        }

        public class BusinessProcess
        {

            public BusinessProcess(string processName, string description, string rowNumberOnPage, string pageNumber)
            {
                ProcessName = processName;
                Description = description;
                RowNumberOnPage = rowNumberOnPage;
                PageNumber = pageNumber;
            }

            public string ProcessName     { get; private set; }
            public string Description     { get; private set; }
            public string RowNumberOnPage { get; private set; }
            public string PageNumber { get; private set; }
        }
    }
}
