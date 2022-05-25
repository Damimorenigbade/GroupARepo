Feature: DataWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Parameterization
	Given I navigate to the "https://angularjs.realworld.io/#/"
	And I click on sign up 
	And I enter my name "Tommy"
	And I enter my emailaddress "Tommy"
	And I enter my password "tomi12"
	When I click on the sign button
	Then I should be able to sign up successfully