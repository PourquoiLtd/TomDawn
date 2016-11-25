using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoutwestWater.Pages;
using SoutwestWater.Pages.ProcessF;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SoutwestWater.Steps.SharedSteps
{
    [Binding]
    public class SharedSpecflowSteps : Common
    {
        [Binding]
        public class GivenSteps
        {
            public LoginPage LoginPage;
            public FormF01Page FormF01Page;
            public BusinessProcessesPage BusinessProcessesPage;


            public GivenSteps()
            {
            }

            [Given(@"I expand the left hand column")]
            [When(@"I expand the left hand column")]
            public void GivenIExpandTheLeftHandColumn()
            {
                FormF01Page = new FormF01Page(driver);
                //FormF01Page.ExpandTheLeftMenu();
            }

            [Given(@"I click on the WSD link to progress the process")]
            public void GivenIClickOnTheWSDLinkToProgressTheProcess()
            {
                FormF01Page = new FormF01Page(driver);
                FormF01Page.ClickTheWsdMenuItem();
            }

            [Given(@"I choose the '(.*)' link in the left hand menu")]
            [Then(@"I choose the '(.*)' link in the left hand menu")]
            [When(@"I choose the '(.*)' link in the left hand menu")]
            public void GivenIChooseTheLinkInTheLeftHandMenu(string linkText)
            {
                LoginPage = new LoginPage(driver);
                LoginPage.GetPageByLinkText(linkText);
                System.Threading.Thread.Sleep(1000);
            }

            [Given(@"In the Retailer Details section I add the values")]
            public void GivenInTheRetailerDetailsSectionIAddTheValues(Table retailerDetailsTable)
            {
                var retailDetails = retailerDetailsTable.CreateInstance<Retailer.RetailDetails>();
                FormF01Page = new FormF01Page(driver);
                FormF01Page.AddRetailerDetails(retailDetails);
            }

            [Given(@"I click the '(.*)' button")]
            [When(@"I click the '(.*)' button")]
            [Given(@"As a WSD I click the '(.*)' button")]
            [When(@"As a WSD I click the '(.*)' button")]
            public void GivenIClickTheButton(string buttonName)
            {
                FormF01Page = new FormF01Page(driver);
                FormF01Page.ClickButton(buttonName);
            }

            [Given(@"the wholesaler accepts the process")]
            public void GivenTheWholesalerAcceptsTheProcess()
            {
                var VerifyRequestPage = new VerifyRequestPage(driver);
                VerifyRequestPage.AcceptAProcessRequest();
            }


        }

        [Binding]
        public class WhenSteps
        {
            public FormF01Page FormF01Page;
            public VerifyRequestPage VerifyRequestPage;

            [When(@"I enter an answer to the retailer and submit")]
            public void WhenIEnterAnAnswerToTheRetailerAndSubmit(Table answerText)
            {
                var answerEnquiryPage = new AnswerEnquiryPage(driver);
                answerEnquiryPage.AnswerEnquiryAndSubmit(answerText.Rows[0].First().Value);
            }

            [When(@"I view the '(.*)' page")]
            public void WhenIViewThePage(string p0)
            {
                System.Threading.Thread.Sleep(500);
            }

            [When(@"a wholesaler rejects the process instance with reason '(.*)' and '(.*)'")]
            public void WhenAWholesalerRejectsTheProcessInstanceWithReasonAnd(string reasonText, string selectReason)
            {
                VerifyRequestPage = new VerifyRequestPage(driver);
                VerifyRequestPage.RejectAProcessRequest(selectReason);
                VerifyRequestPage.AddRejectReason(reasonText);
            }
        }

        [Binding]
        public class ThenSteps
        {

        }
    }
}
