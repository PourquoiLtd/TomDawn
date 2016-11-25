Feature: ProcessB3

Scenario: Retailer Name and Retailer Id are prepopulated
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	When I select create a new instance of process 'B03 Meter accuracy test performed by the Wholesaler'
	Then the retailer name field and retailer id field are not empty

Scenario: A new B3 service request can be created
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'B03 Meter accuracy test performed by the Wholesaler'
	And In the Retailer Details section I add the values
	| RetailerName  | RetailerID    | RetailersOwnReference    | ContactName | ContactNumber | ContactEmail				   |
	| SWWBS         | ret000000001  | retailerOwnRef          | contactName  | 071825728282  | colinmontgomery@swwbs.co.uk |
	And In the B Eligible Premise Details section I add the values
	| SPID          | BuildingNumber | BuildingName | AddressLine1 | AddressLine2 | AddressLine3 | Town   | Postcode | customerBannerName |
	| 1000000019S21 | 40             | BuildingName | add 1        | add2         | add 3        | London | BA12 6JH | banner Name        |
	And In the Declaration section I enter
	| Signature | Date | FullName       | RoleInTheCompany |
	| signature | now  | gary t gibbons | tester              |
	When I click the 'Submit' button
	Then 'Your data was successfully submitted.' message is displayed to the user
	And I choose the 'Processes' link in the left hand menu
	And I select 'B. Metering' and sub process 'B03 Meter accuracy test performed by the Wholesaler' 
	And the submitted process can be seen in the processes I started list

Scenario Outline: A wholesaler can reject a B3 process from a retailer using all reasons where the process can continue
	Given a retailer has created Process B request 'B03 Meter accuracy test performed by the Wholesaler'
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
	Given a retailer has created Process B request 'B03 Meter accuracy test performed by the Wholesaler'
	When a wholesaler rejects the process instance with reason 'unknown contact is the reason' and '<rejectType>'
	And As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been closed

	Examples: 
	| rejectType                                 |
	| Incorrect form used (Reject)               |
	| Wrong wholesaler (Reject)                  |

Scenario: A retailer initiated Process B3 is Accepted and processed by the Wholesaler
	Given a retailer has created Process B request 'B03 Meter accuracy test performed by the Wholesaler'
	And the wholesaler accepts the process
	And As a WSD I click the 'Save & Submit' button
	When the wholesaler Record outcome
	Then the retailer is notified that the process is complete
