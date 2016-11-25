Feature: ProcessA1 Process A1 
sets out the operational arrangements where the Retailer wishes to make enquiries of the Wholesaler 
as to the provision of Water or Sewerage services for a proposed development or premises.

Scenario: I can create an instance of the Process A1
Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'A01 Pre application enquiries'
	And In the Retailer Details section I add the values
	| RetailerName  | RetailerID    | RetailersOwnReference    | ContactName | ContactNumber  | ContactEmail                |
	| SWWBS         | ret000000001  | retailerOwnRef          | contactName  | 071825728282   | colinmontgomery@swwbs.co.uk |
	And In the Developement Details section I add the values
	| TypeOfDevelopement | OtherType | NumberOfCommercialUnits | NumberOfIndustrialUnits | SiteArea | StartDate	  | PreviousWholesaleRef | SiteName   | SiteAddress | OrdSurveyRef | Location | PostcodeOut | DevName   | SiteContactName | ContactNumber | ContactEmail      |
	| Industrial         |           | 1                       | 2                       | 5        | 20/10/2016  | previous reference   | build Site | 10 the road | 1234567890   | Cornwall | TR          | developer | site contact    | 01326272390   | contact@email.com |
	And In the Planning Information section I add the values
	| LocalAuthority | InTheCurrentLocalPlan | OutlinePlanning | DetailedPlanning | DetailedPlanningDate | PlanningReferenceNumber |
	| East Devon     | Yes                   | Yes             | Yes              | 20/10/2016           | 90001                   |
	And In the Site Servicing Details section I add the values
	| LandType   | PreviousUseOfSite | DateLastOccupied |
	| Greenfield | domestic          | 10/01/2016       |
	And In the Development Levels section I add the values
	| LowestGroundLevel | LowestRoadLevel | LowesterFloorLevel | QuoteForInvestigation |
	| 1                 | 2               | 2                  | Yes                   | 
	And In the Water Details section I add the details
	| PreDevPeak | PreDevAverage | PostDevPeak | PostDevAverage | HighestWaterFitting |
	| 200        | 150           | 250         | 225            | 3                   |
	And In the Sewerage Details section I add the details
	| PreDevWasteWaterDesign                         | PreCombinedPartCombinedQuantity | PreDevPeakDischarge | PreDevAverageDischarge | PostDevWasteWaterDesign | PostCombinedPartCombinedQuantity | PostDevPeakDischarge | PostDevAverageDischarge |
	| Totally separate Foul Sewage and Surface Water |                                 | 200                 | 100                    | Combined                | 200                              | 300                  | 267                     |
	And In the Surface Water Drainage section I add the details
	| PreDevSurfaceWaterDischarge | CurrentSWDischarge   | DirectToWaterCourse | RainWater | Other | PostDevPreAttSW | PostDevAttSW | ProposedDischargeSW | SelectedDirect | SelectedRainWater | RelevantInfo | OOther | Plans		   |
	| 100                         | All					 |                     |           |       | 200             | 300          | Soak-away           |                |                   |              |        | processa1.txt |
	And In the Surface Water Design section I add the details
	| SudMeasures         | Other |
	| Underground storage |       |
	And In the Trade Effluent section I add the details
	| TradeEffluentDischarge | Description                | ProposedDailyVolume | ProposedDailyRate | PeriodOfDischarge | Treatment |
	| Yes                    | trade effluent description | 200000              | 200               | 10                | chemical  |
	And In the Special Requirements sections I enter
	| SpecialRequirementDetails                |
	| special requirements for the application |
	And In the Process A Declaration section I enter
	| LocationPlan     | Drawings     | Calculations     | SupportingDocs | Signature | Date | FullName | RoleInTheCompany |
	| locationPlan     | drawings     | calculations     | supportingDocs |           | now  |          | tester           |
	When I click the 'Save & Submit' button 
	Then 'Your data was successfully submitted.' message is displayed to the user
	And I choose the 'Processes' link in the left hand menu
	And I select 'A. New Connections' and sub process 'A01 Pre-Application enquiry in relation to a new connection or connections' 
	And the submitted process can be seen in the processes I started list

