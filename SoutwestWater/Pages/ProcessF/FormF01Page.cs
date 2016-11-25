using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SoutwestWater.Pages.ProcessF
{
    public class FormF01Page : BasePage
    {
        ChromeDriver Driver;
        #region Page Elements

        #region Retailer Details

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtRetailerName")]
        public IWebElement _txtRetailerName;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtRetailerID")]
        public IWebElement _txtRetailerID;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtRetailerReference]")]
        public IWebElement _txtRetailerReference;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtContactName]")]
        public IWebElement _txtContactName;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtContactNumber]")]
        public IWebElement _txtContactNumber;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtContactEmail]")]
        public IWebElement _txtContactEmail;

        [FindsBy(How = How.CssSelector, Using = "input[id*=Form1_ctl09_input]")]
        private IWebElement _btnSaveRetailDetails;

        #endregion

        #region Eligible Premise Details 

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtSPID")]
        private IWebElement _txtSPID;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtBuildingNumber")]
        private IWebElement _txtnBuildingNumber;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtBuildingName")]
        private IWebElement _txtBuildingName;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtAddressLine1")]
        private IWebElement _txtAddressLine1;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtAddressLine2")]
        private IWebElement _txtAddressLine2;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtAddressLine3")]
        private IWebElement _txtAddressLine3;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtTown")]
        private IWebElement _txtTown;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtPostcode")]
        private IWebElement _txtPostcode;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_ctl16_input")]
        private IWebElement _btnSaveEligiblePremiseDetails;
        #endregion

        #region Drinking water enquiries or concerns

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCompositionOfWater")]
        private IWebElement _chkCompositionOfWater;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkFluorideLevels")]
        private IWebElement _chkFluorideLevels;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkWaterHardness")]
        private IWebElement _chkWaterHardness;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkWaterQualityReport")]
        private IWebElement _chkWaterQualityReport;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkWaterSupply")]
        private IWebElement _chkWaterSupply;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkWaterQualityAnimals")]
        private IWebElement _chkWaterQualityAnimals;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkLeadLevels")]
        private IWebElement _chkLeadLevels;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkPublicSourcePrompt")]
        private IWebElement _chkPublicSourcePrompt;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkWholesalerManagement")]
        private IWebElement _chkWholesalerManagement;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_Button2_input")]
        private IWebElement _btnDrinkingWaterEnquiries;

        #endregion

        #region Details Of Enquiry
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView4_Form1_txtaDetailsOfEnquiry")]
        private IWebElement _txtDetailsOfEnquiry;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView4_Form1_ctl05_input")]
        private IWebElement _btnSaveDetailsOfEnquiry;
        #endregion Details Of Enquiry

        #region Consent to Contact the Non Household Customer
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblContactOrganiseVisit_0")]
        private IWebElement _radConsentYes;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblContactOrganiseVisit_1")]
        private IWebElement _radConsentNo;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtContactNameAtPremises")]
        private IWebElement _txtContactNameAtPremises;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtContactNumber")]
        private IWebElement _txtRetContactNumber;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblNotifyDateOfVisit_0")]
        private IWebElement _radNotifyYes;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblNotifyDateOfVisit_1")]
        private IWebElement _radNotifyNo;
        #endregion

        #region Declaration
        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtSignature]")]
        private IWebElement _txtSignature;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_dtpDate_dateInput]")]
        private IWebElement _dateInput;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtFullName]")]
        private IWebElement _txtFullName;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_txtRole]")]
        private IWebElement _txtRole;

        [FindsBy(How = How.CssSelector, Using = "input[id*=_ctl07_input]")]
        private IWebElement _btnSaveDeclaration;
               

        #endregion

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_Button1_input")]
        private IWebElement _btnSaveAll;

        [FindsBy(How = How.CssSelector, Using = "input[value*=Submit]")]
        private IWebElement _btnSubmit;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl03_ContentFrame\"]/table/tbody/tr/td[2]")]
        private IWebElement _successMessage;      

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_htmlTag\"]/head/title")]
        private IWebElement _title;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_wftt15")]
        public IWebElement _notificationUser;
        
      #endregion

        public FormF01Page(ChromeDriver driver)
        {
            Driver = driver;
            InitialisePageElements();
            ScenarioContext.Current.Set<string>(Driver.Title.Substring(9,(Driver.Title.Length - 9)));
        }

        public void CloseWindow()
        {
            Driver.Close();
        }

        public void WaitForPageToLoad()
        {
            var wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(60));
            wait.Until(drv => drv.FindElement(By.CssSelector("input[id*=_txtRetailerID]")).GetAttribute("value") != "");
        }

        private void InitialisePageElements()
        {
            while(Driver.Title == "")
            {
                System.Threading.Thread.Sleep(300);
            }
            PageFactory.InitElements(Driver, this);
        }

        public void ClickTheNotifySufficientCapacityNode()
        {
            Driver.FindElementById("ctl00_ctl03_wftt15").Click();
        }

        public void ClickOnTheResubmitFormNode()
        {
            Driver.FindElementById("ctl00_ctl03_wftt16").Click();
        }

        public void ClickCancelRequest()
        {
            Driver.FindElementByLinkText("Cancel Request").Click();
        }        

        public void ClickMenuItem(string itemName)
        {
            var menuItems = new Dictionary<string, string>();

            menuItems.Add("Answer Enquiry", "ctl00_ctl03_wftt10");
            menuItems.Add("Cancel Request", "ctl00_ctl03_wftt2");
            Driver.FindElementById(menuItems[itemName]).Click();
        }

        public void AddRetailerDetails(Retailer.RetailDetails retailDetails)
        {
            ClearAndSendKeys(_txtRetailerReference, retailDetails.RetailersOwnReference);
            ClearAndSendKeys(_txtContactName, retailDetails.ContactName);
            ClearAndSendKeys(_txtContactNumber, retailDetails.ContactNumber);
            ClearAndSendKeys(_txtContactEmail, retailDetails.ContactEmail);
        }

        public void ClickUpdateServiceRequest()
        {
            Driver.FindElementByLinkText("Update Service Request").Click();
        }

        public void AddEligiblePremiseDetails(Retailer.EligiblePremiseDetails eligiblePremiseDetails)
        {           
            _txtnBuildingNumber.SendKeys(eligiblePremiseDetails.BuildingNumber);
            _txtSPID.SendKeys(eligiblePremiseDetails.Spid);
            _txtBuildingName.SendKeys(eligiblePremiseDetails.BuildingName);
            _txtAddressLine1.SendKeys(eligiblePremiseDetails.AddressLine1);
            _txtAddressLine2.SendKeys(eligiblePremiseDetails.AddressLine2);
            _txtAddressLine3.SendKeys(eligiblePremiseDetails.AddressLine3);
            _txtTown.SendKeys(eligiblePremiseDetails.Town);
            _txtPostcode.SendKeys(eligiblePremiseDetails.Postcode);
        }

        public void CheckDrinkingWaterOption(string optionToSelect)
        {
            GetDrinkingWaterOptions()[optionToSelect].Click();
        }

        public void CheckAllDrinkingWaterOptions()
        {
            foreach(var option in GetDrinkingWaterOptions())
            {
                option.Value.Click();
            }
        }

        public void AddDetailsOfEnquiry(Retailer.DetailsOfEnquiry detailsOfEnquiry)
        {
            _txtDetailsOfEnquiry.SendKeys(detailsOfEnquiry.DetailsEnquiry);
        }

        public void AddConsentToContactDetails(Retailer.ConsentToContact consentToContact)
        {
            var consent = new Dictionary<string, IWebElement>();
            consent.Add("Yes", _radConsentYes);
            consent.Add("No", _radConsentNo);

            var notify = new Dictionary<string, IWebElement>();
            notify.Add("Yes", _radNotifyYes);
            notify.Add("No", _radNotifyNo);

            consent[consentToContact.GiveConsent].Click();
            _txtContactNameAtPremises.SendKeys(consentToContact.ContactName);
            _txtRetContactNumber.SendKeys(consentToContact.ContactNumber);
            notify[consentToContact.NotifiedOfVisitDate].Click();
        }

        public void AddDeclaration(Retailer.Declaration declaration)
        {
            ClearAndSendKeys(_txtSignature, declaration.Signature);
            ClearAndSendKeys(_dateInput, DateTime.Now.ToString());
            ClearAndSendKeys(_txtFullName, declaration.FullName);
            ClearAndSendKeys(_txtRole, declaration.RoleInTheCompany);
        }

        public void AddApproval(bool accept, string reasonForReject)
        {
            FetchTask();
            if (!accept)
            {
                Actions builder = new Actions(Driver);

                builder.MoveToElement(Driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_Input")).Perform();
                Driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_Arrow").Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_cboApproved_DropDown\"]/div/ul/li[3]").Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_txtaRejectReason").Clear();
                
                if (reasonForReject != "")
                {
                    Driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_txtaRejectReason").SendKeys(reasonForReject);
                }                
            }
        }

        public void ClickButton(string buttonName)
        {
            var buttons = new Dictionary<string, IWebElement>();

            if (buttonName == "Save & Submit")
            {
                IWebElement saveAndSubmit = Driver.FindElementByCssSelector("input[value='Save & Submit']"); 
                buttons.Add("Save & Submit", saveAndSubmit);
            }
            buttons.Add("Submit", _btnSubmit);
            buttons.Add("Save All", _btnSaveAll);            

            buttons[buttonName].Click();
            System.Threading.Thread.Sleep(500);
        }

        public string GetUserMessage()
        {
            InitialisePageElements();
            return _successMessage.Text;
        }

        public List<string> GetValidationMessages(string page)
        {
           var validationMessages = GetValidationMessageFromPage(page);
           var listOfValidationMessages = new List<string>(validationMessages.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
           return listOfValidationMessages;
        }

        public string GetValidationMessageFromPage(string page)
        {
            if (page == "retailer")
            {
                return Driver.FindElementById("ctl00_ctl03_fvlc_Form1_ValidationSummary1").Text;
            }
            else
            {
                return Driver.FindElementById("ctl00_ctl03_fvlc_Form1_fvSubView1_Form1_ValidationSummary1").Text;
            }
        }

        public string GetCancelMessage()
        {
            return Driver.FindElementByXPath("//*[@id=\"ctl00_ctl03_ctl00\"]/tbody/tr[1]/td/table/tbody/tr/td[1]/div/div/ul/li[6]/div/div").Text;
        }

        public void ClosePage()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles[1]).Close();
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
        }

        private Dictionary<string, IWebElement> GetDrinkingWaterOptions()
        {
            var DrinkingWaterOptions = new Dictionary<string, IWebElement>();

            DrinkingWaterOptions.Add("An enquiry about the composition of the water supplied, including any routine enquiry about drinking water quality which does not indicate a Drinking Water Supply Change", _chkCompositionOfWater);
            DrinkingWaterOptions.Add("Request for information about fluoride levels", _chkFluorideLevels);
            DrinkingWaterOptions.Add("Request for information about water hardness", _chkWaterHardness);
            DrinkingWaterOptions.Add("Request for obtaining a water quality report", _chkWaterQualityReport);
            DrinkingWaterOptions.Add("Request for information about the water supplied, including information about how the water is treated, applicable drinking water quality standards or how drinking water is regulated", _chkWaterSupply);
            DrinkingWaterOptions.Add("The drinking water quality available to pets and other animals such as zoos", _chkWaterQualityAnimals);
            DrinkingWaterOptions.Add("Levels of lead within the water, e.g. any lead analysis report", _chkLeadLevels);
            DrinkingWaterOptions.Add("Water quality prompted by information which the Non-Household Customer has received from public sources", _chkPublicSourcePrompt);
            DrinkingWaterOptions.Add("The Wholesaler's management of any unplanned change, including any concern relating to information provided by the Wholesaler in the course of its management", _chkWholesalerManagement);

            return DrinkingWaterOptions;
        }

    }
}
