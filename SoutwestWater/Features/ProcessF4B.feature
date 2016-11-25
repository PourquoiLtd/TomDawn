Feature: ProcessF4B
	In order to start the Open Water Process F4b
	As a SWWBS user 
	I want to be able to create a service request  

Scenario: A new service request can be created
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'F04B NHH customer enquiries received by Retailer'
	And In the Retailer Details section I add the values
	| RetailerName  | RetailerID    | RetailersOwnReference    | ContactName | ContactNumber | ContactEmail              |
	| SWWBS         | ret000000001  | retailerOwnRef          | contactName  | 071825728282   | colinmontgomery@swwbs.co.uk |
	And In the Eligible Premise Details section I add the values
	| SPID          | BuildingNumber | BuildingName | AddressLine1 | AddressLine2 | AddressLine3 | Town   | Postcode |
	| 1000000019S21 | 40              | BuildingName  | add 1          | add2           | add 3          | London | BA12 6JH |
	And In the Drinking water enquiries or concerns section I select 'Request for information about fluoride levels'
	And In the Details Of Enquiry section I enter the text below
	| DetailsOfEnquiry                                                             |
	| These are the details of enquiry that I want to enter into the text area box | 
	And In the Consent to Contact the Non Household Customer section I add
	| GiveConsent | ContactName  | ContactNumber  | NotifiedOfVisitDate |
	| Yes         | contact name | 07822828282    | Yes                 |
	And In the Declaration section I enter
	| Signature | Date | FullName       | RoleInTheCompany |
	| signature | now  | gary t gibbons | tester              |
	When I click the 'Submit' button 
	Then 'Your data was successfully submitted.' message is displayed to the user
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	And the submitted process can be seen in the processes I started list

Scenario: I can create a service request for all Process F4 enquiry Types
    Given I have added valid data to all sections of the Process F4 form
	When In the Drinking water enquiries or concerns section I select all checkbox options
	And I click the 'Submit' button 
	Then 'Your data was successfully submitted.' message is displayed to the user
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer'
	And the submitted process can be seen in the processes I started list

Scenario: A wholsaler can accept a F4b process submission from a retailer and complete the process
    Given I have added valid data to all sections of the Process F4 form
	And In the Drinking water enquiries or concerns section I select 'Request for information about fluoride levels'
	And I click the 'Submit' button
	And 'Your data was successfully submitted.' message is displayed to the user	
	And I log in as a wholesaler
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	And I open the process
	And I expand the left hand column
	And I click on the WSD link to progress the process
	And As a WSD user I accept the process
	And As a WSD I click the 'Save & Submit' button
	When I enter an answer to the retailer and submit
	| AnswerToEnquiry               |
	| your query has been addressed |
	And I go to the retailer notification page
	Then the retailer will receive notification of completion
	| to                           | from                   | subject										| message                       |
	| 	Gary GIBBONS               | Sequence WSD User 2	| Notification: Service Request Complete      | Your Service Request			|
									
Scenario: A wholesaler can reject a F4b process from a retailer
    Given I have added valid data to all sections of the Process F4 form
    And In the Drinking water enquiries or concerns section I select 'Request for information about fluoride levels'
	And I click the 'Submit' button
	And 'Your data was successfully submitted.' message is displayed to the user
	And I log in as a wholesaler
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	And I open the process
	And I expand the left hand column
	And I click on the WSD link to progress the process
	And As a WSD user I reject the process and add the reason 'unknown contact is the reason'
	When As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been rejected
	And the rejection reason is 'unknown contact is the reason''f4'

Scenario Outline: A wholesaler can reject a F4 process from a retailer using all reasons where the process can continue
	Given I have added valid data to all sections of the Process F4 form
    And In the Drinking water enquiries or concerns section I select 'Request for information about fluoride levels'
	And I click the 'Submit' button
	And I log in as a wholesaler
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	And I open the process
	And I expand the left hand column
	And I click on the WSD link to progress the process
	When a wholesaler rejects the process instance with reason 'unknown contact is the reason' and '<rejectType>'
	And As a WSD I click the 'Save & Submit' button
	Then An Update Service Request item is created informing the retailer group that the process has been rejected
	And the rejection reason is 'unknown contact is the reason'

	Examples: 
	| rejectType                                 | page |
	| Incomplete form (Reject)                   |   f4   |
	| Further clarification required (Reject)    |    f4  |
	| Other - refer to explanatory text (Reject) |    f4  |