Scenario: Retailer Name and Retailer Id are prepopulated
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	When I select create a new instance of process 'A01 Pre application enquiries'
	Then the retailer name field and retailer id field are not empty

Scenario: A wholesaler can reject a A1 process from a retailer
    Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'A01 Pre application enquiries'
	And I have added valid data to all sections of the Process A1 form
    And I click the 'Save & Submit' button 
	And 'Your data was successfully submitted.' message is displayed to the user
	And I log in as a wholesaler
	And I choose the 'Processes' link in the left hand menu
	And I select 'A. New Connections' and sub process 'A01 Pre-Application enquiry in relation to a new connection or connections' 
	And I open the process
	And I expand the left hand column
	And I click on the WSD link to progress the process
	And As a WSD user I reject the process and add the reason 'unknown contact is the reason'
	When As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been rejected
	And the rejection reason is 'unknown contact is the reason'

Scenario Outline: A wholesaler can reject a A1 process from a retailer using all reasons where the process can continue
	Given a retailer has created a Process A1 request
	When a wholesaler rejects the process instance with reason 'unknown contact is the reason' and '<rejectType>'
	And As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been rejected
	And the rejection reason is 'unknown contact is the reason'

	Examples: 
	| rejectType                                 |
	| Incomplete form (Reject)                   |
	| Further clarification required (Reject)    |
	| Other - refer to explanatory text (Reject) |

Scenario Outline: A wholesaler can reject a A1 process from a retailer using all reasons where the process ends
	Given a retailer has created a Process A1 request
	When a wholesaler rejects the process instance with reason 'unknown contact is the reason' and '<rejectType>'
	And As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been closed

	Examples: 
	| rejectType                                 |
	| Incorrect form used (Reject)               |
	| Wrong wholesaler (Reject)                  |

Scenario: Developer Services deem sufficient capacity to service the Process A1 request
	Given a retailer has created a Process A1 request
	And a wholesaler accepts the process
	And As a WSD I click the 'Save & Submit' button
	And i log in as a Developer Services user
	And I choose the 'Processes' link in the left hand menu
	And I select 'A. New Connections' and sub process 'A01 Pre-Application enquiry in relation to a new connection or connections' 
	And I open the process
	And I expand the left hand column
	And I Click the Make initial Response user
	When i select 'Sufficient capacity' as an initial response 
	And I click the 'Save & Submit' button
	And I am logged in as a SWWBS user 
	And I choose the 'Processes' link in the left hand menu
	And I select 'A. New Connections' and sub process 'A01 Pre-Application enquiry in relation to a new connection or connections' 
	And I open the process
	And I expand the left hand column
	And I click on the notify sufficient capacity node
	Then the retailer will receive notification of completion
	| to               | from								| subject										| message                       |
	| 	Gary GIBBONS   | Sequence New Connections User 2    | Notification: Service Request Complete        | Your Service Request			|

Scenario: Developer Services deem that a DIA pre development report is required
   Given a retailer has created a Process A1 request
   When the process is accepted and developer services ask for 'DIA/Pre-development report required'
   And the retailer opens the process
   Then the text 'DIA/Pre-development report required' is displayed

Scenario: Developer Services deem that further information is required
   Given a retailer has created a Process A1 request
   When the process is accepted and developer services ask for 'Further information required' 
   And the retailer opens the process
   Then the text 'Further information required' is displayed

Scenario: A retailer re-submits form A1 and developer services deem it materially complete
   Given a retailer has created a Process A1 request
   And the process is accepted and developer services ask for 'DIA/Pre-development report required'
   And the retailer opens the process
   When the retailer resubmits the form A1
   And developer services deem it materially complete
   Then the retailer must review proposed DIA/Pre-development details

