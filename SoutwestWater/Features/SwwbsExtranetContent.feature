Feature: Southwest Water Business Services Extranet Home Page content is correct
In order to create / manage / maintain and view service request
	As a SWWBS user 
	I want to the extranet page to display and expose the functionality in order to achieve this  

Scenario: Inbox Header displays the corect values
Given I am logged in as a SWWBS user 
When I choose the 'Inbox' link in the left hand menu
Then the header bar displays the following 
| InboxText   | TaskDueText     | OverDueText   |
| Inbox Items | Tasks Due Today | Overdue Tasks | 


Scenario Outline: Side bar navigational links are displayed
Given I am logged in as a SWWBS user 
When I choose the '<page>' link in the left hand menu
Then the left side bar link details are
| linkText		| url													|
| Inbox         | http://wsddev.swwater.co.uk/Pages/Inbox.aspx			|
| Processes     | http://wsddev.swwater.co.uk/Pages/Processes.aspx		|
| Start Process | http://wsddev.swwater.co.uk/Pages/StartProcess.aspx	|  

Examples: 
| page          | 
| Inbox         | 
| Processes     |
| Start Process |    








