using System;
using System.Windows;
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
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using SoutwestWater;
using SoutwestWater.Pages.ProcessF;

namespace SoutwestWater.Pages.ProcessA
{
    

    public class FormA01Page : BasePage
    {
        ChromeDriver Driver;

        #region Development Details

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentType_0")]
        public IWebElement _radIndustrial;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentType_1")]
        public IWebElement _radCommercial;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentType_2")]
        public IWebElement _radSchool;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentType_3")]
        public IWebElement _radHospital;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentType_4")]
        public IWebElement _radHotel;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentType_5")]
        public IWebElement _radOther;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtDevelopmentTypeOther")] 
        public IWebElement _txtDevelopmentTypeOther;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnCommercialUnitsNo")] 
        public IWebElement _txtCommercialUnitsNo;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnIndustrialUnitsNo")] 
        public IWebElement _txtIndustrialUnitsNo;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnAreaOfSite")] 
        public IWebElement _txtAreaOfSite;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_dtpDevelopmentStartDate_dateInput")] 
        public IWebElement _dateDevelopmentStartSate;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtaPreviousWholesalerReferences")]
        public IWebElement _txtPreviousWholesaleRef;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtSiteName")] 
        public IWebElement _txtSiteName;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtaSiteAddress")]
        public IWebElement _txtSiteAddress;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtOrdnanceSurveyReferences")] 
        public IWebElement _txtOrdnanceSurveyReferences;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtaDevelopmentLocation")]
        public IWebElement _txtLocation;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtPostcodeOutcode")] 
        public IWebElement _txtPostcodeOutCode;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtDeveloperName")] 
        public IWebElement _txtDeveloperName;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtSiteContact")] 
        public IWebElement _txtSiteContact;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtContactNumber")] 
        public IWebElement _txtContactNumber;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtContactEmail")] 
        public IWebElement _txtContactEmail;
#endregion

        #region Planning Information
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtLocalAuthorityArea")] 
        public IWebElement _txtLocalAuthorityArea;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentIncludedLocalPlan_0")] 
        public IWebElement _radDevelopmentIncluded;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDevelopmentIncludedLocalPlan_1")]
        public IWebElement _radDevelopmentNotIncluded;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblOutlinePlanningPermission_0")] 
        public IWebElement _radOutlinePlanningPermission;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblOutlinePlanningPermission_1")]
        public IWebElement _radNoOutlinePlanningPermission;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDetailedPlanningPermission_0")] 
        public IWebElement _radDetailedPlanningPermission;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblDetailedPlanningPermission_1")]
        public IWebElement _radNoDetailedPlanningPermission;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_dtpDetailedPlanningPermissionReceived_dateInput")] 
        public IWebElement _dateDetailedPlanningPermissionReceived;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtPlanningReference")] 
        public IWebElement _txtPlanningReference;
#endregion

        #region Site Servicing Details
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblLandType_0")] 
        public IWebElement _radLandTypeGreenfield;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblLandType_1")]
        public IWebElement _radLandTypeBrownfield;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtPreviousUseOfSite")] 
        public IWebElement _txtPreviousUseOfSite;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_dtpBuildingLastOccupied_dateInput")] 
        public IWebElement _dateBuildingLastOccupied;
#endregion

        #region Develeopment Levels
                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnLowestGroundLevel")]
                public IWebElement _txtLowestGroundLevel;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnLowestRoadLevel")]
                public IWebElement _txtLowestRoadLevel;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnLowestFloorLevel")]
                public IWebElement _txtLowestFloorLevel;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblInvestigationQuote_0")] 
                public IWebElement _radInvestigationYes;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblInvestigationQuote_1")]
                public IWebElement _radInvestigationNo;
        #endregion

