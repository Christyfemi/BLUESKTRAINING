Feature: NewInstructor
	As an instructor 
I want to enter my personal details 
So that I can create an account


@newinstructor
Scenario: Create an Account for New Instructor with correct email, username and password
	Given that I navigate www.prepmajor.com
	And I click on button
	And I create "<username>" in the username field
 	And I fill in my "<email>" address
	And I create "<password>" 
	And I confirm my "<pass>"
	And I checked the use of terms box
	And I click on the register button
	And I navigate to my www.gmail.com
	And I enter my gmail address
	And I click next button
	And I enter my password
	And Iclick next button again
	Then I verify by clicking the verification link

	Examples: 
    | username | email                      | password  | pass     | 
    | Femi12   | femiadekomaya20+5@gmail.com| Joshua12? | Joshua12?|  
	


@Feature2
Scenario Outline: Create an Account for New Instructor with Already used email address
    Given that I navigate www.prepmajor.com
	And I click on button
	And I create "<username>" in the username field
	And I fill in my "<email>" address
	And I create "<password>" 
	And I confirm my "<pass>"
	And I checked the use of terms box
	And I click on the register button
	Then The Error "Sorry, that email address is already used!"

	Examples: 
    | username | email                  | password    | pass       | 
    | Ope      | femiadekomaya@yahoo.com| Samantha12? | Samantha12?|  
    

@Feature3
Scenario Outline: user tried to register with Invalid Password
    Given that I navigate www.prepmajor.com
	And I click on button
	And I create "<username>" in the username field
	And I fill in my "<email>" address
	And I create "<password>" 
	And I confirm my "<pass>"
	And I checked the use of terms box
	And I click on the register button
	Then the error message should display "Password must have at least 8 characters"

	Examples: 
    | username | email                  | password    | pass       | 
    | Femi     | femiadekomaya@yahoo.com| Saman | Saman|	