Feature: UpdateProfile_Certification
	In order to update my profile 
	As a skill trader
	I want to add the certifications that I achieved

Scenario: Check if user could able to add a certification 
	Given I clicked on the Certifications tab under Profile page
	When I add a new certification
	Then that new certification should be displayed on my listings

Scenario: Check if user could update an existing certification 
	Given I clicked on the Certifications tab under Profile page
	When I edit the certification name
	Then the updated certification name should be displayed on my listings

 
Scenario: Check if user could update the level of a certification 
	Given I clicked on the Certifications tab under Profile page
	When I edit the level of the certification
	Then the updated certification level should be displayed on my listings

 
Scenario: Check if user could remove existing certification from the listing
	Given I clicked on the Certifications tab under Profile page
	When I delete an existing certification
	Then that certification should be removed on my listings

 
Scenario: Check if user could add the same certification more than once
	Given I clicked on the Certifications tab under Profile page
	When I add same certification twice
	Then duplicated certification record should not be in the listing
	
 
Scenario: Check if user could duplicate the certification when updating
	Given I clicked on the Certifications tab under Profile page
	And I have two or more certification in my listing
	When I update a certification to an exisitng certification in the listing
	Then modified duplicated certification record should not be in the listing

 
Scenario: Check if user could add a certification without certification name
	Given I clicked on the Certifications tab under Profile page
	When I add a certification without certification name
	Then that certification without name should not be in the listing
	
 
Scenario: Check if user could add a certification without giving certified from
	Given I clicked on the Certifications tab under Profile page
	When I add certification without giving certified from details
	Then the record without certified from should not be in the listing

 
Scenario: Check if user could add a certification without the year of the certification
	Given I clicked on the Certifications tab under Profile page
	When I add certification without certification year
	Then the record without year should not be in the listing

 
Scenario: Check if user could add a certification name by inputing empty spaces
	Given I clicked on the Certifications tab under Profile page
	When I add a certification name with empty space
	Then that record with empty certification name should not be in the listing

 
Scenario: Check if user could add a certification with certified from by inputing empty spaces
	Given I clicked on the Certifications tab under Profile page
	When I add a certified from with empty space
	Then that record with empty certified from should not be in the listing