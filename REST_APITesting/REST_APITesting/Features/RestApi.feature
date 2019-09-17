Feature: RestApi
	

@Register
Scenario Outline: Successful Registration
	Given user is on homepage
	When user registers itself with username as <username> and password as <password>
	Then user registration is successful
	And token is generated
Examples:
	| username           | password |
	| eve.holt@reqres.in | pistol   |

Scenario Outline: Unsuccesful Registration
Given user is on homepage
When user registers itself with username as <username> and password as <password>
Then user registration is unsuccesful
And token is not generated
Examples: 
| username              | password |
| 123                   | 123      |
| lipika.chawla@gmail.m | pistol   |
| httl.rept@reqres.in   |          |

Scenario: List of all users
When user sends a request on 'users'
Then user will get list of users