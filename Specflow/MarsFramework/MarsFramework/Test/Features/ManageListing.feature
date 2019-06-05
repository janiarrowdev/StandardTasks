Feature: ManageListing
	In order to manage the skill listing
	As a skill trader
	I want to share and update the skills in my listing

@mytag 
Scenario: Check if user could add a new skill
	Given I clicked on the share skill on the profile page
	When I save the skill details
	Then that skill should be displayed in my listing


Scenario: Check if user could cancel on a new skill
	Given I clicked on the share skill on the profile page
	When I cancel the skill details
	Then that skill should not be displayed in my listing

@mytag 
Scenario: Check if user could update an existing skill
	Given I clicked on the ManageListing tab
	When I update the selected skill in the listing
	Then that updated skill should be displayed in my listing

@mytag 
Scenario: Check if user could delete an existing skill
	Given I clicked on the ManageListing tab
	When I delete the selected skill in the listing
	Then that skill should not be displayed in my listing


Scenario: Check if user could deactivate an existing skill
	Given I clicked on the ManageListing tab
	When I deactivate the selected skill in the listing
	Then that skill should be displayed as deactivated in my listing


Scenario: Check if user could view an existing skill
	Given I clicked on the ManageListing tab
	When I click on the view skill in the listing
	Then that servicedetail page should be displayed