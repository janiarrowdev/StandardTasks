Feature: UpdateProfile_Education
	In order to update my profile 
	As a skill trader
	I want to add the education background

Scenario: Check if user could able to add a new education 
	Given I clicked on the Education tab under Profile page
	When I add a new education
	Then that new education should be displayed on my listings


Scenario: Check if user could update the degree name of an existing record 
	Given I clicked on the Education tab under Profile page
	When I edit the degree name
	Then the updated degree name should be displayed on my listings


Scenario: Check if user could update the college name of an existing record 
	Given I clicked on the Education tab under Profile page
	When I edit the college name
	Then the updated college name should be displayed on my listings


Scenario: Check if user could update the title of the degree
	Given I clicked on the Education tab under Profile page
	When I edit the title of the degree
	Then the updated title of the degree should be displayed on my listings


Scenario: Check if user could update the country of the degree
	Given I clicked on the Education tab under Profile page
	When I edit the country of the degree
	Then the updated country of the degree should be displayed on my listings


Scenario: Check if user could update the year of the degree
	Given I clicked on the Education tab under Profile page
	When I edit the year of the degree
	Then the updated year of the degree should be displayed on my listings


Scenario: Check if user could remove existing education from the listing
	Given I clicked on the Education tab under Profile page
	When I delete an existing education
	Then that education should be removed on my listings


Scenario: Check if user could add the same education more than once
	Given I clicked on the Education tab under Profile page
	When I add same education twice
	Then duplicated education record should not be in the listing
	

Scenario: Check if user could duplicate the education when updating
	Given I clicked on the Education tab under Profile page
	And I have two or more education in my listing
	When I update a education to an exisitng education in the listing
	Then modified duplicated education record should not be in the listing


Scenario: Check if user could add a education with no college name
	Given I clicked on the Education tab under Profile page
	When I add a education without college name
	Then that education without college name should not be in the listing
	

Scenario: Check if user could add a education with no title of the degree
	Given I clicked on the Education tab under Profile page
	When I add a education without title of the degree
	Then that education without title of the degree should not be in the listing


Scenario: Check if user could add a education with no degree name
	Given I clicked on the Education tab under Profile page
	When I add a education without degree name
	Then that education without degree name should not be in the listing


Scenario: Check if user could add a education with no country of the degree
	Given I clicked on the Education tab under Profile page
	When I add a education without country of the degree
	Then that education without country of the degree should not be in the listing


Scenario: Check if user could add a education with no year of graduation
	Given I clicked on the Education tab under Profile page
	When I add a education without year of graduation
	Then that education without year of graduation should not be in the listing
