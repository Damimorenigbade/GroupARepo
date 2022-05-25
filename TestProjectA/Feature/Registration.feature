Feature: Registration
	customer should be able to sign up on this website https://angularjs.realworld.io/#/

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sign up 
	And I enter my username
	And I enter my emailaddress
	And I enter my password
	When I click on the sign button
	Then I should be able to sign up successfully