Feature: Search

A short summary of the feature

@tag1
Scenario: Verify that the user is able to search for valid item
	Given The user is navigated to the "http://www.automationpractice.pl/index.php"
	When The user enter "Printed Dress" and clicks on the search button
	Then The search result should contain the searched item "Printed Dress"