        #region Water Details
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPreDevPeakWater")] 
        public IWebElement _txtPreDevPeakWater;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPreDevAverageWater")] 
        public IWebElement _txtPreDevAverageWater;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostDevPeakWater")] 
        public IWebElement _txtPostDevPeakWater;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostDevAverageWater")] 
        public IWebElement _txtPostDevAverageWater;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnProposedHighestWaterFitting")] 
        public IWebElement _txtProposedHighestWaterFitting;
        #endregion

        #region Sewerage Details
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblPreDevWasteWaterDesign_0")] 
        public IWebElement _radPreSeparate;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblPreDevWasteWaterDesign_1")] 
        public IWebElement _radPreCombined;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblPreDevWasteWaterDesign_2")] 
        public IWebElement _radPrePartiallyCombined;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnQuantityOfSurfaceWaterToCombined")] 
        public IWebElement _txtPreQuantityOfSurfaceWaterTocombine;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPreDevPeakFoul")] 
        public IWebElement _txtPreDevPeakFoul;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPreDevAverageFoul")] 
        public IWebElement _txtPreDevAverageFoul;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblPostDevWasteWaterDesign_0")]
        public IWebElement _radPostSeparate;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblPostDevWasteWaterDesign_1")]
        public IWebElement _radPostCombined;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblPostDevWasteWaterDesign_2")]
        public IWebElement _radPostPartiallyCombined;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostQantityofSurfaceWateruToCombined")]
        public IWebElement _txtPostQuantityOfSurfaceWaterTocombine;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostDevPeakFoul")]
        public IWebElement _txtPostDevPeakFoul;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostDevAverageFoul")]
        public IWebElement _txtPostDevAverageFoul;
        #endregion

        #region Surface Water Drainage
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPreDevSurfaceWaterDischarge")]
        public IWebElement _txtPreDevSurfaceWaterDischarge;

        #region current check values
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentSurfaceWaterSewers")]
        public IWebElement _chkCurrentSurfaceWaterSewers;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentCombinedSewer")]
        public IWebElement _chkCurrentCombinedSewer;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentSoakAway")]
        public IWebElement _chkCurrentSoakAway;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentDirectToWatercourse")]
        public IWebElement _chkCurrentDirectToWatercourse;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentRainWaterHarvesting")]
        public IWebElement _chkCurrentRainWaterHarvesting;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentOther")]
        public IWebElement _chkCurrentOther;
        #endregion

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkCurrentDirectToWatercourse")]
        public IWebElement _txtCurrentDirectToWatercourse;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtCurrentRainWaterHarvestingApproach")]
        public IWebElement _txtCurrentRainWaterHarvestingApproach;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtCurrentRainWaterHarvestingOtherInfo")]
        public IWebElement _txtCurrentRainWaterHarvestingOtherInfo;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtCurrentOtherSpecify")]
        public IWebElement _txtCurrentOtherSpecify;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostDevPreAttenuatedSurfaceWaterDischarge")]
        public IWebElement _txtnPostDevPreAttenuatedSurfaceWaterDischarge;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnPostDevAttenuatedSurfaceWaterDischarge")]
        public IWebElement _txtnPostDevAttenuatedSurfaceWaterDischarge;

        #region proposed check values
                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkProposedSurfaceWaterSewers")]
                public IWebElement _chkProposedSurfaceWaterSewers;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkProposedCombinedSewer")]
                public IWebElement _chkProposedCombinedSewer;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkProposedSoakAway")]
                public IWebElement _chkProposedSoakAway;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkProposedDirectToWatercourse")]
                public IWebElement _chkProposedDirectToWatercourse;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkProposedRainWaterHarvesting")]
                public IWebElement _chkProposedRainWaterHarvesting;

