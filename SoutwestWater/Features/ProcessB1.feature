Feature: ProcessB1
	In order start the installation of a new meter
	As a Retailer 
	I want to be be able to complete the Open Water Process B/01  Form


Scenario: A new B1 service request can be created
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'B01 Meter installation'
	And In the Retailer Details section I add the values
	| RetailerName  | RetailerID    | RetailersOwnReference    | ContactName | ContactNumber | ContactEmail				   |
	| SWWBS         | ret000000001  | retailerOwnRef          | contactName  | 071825728282  | colinmontgomery@swwbs.co.uk |
	And In the B Eligible Premise Details section I add the values
	| SPID          | BuildingNumber | BuildingName | AddressLine1 | AddressLine2 | AddressLine3 | Town   | Postcode | customerBannerName |
	| 1000000019S21 | 40             | BuildingName | add 1        | add2         | add 3        | London | BA12 6JH | banner Name        |
	And In the Meter Installation section I add the values
	| PhysicalSize | Other | Model    | MeterMenuReference | LocationOfMeter | LocationDescription         | AdditionInformation |
	| 20mm         |       | Standard | mmReference        | Inside building | description of the location | Additonal details   |  
	And In the Declaration section I enter
	| Signature | Date | FullName       | RoleInTheCompany |
	| signature | now  | gary t gibbons | tester              |
	When I click the 'Submit' button
	Then 'Your data was successfully submitted.' message is displayed to the user
	And I choose the 'Processes' link in the left hand menu
	And I select 'B. Metering' and sub process 'B01 Installation of a meter performed by the Wholesaler' 
	And the submitted process can be seen in the processes I started list

Scenario: Retailer Name and Retailer Id are prepopulated
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	When I select create a new instance of process 'B01 Meter installation'
	Then the retailer name field and retailer id field are not empty

Scenario Outline: A wholesaler can reject a B1 process from a retailer using all reasons where the process can continue
	Given a retailer has created a Process B1 request
	When a wholesaler rejects the process instance with reason 'unknown contact is the reason' and '<rejectType>'
	And As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been rejected
	And the rejection reason is 'unknown contact is the reason' 'Page'

	Examples: 
	| rejectType                                 | page |
	| Incomplete form (Reject)                   |      |
	| Further clarification required (Reject)    |      |
	| Other - refer to explanatory text (Reject) |      |

Scenario Outline: A wholesaler can reject a B3 process from a retailer using all reasons where the process ends
	Given a retailer has created Process B request 'B01 Meter installation'
	When a wholesaler rejects the process instance with reason 'unknown contact is the reason' and '<rejectType>'
	And As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been closed

	Examples: 
	| rejectType                                 |
	| Incorrect form used (Reject)               |
	| Wrong wholesaler (Reject)                  |