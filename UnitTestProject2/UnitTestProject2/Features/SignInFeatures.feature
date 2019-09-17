@login
Feature: SignIn


Scenario Outline: Sign in
	Given user is on homepage
	When user clicks on signinbutton
	Then user provides username as <username> and password as <password> in fields
	And clicks on  signin
	Then error message is displayed <errorMessage>
	Examples: 
   | username           | password | errorMessage               |
   |                    |          | An email address required. |
   |                    | abc      | An email address required. |
   | user@gmail.com     |          | Password is required.      |
   | user@gmail.com     | abc      | Invalid password.          |