                [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkProposedOther")]
                public IWebElement _chkProposedOther;
        #endregion
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtProposedDirectToWatercourseSpecify")]
        public IWebElement _txtProposedDirectToWatercourseSpecify;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtProposedRainWaterHarvestingApproach")]
        public IWebElement _txtProposedRainWaterHarvestingApproach;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtProposedRainWaterHarvestingOtherInfo")]
        public IWebElement _txtProposedRainWaterHarvestingOtherInfo;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtProposedOtherSpecify")]
        public IWebElement _txtProposedOtherSpecify;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fluPlansCalculationsfile0")]
        public IWebElement _fluPlansCalculationsfile0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fluPlansCalculationsTextBox0")]
        public IWebElement _fluPlansCalculationsTextBox0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fluPlansCalculationsfile0")]
        public IWebElement _fileSelect;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fluPlansCalculationsclear0")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fluplanscalculationsclear0;
        #endregion

        #region Surface Water design

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkSUDSDetentionPond")] 
        public IWebElement _chkSudsDetentionPond;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkSUDSDetentionBasin")] 
        public IWebElement _chkSudsDetentionBasin;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkSUDSUndergroundStorage")] 
        public IWebElement _chkSudsundergroundStorage;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkSUDSInfiltrationTrench")] 
        public IWebElement _chkSudsInfiltrationTrench;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_chkSUDSOther")] 
        public IWebElement _chkSudsOther;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtSUDSOtherSpecify")] 
        public IWebElement _txtSudsOtherSpecify;
        #endregion

        #region Trade Effluent 
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblTradeEffluentDischarge_0")] 
        public IWebElement _radYesTradeEffluentDischarge;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_rblTradeEffluentDischarge_1")]
        public IWebElement _radNoTradeEffluentDischarge;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtaTradeEffluentDischargeDescription")]
        public IWebElement _txtDescription;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnProposedMaxDailyDischargeVolume")] 
        public IWebElement _txtProposedMaxDailyDischargeVolume;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtnProposedMaxDischargeRate")] 
        public IWebElement _txtProposedMaxDischargeRate;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtProposedPeriodOfDischarge")] 
        public IWebElement _txtProposedPeriodOfDischarge;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtaProposedTradeEffluentTreatment")]
        public IWebElement _txtEffluentTreatmentGiven;
        #endregion

        #region Special Requirements
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_txtaSpecialRequirements")]
        public IWebElement _txtSpecialRequirements;
        #endregion 

        #region Request for wholesale Technical Aspects Assistance
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_Button2_input")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_button2_input;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_Button2_ClientState")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_button2_clientstate;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_chkRequest")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview2_form1_chkrequest;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtCompanyName")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview2_form1_txtcompanyname;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtContactName")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview2_form1_txtcontactname;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtContactNumber")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview2_form1_txtcontactnumber;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_txtContactEmail")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview2_form1_txtcontactemail;
        #endregion

        #region Declarion
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView2_Form1_Button1_input")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview2_form1_button1_input;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_chkLocationPlan")] 
        public IWebElement _chklocationplan;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupLocationPlanFilefile0")] 
        public IWebElement _fuplocationplanfilefile0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupLocationPlanFileTextBox0")] 
        public IWebElement _fuplocationplanfiletextbox0;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupLocationPlanFileclear0")] 
        public IWebElement _fuplocationplanfileclear0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_chkDrawings")] 
        public IWebElement _chkdrawings;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupDrawingsFilefile0")] 
        public IWebElement _fupdrawingsfilefile0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupDrawingsFileTextBox0")] 
        public IWebElement _fupdrawingsfiletextbox0;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupDrawingsFileclear0")] 
        public IWebElement _fupdrawingsfileclear0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_chkCalculations")] 
        public IWebElement _chkcalculations;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupCalculationFilefile0")] 
        public IWebElement _fupcalculationfilefile0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupCalculationFileTextBox0")] 
        public IWebElement _fupcalculationfiletextbox0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_fupCalculationFileclear0")] 
        public IWebElement _fupcalculationfileclear0;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtSignature")] 
        public IWebElement _txtsignature;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_dtpDate")] 
        public IWebElement _ctl00_ctl03_fvlc_form1_fvsubview3_form1_dtpdate;
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtFullName")] 
        public IWebElement _txtfullname;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_txtRole")] 
        public IWebElement _txtrole;

        [FindsBy(How = How.Id, Using = "ctl00_ctl03_fvlc_Form1_fvSubView3_Form1_ctl14_input")] 
        public IWebElement _ctl14_input;
        #endregion

        public FormA01Page(ChromeDriver driver)
        {
            Driver = driver;
            InitialisePageElements();
            ScenarioContext.Current.Set<string>(Driver.Title.Substring(9,(Driver.Title.Length - 9)));
        }

        public void ClickProcessMateriallyComplete()
        {
            Driver.FindElementById("ctl00_ctl03_wftt26").Click();
        }

        public void ClickConfirmAgreementToDiaReport()
        {
            Driver.FindElementById("ctl00_ctl03_wftt21").Click();
        }

        public void WaitForPageToLoad()
        {
            var wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(60));
            //wait.Until(drv => drv.FindElement(By.Id("ctl00_ctl03_fvlc_Form1_fvSubView7_Form1_txtRetailerReference")).GetAttribute("value") != "");
        }

        private void InitialisePageElements()
        {
            while(Driver.Title == "")
            {
                System.Threading.Thread.Sleep(300);
            }
            PageFactory.InitElements(Driver, this);
        }

        public void AddDevelopmentDetails(DevelopmentDetails developmentDetails)
        {
            SelectTypeOfDevelopment(developmentDetails.TypeOfDevelopement);
            if (developmentDetails.TypeOfDevelopement == "Other")
            {
                ClearAndSendKeys(_txtDevelopmentTypeOther, developmentDetails.OtherType);
            }
            
            ClearAndSendKeys(_txtCommercialUnitsNo, developmentDetails.NumberOfCommercialUnits);
            ClearAndSendKeys(_txtIndustrialUnitsNo, developmentDetails.NumberOfIndustrialUnits);
            ClearAndSendKeys(_txtAreaOfSite, developmentDetails.SiteArea);
            _dateDevelopmentStartSate.SendKeys(DateTime.Now.ToString());
            ClearAndSendKeys(_txtPreviousWholesaleRef, developmentDetails.PreviousWholesaleRef);
            ClearAndSendKeys(_txtSiteName, developmentDetails.SiteName);
            ClearAndSendKeys(_txtSiteAddress, developmentDetails.SiteAddress);
            ClearAndSendKeys(_txtOrdnanceSurveyReferences, developmentDetails.OrdSurveyRef);
            ClearAndSendKeys(_txtLocation, developmentDetails.Location);
            ClearAndSendKeys(_txtPostcodeOutCode, developmentDetails.PostcodeOut);
            ClearAndSendKeys(_txtDeveloperName, developmentDetails.DevName);
            ClearAndSendKeys(_txtSiteContact, developmentDetails.SiteContactName);
            ClearAndSendKeys(_txtContactNumber, developmentDetails.ContactNumber);
            ClearAndSendKeys(_txtContactEmail, developmentDetails.ContactEmail);
        }

        public void AddPlanningInformationDetails(PlanningInformation planningInformation)
        {
            ClearAndSendKeys(_txtLocalAuthorityArea, planningInformation.LocalAuthority);

            var developmentIncluded = new Dictionary<string, IWebElement>();
            developmentIncluded.Add("Yes", _radDevelopmentIncluded);
            developmentIncluded.Add("No", _radDevelopmentNotIncluded);
            developmentIncluded[planningInformation.InTheCurrentLocalPlan].Click();

            var outlinePlanningPermission = new Dictionary<string, IWebElement>();
            outlinePlanningPermission.Add("Yes", _radNoOutlinePlanningPermission);
            outlinePlanningPermission.Add("No", _radNoOutlinePlanningPermission);
            outlinePlanningPermission[planningInformation.OutlinePlanning].Click();

            var detailedPlanningPermisison = new Dictionary<string, IWebElement>();
            detailedPlanningPermisison.Add("Yes", _radDetailedPlanningPermission);
            detailedPlanningPermisison.Add("No", _radNoDetailedPlanningPermission);
            detailedPlanningPermisison[planningInformation.DetailedPlanning].Click();

            _dateDetailedPlanningPermissionReceived.SendKeys(DateTime.Now.ToString());
            ClearAndSendKeys(_txtPlanningReference, planningInformation.PlanningReferenceNumber);
        }

        public void AddSiteServicingDetails(SiteServicing siteServicing)
        {
            var landType = new Dictionary<string, IWebElement>();
            landType.Add("Greenfield", _radLandTypeGreenfield);
            landType.Add("Brownfield", _radLandTypeBrownfield);

            landType[siteServicing.LandType].Click();
            ClearAndSendKeys(_txtPreviousUseOfSite, siteServicing.PreviousUseOfSite);
            _dateBuildingLastOccupied.SendKeys(DateTime.Now.ToString());
        }

        public void AddDevelopmentLevels(DevelopmentLevels developmentLevels)
        {
            var investgation = new Dictionary<string, IWebElement>();
            investgation.Add("Yes", _radInvestigationYes);
            investgation.Add("No", _radInvestigationNo);

            ClearAndSendKeys(_txtLowestGroundLevel, developmentLevels.LowestGroundLevel);
            ClearAndSendKeys(_txtLowestRoadLevel, developmentLevels.LowestRoadLevel);
            ClearAndSendKeys(_txtLowestFloorLevel, developmentLevels.LowesterFloorLevel);

            investgation[developmentLevels.QuoteForInvestigation].Click();
        }

        public void AddWaterDetails(WaterDetails waterDetails)
        {
            ClearAndSendKeys(_txtPreDevPeakWater, waterDetails.PreDevPeak);
            ClearAndSendKeys(_txtPreDevAverageWater, waterDetails.PreDevAverage);
            ClearAndSendKeys(_txtPostDevPeakWater, waterDetails.PostDevPeak);
            ClearAndSendKeys(_txtPostDevAverageWater, waterDetails.PostDevAverage);
            ClearAndSendKeys(_txtProposedHighestWaterFitting, waterDetails.HighestWaterFitting);
        }

        public void AddSewerageDetails(SewerageDetails sewerageDetails)
        {
            SelectPreWasteWaterDesign()[sewerageDetails.PreDevWasteWaterDesign].Click();
            ClearAndSendKeys(_txtPreQuantityOfSurfaceWaterTocombine, sewerageDetails.PreCombinedPartCombinedQuantity);
            ClearAndSendKeys(_txtPreDevPeakFoul, sewerageDetails.PreDevPeakDischarge);
            ClearAndSendKeys(_txtPreDevAverageFoul, sewerageDetails.PreDevAverageDischarge);
            SelectPostWasteWaterDesign()[sewerageDetails.PostDevWasteWaterDesign].Click();
            ClearAndSendKeys(_txtPostQuantityOfSurfaceWaterTocombine, sewerageDetails.PostCombinedPartCombinedQuantity);
            ClearAndSendKeys(_txtPostDevPeakFoul, sewerageDetails.PostDevPeakDischarge);
            ClearAndSendKeys(_txtPostDevAverageFoul, sewerageDetails.PostDevAverageDischarge);
        }

        public void AddSurfaceWaterDrainage(SurfaceWaterDrainage surfaceWaterDrainage)
        {
            ClearAndSendKeys(_txtPreDevSurfaceWaterDischarge, surfaceWaterDrainage.PreDevSurfaceWaterDischarge);
            SetCurrentSurfaceWaterDischarge(surfaceWaterDrainage.CurrentSWDischarge);
            ClearAndSendKeys(_txtCurrentDirectToWatercourse, surfaceWaterDrainage.DirectToWaterCourse);
            ClearAndSendKeys(_txtCurrentRainWaterHarvestingApproach, surfaceWaterDrainage.RainWater);
            ClearAndSendKeys(_txtCurrentRainWaterHarvestingOtherInfo, surfaceWaterDrainage.RelevantInfo);
            ClearAndSendKeys(_txtCurrentOtherSpecify, surfaceWaterDrainage.Other);
            ClearAndSendKeys(_txtnPostDevPreAttenuatedSurfaceWaterDischarge, surfaceWaterDrainage.PostDevPreAttSW);
            ClearAndSendKeys(_txtnPostDevAttenuatedSurfaceWaterDischarge, surfaceWaterDrainage.PostDevAttSW);

            SetProposedSurfaceWaterDischarge(surfaceWaterDrainage.ProposedDischargeSW);
            ClearAndSendKeys(_txtProposedDirectToWatercourseSpecify, surfaceWaterDrainage.SelectedDirect);
            ClearAndSendKeys(_txtProposedRainWaterHarvestingApproach, surfaceWaterDrainage.SelectedRainWater);
            ClearAndSendKeys(_txtProposedRainWaterHarvestingOtherInfo, surfaceWaterDrainage.RelevantInfo);
            ClearAndSendKeys(_txtProposedOtherSpecify, surfaceWaterDrainage.OOther);

            UploadDocument(surfaceWaterDrainage.Plans, _fileSelect);
        }

        public void AddSurfaceWaterDesign(SurfaceWaterDesign surfaceWaterDesign)
        {
            SetSudMeasures(surfaceWaterDesign.SudMeasures);
            ClearAndSendKeys(_txtSudsOtherSpecify, surfaceWaterDesign.Other);
        }

        public void AddTradeEffluent(TradeEffluent tradeEffluent)
        {
            var isThereTradeEffluent = new Dictionary<string, IWebElement>();
            isThereTradeEffluent.Add("Yes", _radYesTradeEffluentDischarge);
            isThereTradeEffluent.Add("No", _radNoTradeEffluentDischarge);

            isThereTradeEffluent[tradeEffluent.TradeEffluentDischarge].Click();
            ClearAndSendKeys(_txtDescription, tradeEffluent.Description);
            ClearAndSendKeys(_txtProposedMaxDailyDischargeVolume, tradeEffluent.ProposedDailyVolume);
            ClearAndSendKeys(_txtProposedMaxDischargeRate, tradeEffluent.ProposedDailyRate);
            ClearAndSendKeys(_txtProposedPeriodOfDischarge, tradeEffluent.PeriodOfDischarge);
            ClearAndSendKeys(_txtEffluentTreatmentGiven, tradeEffluent.Treatment);
        }

        public void AddSpecialRequirements(string specialRequirements)
        {
            ClearAndSendKeys(_txtSpecialRequirements, specialRequirements);
        }

        public void AddDeclaration(Retailer.Declaration declaration)
        {
            if (declaration.LocationPlan == string.Empty && declaration.Drawings ==string.Empty && declaration.Calculations == string.Empty)
            {
                var formF01Page = new FormF01Page(Driver);
                formF01Page.AddDeclaration(declaration);
            }
            else
            {
                if (declaration.LocationPlan != string.Empty)
                {
                    _chklocationplan.Click();
                    UploadDocument(declaration.LocationPlan, _fuplocationplanfilefile0);
                }
                if (declaration.Drawings != string.Empty)
                {
                    _chkdrawings.Click();
                    UploadDocument(declaration.Drawings, _fupdrawingsfilefile0);
                }
                if (declaration.Calculations != string.Empty)
                {
                    _chkcalculations.Click();
                    UploadDocument(declaration.Calculations, _fupcalculationfilefile0);
                }
            }
            ClearAndSendKeys(_txtrole, declaration.RoleInTheCompany);
        }

        private void SetSudMeasures(string sudMeasure)
        {
            var sudMeasures = new Dictionary<string, IWebElement>();
            sudMeasures.Add("Detention pond", _chkSudsDetentionPond);
            sudMeasures.Add("Detention basin", _chkSudsDetentionBasin);
            sudMeasures.Add("Underground storage", _chkSudsundergroundStorage);
            sudMeasures.Add("Infiltration trench", _chkSudsInfiltrationTrench);
            sudMeasures.Add("Other", _txtSudsOtherSpecify);

            if (sudMeasure != "All")
            {
                sudMeasures[sudMeasure].Click();
            }
            else
            {
                foreach (var item in sudMeasures)
                {
                    sudMeasures[item.Key].Click();
                }
                sudMeasures["Other"].Click();
            }
        }

        private void SetProposedSurfaceWaterDischarge(string proposedSWDischarge)
        {
            var proposedDischarge = new Dictionary<string, IWebElement>();
            proposedDischarge.Add("Surface Water sewers", _chkProposedSurfaceWaterSewers);
            proposedDischarge.Add("Combined Sewer", _chkProposedCombinedSewer);
            proposedDischarge.Add("Soak-away", _chkProposedSoakAway);
            proposedDischarge.Add("Direct to watercourse", _chkProposedDirectToWatercourse);
            proposedDischarge.Add("Rain water harvesting", _chkProposedRainWaterHarvesting);
            proposedDischarge.Add("Other", _chkProposedOther);

            if (proposedSWDischarge != "All")
            {
                proposedDischarge[proposedSWDischarge].Click();
            }
            else
            {
                foreach (var item in proposedDischarge)
                {
                    proposedDischarge[item.Key].Click();
                }
                proposedDischarge["Other"].Click();
            }
        }

        private void SetCurrentSurfaceWaterDischarge(string currentSWDischarge)
        {
            var currentDischarge = new Dictionary<string, IWebElement>();
            currentDischarge.Add("Surface Water sewers", _chkCurrentSurfaceWaterSewers);
            currentDischarge.Add("Combined Sewer", _chkCurrentCombinedSewer);
            currentDischarge.Add("Soak-away", _chkCurrentSoakAway);
            currentDischarge.Add("Direct to watercourse", _txtCurrentDirectToWatercourse);
            currentDischarge.Add("Rain water harvesting", _chkCurrentRainWaterHarvesting);
            currentDischarge.Add("Other", _chkCurrentOther);

            if (currentSWDischarge != "All")
            {
                currentDischarge[currentSWDischarge].Click();
            }
            else
            {
                foreach(var item in currentDischarge)
                {
                    currentDischarge[item.Key].Click();
                }
                currentDischarge["Other"].Click();
            }
        }

        private Dictionary<string, IWebElement> SelectPreWasteWaterDesign()
        {
            var preWasteWaterDesign = new Dictionary<string, IWebElement>();
            preWasteWaterDesign.Add("Totally separate Foul Sewage and Surface Water", _radPreSeparate);
            preWasteWaterDesign.Add("Combined", _radPreCombined);
            preWasteWaterDesign.Add("Partially Combined", _radPrePartiallyCombined);

            return preWasteWaterDesign;
        }

        private Dictionary<string, IWebElement> SelectPostWasteWaterDesign()
        {
            var postWasteWaterDesign = new Dictionary<string, IWebElement>();
            postWasteWaterDesign.Add("Totally separate Foul Sewage and Surface Water", _radPostSeparate);
            postWasteWaterDesign.Add("Combined", _radPostCombined);
            postWasteWaterDesign.Add("Partially Combined", _radPostPartiallyCombined);
            return postWasteWaterDesign;
        }

        private void SelectTypeOfDevelopment(string typeOfDevelopmemt)
        {
           var developmentTypes = new Dictionary<string,IWebElement>();

            developmentTypes.Add("Industrial", _radIndustrial);
            developmentTypes.Add("Commercial", _radCommercial);
            developmentTypes.Add("School", _radSchool);
            developmentTypes.Add("Hospital", _radHospital);
            developmentTypes.Add("Hotel", _radHotel);
            developmentTypes.Add("Other", _radOther);

            developmentTypes[typeOfDevelopmemt].Click();
        }
    }
}



