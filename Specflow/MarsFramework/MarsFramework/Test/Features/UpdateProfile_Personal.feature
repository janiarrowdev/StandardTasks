Feature: UpdateProfile_Personal
	In order to update my profile 
	As a skill trader
	I want to add the personal details

Scenario: Check if user could able to edit the display name
	Given I clicked on the arrow next to Display Name in Profile page
	When I change the First Name and last Name
	Then that modified name should be displayed in my profile page

@mytag
Scenario: Check if user could able to edit the Availability
	Given I clicked on the edit button in Availability
	When I change the Availability
	Then that changed Availability should be displayed in my profile page

@mytag
Scenario: Check if user could able to edit Hours
	Given I clicked on the edit button in Hours
	When I change the Hours
	Then that changed Hours should be displayed in my profile page

@mytag
Scenario: Check if user could able to edit the Earn Target
	Given I clicked on the edit button in Earn Target
	When I change the Earn Target
	Then that modified Earn Target should be displayed in my profile page


Scenario: Check if user could able to add a description
	Given I clicked on the edit description button in Profile page
	When I add a description
	Then that description should be displayed in my profile page

Scenario: Check if user could able to add a description more than 600 Characters
	Given I clicked on the edit description button in Profile page
	When I add a description with more than 600 characters
	Then the description only with 600 characters should be displayed in my profile page
