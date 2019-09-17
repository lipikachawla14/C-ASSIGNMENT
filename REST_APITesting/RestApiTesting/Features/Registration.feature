Feature: Registration
	

@Register
Scenario Outline: Successful Registration
	When new user registers itself with  <username> and <password>
	Then user registration is successful
	And token is generated
Examples:
	| username           | password |
	| eve.holt@reqres.in | pistol   |

Scenario Outline: Unsuccesful Registration
When user registers with  <username> and  <password>
Then user registration is unsuccesful
And token is not generated
Examples: 
| username              | password |
| 123                   | 123      |
| lipika.chawla@gmail.m | pistol   |
| httl.rept@reqres.in   |          |

Scenario: List of all users
When user sends a request on users
Then user will get list of users


