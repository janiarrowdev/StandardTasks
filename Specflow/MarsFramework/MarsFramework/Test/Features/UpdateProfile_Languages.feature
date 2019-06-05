Feature: UpdateProfile_Languages
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

@mytag
Scenario: Check if user could update an existing language 
	Given I clicked on the Language tab under Profile page
	When I edit the language 
	Then the updated language should be displayed on my listings

@mytag
Scenario: Check if user could update the level of a language 
	Given I clicked on the Language tab under Profile page
	When I edit the level on the language
	Then the updated level should be displayed on my listings

@mytag
Scenario: Check if user could remove existing language from the listing
	Given I clicked on the Language tab under Profile page
	When I delete an existing language
	Then that language should be removed on my listings

@mytag 
Scenario: Check if user could add more than 4 languages
	Given I clicked on the Language tab under Profile page
	When I add four new languages
	Then I should not be able to add more languages

Scenario: Check if user could add the same language more than once
	Given I clicked on the Language tab under Profile page
	When I add same language twice
	Then duplicate record should not be in the listing

Scenario: Check if user could duplicate the languages when updating
	Given I clicked on the Language tab under Profile page
	And I have two or more languages in my listing
	When I update a language to an exisitng language in the listing
	Then modified duplicate record should not be in the listing

@mytag
Scenario: Check if user could add a language without giving the level
	Given I clicked on the Language tab under Profile page
	When I add a language without giving the language level
	Then the record should not be in the listing

@mytag
Scenario: Check if user could add a language without giving the language name
	Given I clicked on the Language tab under Profile page
	When I select the language level without giving a language name
	Then the record should not be in the listing

@mytag
Scenario: Check if user could add a language by inputing empty spaces
	Given I clicked on the Language tab under Profile page
	When I add a language entering empty space
	Then the record should not be in the listing