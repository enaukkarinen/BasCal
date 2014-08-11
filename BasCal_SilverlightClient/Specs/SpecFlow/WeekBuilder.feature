Feature: WeekBuilder
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Get events for a specified month
	Given I have given a valid "month" and a "collection of events"
	When I have given a valid month
	Then I should get a see month filled with events
