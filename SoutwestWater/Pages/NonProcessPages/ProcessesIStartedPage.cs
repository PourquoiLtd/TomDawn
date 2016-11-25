using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SoutwestWater.Pages
{
    public class ProcessesIStartedPage : BasePage
    {
        string idForProcessesData = "ctl00_m_g_23dd205b_29c3_43a8_a9f4_12e181516e3f_ctl00_baseSPGridView";
        ChromeDriver Driver;
        public List<OpenProcess> AllOpenProcesses { get; private set; }
        WebDriverWait wait;

        public ProcessesIStartedPage(ChromeDriver driver)
        {
            
            Driver = driver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#grid > table > thead > tr > th:nth-child(1) > a.k-link")));
        }

        public int GetNumberOfProcesses()
        {
            System.Threading.Thread.Sleep(2000);
            return Driver.FindElementsByXPath("//*[@id=\"grid\"]/table/tbody/tr").Count;
        }

        public List<OpenProcess> GetListOfOpenProcesses()
        {
            AllOpenProcesses = new List<OpenProcess>();

            for (var i = 0; i < 5; i++)
            {
                if (GetNumberOfProcesses() == 0)
                {
                    System.Threading.Thread.Sleep(1000);
                }

            }
            for (var i = 1; i <= 3; i++)
            {
                AllOpenProcesses.Add(
                                        new OpenProcess(
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[1]/span").Text,
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[2]/span").Text,
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[4]/span").Text,
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[5]/span").Text,
                                            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + i + "]/td[6]/span").Text,
                                            i.ToString()
                                                        )
                                        );
            }
            return AllOpenProcesses;
        }

        public string GetPageNumber()
        {
            var PageNumber = new Dictionary<string, string>();
            var page = Driver.FindElementByXPath("//*[@id=\"ctl00_m_g_0feb139a_5c4d_4a19_8850_22e9c22c310e_ctl00_pager\"]/td/table/tbody/tr/td[1]/span").Text;

            PageNumber.Add("1-10 ", "1");
            PageNumber.Add("11-20", "2");
            PageNumber.Add("21-30", "3");

            return PageNumber[page.Substring(0, 5)];
        }

        public bool ProcessExists(string processId)
        {
            GetListOfOpenProcesses();

            if (AllOpenProcesses.First(x => x.Id == processId) != null)
                return true;
            return false;
        }

        public void OpenAProcess(string processId)
        {
            var process = GetProcessUsingID(processId);
            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + process.RowNumberOnPage + "]/td[2]/span").Click();
            Driver.FindElementById("Open").Click();


            while (Driver.WindowHandles.Count == 1)
            {
                System.Threading.Thread.Sleep(1000);
            }

            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
        }

        public OpenProcess GetProcessUsingID(string processId)
        {
            if (AllOpenProcesses == null)
            {
                GetListOfOpenProcesses();
            }

            var process = AllOpenProcesses.First(x => x.Id == processId);
            if (process != null)
            {
                return process;
            }
            else throw new ArgumentNullException("Process " + processId + " cannot be found");
        }

        public void DeleteAProcess(string processId)
        {
            var process = GetProcessUsingID(processId);
            Driver.FindElementByXPath("//*[@id=\"grid\"]/table/tbody/tr[" + process.RowNumberOnPage + "]/td[3]/span").Click();
            Driver.FindElementById("Delete").Click();
            System.Threading.Thread.Sleep(100);
            Driver.SwitchTo().Alert().Accept();
        }

        public void DeleteAllMyprocesses()
        {

        }

        public void GetProcess(string process, string processName)
        {
            System.Threading.Thread.Sleep(3000);
            IWebElement level1 = Driver.FindElementByLinkText(process);
            wait.Until(ExpectedConditions.ElementToBeClickable(level1));
            Actions builder = new Actions(Driver);
            Actions hoverClick = builder.MoveToElement(level1).Click();
            hoverClick.Build().Perform();
            
            var url = Driver.FindElementByLinkText(processName).GetAttribute("href");
            //Driver.FindElementByLinkText(processName).Click();
            Driver.Navigate().GoToUrl(url);

            var count = 1;
            while (GetNumberOfProcesses() < 1 )
            {
                GetProcess(process, processName);
                System.Threading.Thread.Sleep(100);
                count ++;
                if (count == 20)
                {
                    break;
                }
            }
        }

        public class OpenProcess
        {

            public OpenProcess(string id, string creationDate, string ownedBy, string lastUpdated, string stage, string rowNumberOnPage)
            {
                Id = id;
                CreationDate = creationDate;
                OwnedBy = ownedBy;
                LastUpdated = lastUpdated;
                Stage = stage;
                RowNumberOnPage = rowNumberOnPage;
            }

            public string Id { get; private set; }
            public string CreationDate { get; private set; }
            public string OwnedBy { get; private set; }
            public string LastUpdated { get; private set; }
            public string Stage { get; private set; }
            public string RowNumberOnPage { get; private set; }
        }
    }
}
