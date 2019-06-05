Feature: SignIn
	In order to use the features of the software
	As a skill trader
	I want to sign in with a login

@mytag 
Scenario: Check if user could able to sign in 
	Given I clicked on the Sign In button on home page
	When I add Username and Password
	Then it should redirect to profile page

Scenario: Check if user could retrieve password by forget password
	Given I clicked on the Sign In button on home page
	And I click on forgot password
	When I request to send verification email 
	Then the success message box should appear in the right top corner

@mytag 
Scenario: Check if user could create a new user account
	Given I clicked on the Join button on home page
	When I fill up the registration details and join
	Then it should redirect to the profile page

Scenario: Check if user could view TOC
	Given I clicked on the Join button on home page
	When I click on terms and conditions
	Then it should redirect to TOC page
