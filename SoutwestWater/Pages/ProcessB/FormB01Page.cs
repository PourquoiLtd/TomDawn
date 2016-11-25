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


namespace SoutwestWater.Pages.ProcessB
{
    public class FormB01Page : BasePage
    {
        #region metering work to be carried out 
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_cboMeterInstall")]
        private IWebElement _chkMeterInstallation;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_cboMeterAccuracy")]
        private IWebElement _chkMeterAccuracyTest;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_cboMeterRepair")]
        private IWebElement _chkMeterRepairReplace;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_cboChangeMeter")]
        private IWebElement _chkMeterChange;
        #endregion
        #region meter installation
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_0")]
        private IWebElement _radSize15mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_1")]
        private IWebElement _radSize20mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_2")]
        private IWebElement _radSize25mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_3")]
        private IWebElement _radSize30mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_4")]
        private IWebElement _radSize40mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_5")]
        private IWebElement _radSize50mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_6")]
        private IWebElement _radSize80mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_7")]
        private IWebElement _radSize100mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_8")]
        private IWebElement _radSize150mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_9")]
        private IWebElement _radSize200mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_10")]
        private IWebElement _radSize250mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_11")]
        private IWebElement _radSize300mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_12")]
        private IWebElement _radSize350mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_13")]
        private IWebElement _radSize400mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_14")]
        private IWebElement _radSize450mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_15")]
        private IWebElement _radSize500mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_16")]
        private IWebElement _radSize600mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_17")]
        private IWebElement _radSize80_20mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_18")]
        private IWebElement _radSize100_20mm;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedMeterSize_19")]
        private IWebElement _radSizeOther;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtOtherProposedMeterSize")]
        private IWebElement _txtOtherMeterSize;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblModelOfMeter_0")]
        private IWebElement _radModelStandard;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblModelOfMeter_1")]
        private IWebElement _radModelNonStandard;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtWholesalersMeterReference")]
        private IWebElement _txtWholesaleMeterReference;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedLocation_0")]
        private IWebElement _radLocationInside;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedLocation_1")]
        private IWebElement _radLocationOutside;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_rblProposedLocation_2")]
        private IWebElement _radSurveyDetermined;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtaProposedLocationDescription")]
        private IWebElement _txtProposedLocationDescription;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtaInstallationAdditionalInformation")]
        private IWebElement _txtInstallationAdditionalInformation;
        
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

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtCustomerBannerName")]
        private IWebElement _txtCustomerBannerName;
        #endregion


        ChromeDriver Driver;

        public FormB01Page(ChromeDriver driver)
        {
            Driver = driver;
            InitialisePageElements();
            ScenarioContext.Current.Set<string>(Driver.Title.Substring(9,(Driver.Title.Length - 9)));
        }

        private Dictionary<string, IWebElement> SetMeterPhysicalSizeOptions()
        {
            var MeterPhysicalSizeOptions = new Dictionary<string, IWebElement>();
            var arrayMeterSize = new string[] { "15mm", "20mm", "25mm", "30mm", "40mm", "50mm", "80mm",
                                                "100mm", "150mm", "200mm", "250mm", "300mm", "350mm", 
                                                "400mm", "450mm", "500mm", "600mm", "80 - 20mm", 
                                                "100 -20mm", "Other"};

            var pageElements = new IWebElement[] { _radSize15mm, _radSize20mm, _radSize25mm, _radSize30mm, _radSize40mm,
                                                   _radSize50mm, _radSize80mm, _radSize100mm, _radSize150mm, _radSize200mm,
                                                   _radSize250mm, _radSize300mm, _radSize350mm, _radSize400mm, _radSize450mm,
                                                   _radSize500mm, _radSize600mm, _radSize80_20mm, _radSize100_20mm, _radSizeOther};

            var count = 0;
            foreach (var element in pageElements)
            {
                MeterPhysicalSizeOptions.Add(arrayMeterSize[count], element);
                count++;
            }

            return MeterPhysicalSizeOptions;
        }

