Feature: As Instructor 
I want to add a meeting link to an existing course
So I can carry out a meeting via any of the 3 (Zoom.Hangout,Teams)meeting platforms available 


@ Schedule
Scenario: The Instructor can carry out meeting
Given an instructor navigates test.prepmajor.com
When the instructor logs in
And the instructor enter username
And the instructor enter password
And the instructor click log in button
And clicks on my courses  
And I search a prefer course
And I click the search button
And selects a preferred course
Then I click the link


