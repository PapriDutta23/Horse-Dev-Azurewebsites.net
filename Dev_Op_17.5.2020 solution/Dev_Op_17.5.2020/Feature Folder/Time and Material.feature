Feature: Time and Material
	As a Turn Up portal Admin 
	I would like to manage Time and material record effctively
@mytag

Scenario:create a new record in time and material
Given I have logged in the Turn Up successfully
And I navigate to time and material page
When I create a new time and material 
Then The record should be created successfully 

 Scenario:create multiple new records time and material 
Given I have logged in the Turn Up successfully
And I navigate to time and material page
When I create multiple time and material recodrs with below <codes> , <description>
Then The record should be created successfully 
Examples: 
| code   | description |
| IC     | WISE        |
| Sydney | Made        |


Scenario:user can successfully edit the record
Given I have logged in the Turn Up successfully
And I navigate to time and material page
When I have edited the new record
Then The record should be edited successfully 

Scenario: user can successfully delete the record
Given I have logged in the Turn Up successfully
And I navigate to time and material page
When I go the record which I want to delete
Then The record should be deleted successfully 




