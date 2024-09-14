Feature: LoginFeature



Scenario: Verify that the user is able to login to the AutomationPractive application
	Given The user is navigated to the "http://www.automationpractice.pl/index.php"
	When The user clicks the Sign in button
	Then The "Authentication" page appears
	When The user enters valid username "dejanovski_a@yahoo.com", valid password as "123456789!!" and clicks SignIn button
	Then The user shoud be successfully signed in

	