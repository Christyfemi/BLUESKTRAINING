Feature: As an instructor
I want to create a course 
So I can book an appointment on test.prepmajor.com

@createcourse
Scenario: CreateCourseAppointment
Given an instructor navigates to test.prepmajor.com
When the instructor log in
And instructor enter username
And instructor enter password
And instructor log in
And the instructor clicks create a course 
And click the course field
And  enters a course title
And  chooses a category
And chooses a parent category
And select from dropdown menu
And uploads a course image
And enters course description
And adds meeting link
And adds course curriculum
And adds price
And adds course duration
And clicks publish course
Then the instructor has created a course and appointment