        private Dictionary<string, IWebElement> SetMeterWorkOptions()
        {
            var MeterWorkOptions = new Dictionary<string, IWebElement>();

            MeterWorkOptions.Add("Meter installation (Please complete section 'Meter Installation')", _chkMeterInstallation);
            MeterWorkOptions.Add("Meter accuracy test (Please complete sections 'Existing Meter Details' and 'Meter Accuracy Test') ", _chkMeterAccuracyTest);
            MeterWorkOptions.Add("Meter repair or replacement due to fault (Please complete sections 'Existing Meter Details' and 'Meter Repair or Replacement due to a Fault or Other Issue with the Meter') ", _chkMeterRepairReplace);
            MeterWorkOptions.Add("Change of meter (Please complete sections Existing 'Meter Details' and 'Change of Meter') ", _chkMeterChange);

            return MeterWorkOptions;
        }

        private Dictionary<string, IWebElement> SetMeterModelOptions()
        {
            var MeterModelOptions = new Dictionary<string, IWebElement>();

            MeterModelOptions.Add("Standard", _radModelStandard);
            MeterModelOptions.Add("Non-standard", _radModelNonStandard);

            return MeterModelOptions;
        }

        private Dictionary<string, IWebElement> SetMeterLocationOptions()
        {
            var MeterLocationOptions = new Dictionary<string, IWebElement>();

            MeterLocationOptions.Add("Inside building", _radLocationInside);
            MeterLocationOptions.Add("Outside building", _radLocationOutside);
            MeterLocationOptions.Add("To be determined on survery", _radSurveyDetermined);

            return MeterLocationOptions;
        }

        private void InitialisePageElements()
        {
            while (Driver.Title == "")
            {
                System.Threading.Thread.Sleep(300);
            }
            PageFactory.InitElements(Driver, this);
        }

        public void CheckMeterWorkOption(string optionToSelect)
        {
            SetMeterWorkOptions()[optionToSelect].Click();
        }

        private void CheckMeterPhysicalSizeOption(Meter.MeterInstallation meterDetails)
        {
            SetMeterPhysicalSizeOptions()[meterDetails.PhysicalSize].Click();
            if (meterDetails.PhysicalSize == "Other")
                _txtOtherMeterSize.SendKeys(meterDetails.Other);
        }

        private void CheckMeterModelOption(string optionToSelect)
        {
            SetMeterModelOptions()[optionToSelect].Click();
        }

        private void CheckMeterLocationOption(string optionToSelect)
        {
            SetMeterLocationOptions()[optionToSelect].Click();
        }

        public void AddMeterInstallationDetails(Meter.MeterInstallation meterInstallationDetails)
        {
            CheckMeterPhysicalSizeOption(meterInstallationDetails);
            CheckMeterModelOption(meterInstallationDetails.Model);
            PopulateWholeSalerMeterMenuReference(meterInstallationDetails.MeterMenuReference);
            CheckMeterLocationOption(meterInstallationDetails.LocationOfMeter);
            PopulateDescriptionOfLocation(meterInstallationDetails.LocationDescription);
            PopulateAdditonalInformation(meterInstallationDetails.AdditionInformation);
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
            _txtCustomerBannerName.SendKeys(eligiblePremiseDetails.CustomerBannerName);
        }

        private void PopulateAdditonalInformation(string additonalInformation)
        {
            _txtInstallationAdditionalInformation.SendKeys(additonalInformation);
        }

        private void PopulateDescriptionOfLocation(string locationDescription)
        {
            _txtProposedLocationDescription.SendKeys(locationDescription);
        }

        private void PopulateWholeSalerMeterMenuReference(string meterMenuReference)
        {
            _txtWholesaleMeterReference.SendKeys(meterMenuReference);            
        }

       

        

    }
}
