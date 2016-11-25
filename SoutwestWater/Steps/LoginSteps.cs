using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SoutwestWater.Pages;
using SoutwestWater.Steps.SharedSteps;

namespace SoutwestWater.Steps
{
    [Binding]
    public class LoginSteps: SharedSpecflowSteps
    {
        public LoginPage LoginPage;
        public BusinessProcessesPage BusinessProcessesPage;

        public LoginSteps()
        {
            LoginPage = new LoginPage(driver);
        }

        [Given(@"I am logged in as a SWWBS user")]
        [When(@"I am logged in as a SWWBS user")]
        public void GivenIAmLoggedInAsASWWBSUser()
        {
            if (driver.Url != "data:,")
                LoginPage.LogOutAndCreateNewDriver(sequenceUsers.retailer);
            LoginPage.LoginUser(sequenceUsers.retailer);
        }

        [Given(@"I log in as a wholesaler")]
        [When(@"I log in as a wholesaler")]
        public void GivenILogInAsAWholesaler()
        {            
            LoginPage = new LoginPage(driver);
            if (driver.Url != "data:,")
                LoginPage.LogOutAndCreateNewDriver(sequenceUsers.wsd);
            LoginPage.LoginUser(sequenceUsers.wsd);
        }

        [Given(@"i log in as a Developer Services user")]
        public void GivenILogInAsADeveloperServicesUser()
        {
            LoginPage = new LoginPage(driver);
            if (driver.Url != "data:,")
                LoginPage.LogOutAndCreateNewDriver(sequenceUsers.developerServices);
            LoginPage.LoginUser(sequenceUsers.developerServices);
        }


    }
}