Scenario: A reject reason must be added in order for a wholesaler to reject a F4b process
    Given I have added valid data to all sections of the Process F4 form
    And In the Drinking water enquiries or concerns section I select 'Request for information about fluoride levels'
	And I click the 'Submit' button
	And 'Your data was successfully submitted.' message is displayed to the user
	And I log in as a wholesaler
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	And I open the process
	And I expand the left hand column
	And I click on the WSD link to progress the process
	And As a WSD user I reject the process and fail to add a reason
	When As a WSD I click the 'Save & Submit' button
	Then an the verify request error messages is relayed to the user
	 | errormessage                      | page      |
	 | Reject Reason is a Required Field | wholesale |
	                      
Scenario: Validation messages are relayed to the user when they omit mandatory information from the F/01 form.
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'F04B NHH customer enquiries received by Retailer'
	And In the Declaration section I enter
	| Signature | Date | FullName       | RoleInTheCompany    |
	|			|      |                |                     |
	When I click the 'Submit' button 
    Then an the error messages below are relayed to the user
	 | errormessage                                 | page     |
	 | Retailer's Own Reference is a Required Field | retailer |
	 | Contact Name is a Required Field             | retailer |
	 | Contact Number is a Required Field           | retailer |
	 | Contact E-mail is a Required Field           | retailer |
	 | SPID is a Required Field                     | retailer |
	 | Address Line 1 is a Required Field           | retailer |
	 | Town is a Required Field                     | retailer |
	 | Postcode is a Required Field                 | retailer |
	 | Details of Enquiry is a Required Field       | retailer |
	 | Role in the Company or Job Title is a Required Field |  retailer |

Scenario Outline: SPID verification
Given I am logged in as a SWWBS user 
And I choose the 'Start Process' link in the left hand menu
And I select create a new instance of process 'F04B NHH customer enquiries received by Retailer'
When I add an invalid '<SPID value>'
And I click the 'Submit' button 
Then The Invalid SPID error message is desplayed to the user

Examples:
| SPID value      |
| dsjndjwwj       |
| 1000000019S2G   |
| 1000000019S2112 |

Scenario: An incomplete process is saved
Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	And I select create a new instance of process 'F04B NHH customer enquiries received by Retailer'
	And In the Retailer Details section I add the values
	| RetailerName  | RetailerID    | RetailersOwnReference    | ContactName | ContactNumber | ContactEmail                 |
	| SWWBS         | ret100000001  | retailerOwnRef          | contactName  | 07816262525   | winner@swwbs.co.uk		    |
	And I click the 'Save All' button 
	And I close the form window
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	When I open the process
	Then the Retailer Details values have been saved
	| RetailerName  | RetailerID    | RetailersOwnReference   | ContactName  | ContactNumber | ContactEmail                 |
	| SWWBS         | ret100000001  | retailerOwnRef          | contactName  | 07816262525   | winner@swwbs.co.uk			|

Scenario: As a retailer i can cancel a request 
Given I have added valid data to all sections of the Process F4 form
	And In the Drinking water enquiries or concerns section I select 'Request for information about fluoride levels'
	And I click the 'Submit' button
	And 'Your data was successfully submitted.' message is displayed to the user
	And I choose the 'Processes' link in the left hand menu
	And I select 'F. Monitoring' and sub process 'F04B NHH customer enquiries received by Retailer' 
	And I open the process
	And I expand the left hand column
	And I click the Cancel Request option in the left hand column
	When I select the yes cancel radio button
	And I enter the reason 'This is the reason for cancelling 'cancel reason'
	And I click submit
	Then the request will be cancelled

Scenario: Retailer Name and Retailer Id are prepopulated
	Given I am logged in as a SWWBS user 
	And I choose the 'Start Process' link in the left hand menu
	When I select create a new instance of process 'F04B NHH customer enquiries received by Retailer'
	Then the retailer name field and retailer id field are not empty




	

	