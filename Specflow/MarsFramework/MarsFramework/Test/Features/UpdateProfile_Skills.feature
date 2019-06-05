Feature: UpdateProfile_Skill
	In order to update my profile 
	As a skill trader
	I want to add the Skill that I have gained

Scenario: Check if user could able to add a new skill 
	Given I clicked on the Skills tab under Profile page
	When I add a new skill
	Then that new skill should be displayed on my listings

Scenario: Check if user could update an existing skill 
	Given I clicked on the Skills tab under Profile page
	When I edit the Skill name
	Then the updated Skill name should be displayed on my listings

Scenario: Check if user could update the level of a Skill 
	Given I clicked on the Skills tab under Profile page
	When I edit the level of the Skill
	Then the updated skill level should be displayed on my listings

Scenario: Check if user could remove existing Skill from the listing
	Given I clicked on the Skills tab under Profile page
	When I delete an existing Skill
	Then that Skill should be removed on my listings

Scenario: Check if user could add the same Skill more than once
	Given I clicked on the Skills tab under Profile page
	When I add same Skill twice
	Then duplicated skill record should not be in the listing

Scenario: Check if user could duplicate the Skill when updating
	Given I clicked on the Skills tab under Profile page
	And I have two or more Skill in my listing
	When I update a Skill to an exisitng Skill in the listing
	Then modified duplicated skill record should not be in the listing

Scenario: Check if user could add a Skill without giving the level
	Given I clicked on the Skills tab under Profile page
	When I add a Skill without giving the Skill level
	Then that skill without level should not be in the listing

Scenario: Check if user could add a Skill without giving Skill name
	Given I clicked on the Skills tab under Profile page
	When I select the Skill level without giving a Skill name
	Then the record without skill name should not be in the listing

Scenario: Check if user could add a Skill by inputing empty spaces
	Given I clicked on the Skills tab under Profile page
	When I add a Skill entering empty space
	Then that record with empty skill name should not be in the listing