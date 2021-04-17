using OpenQA.Selenium;
using PrepMajorSite.Hooks;
using PrepMajorSite.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorSite.Steps
{
    [Binding]
    public class AsAnInstructorSteps
    {
        public IWebDriver driver = WebHook.driver;
       CreateCourseAndAppointmentPage _createCourseAndAppointmentPage = new CreateCourseAndAppointmentPage();


        [Given(@"an instructor navigates to test\.prepmajor\.com")]
        public void GivenAnInstructorNavigatesToTest_Prepmajor_Com()
        {
         driver.Navigate().GoToUrl(@"https://test.prepMajor.com");
        }
        
        [When(@"the instructor log in")]
        public void WhenTheInstructorLogIn()
        {
            _createCourseAndAppointmentPage.LogInIcon();
        }
        [When(@"instructor enter username")]
        public void WhenInstructorEnterUsername()
        {
            _createCourseAndAppointmentPage.UserNameField();
        }
        [When(@"instructor enter password")]
        public void WhenInstructorEnterPassword()
        {
            _createCourseAndAppointmentPage.PassWordField();
        }
        [When(@"instructor log in")]
        public void WhenInstructorLogIn()
        {
            _createCourseAndAppointmentPage.LoginButtonIcon();
        }

        [When(@"the instructor clicks create a course")]
        public void WhenTheInstructorClicksCreateACourse()
        {
            _createCourseAndAppointmentPage.CreateACourseIcon();
        }
        [When(@"click the course field")]
        public void WhenClickTheCourseField()
        {
            _createCourseAndAppointmentPage.ClickCoursefield();
        }

        [When(@"enters a course title")]
        public void WhenEntersACourseTitle()
        {
            _createCourseAndAppointmentPage.EnterACoursefield();
        }
        
        [When(@"chooses a category")]
        public void WhenChoosesACategory()
        {
            _createCourseAndAppointmentPage.ChooseCategoryField();
        }
        

        [When(@"chooses a parent category")]
        public void WhenChoosesAParentCategory()
        {
            _createCourseAndAppointmentPage.ChooseCategoryTwo();
        }
        [When(@"select from dropdown menu")]
        public void WhenSelectFromDropdownMenu()
        {
            _createCourseAndAppointmentPage.SelectFromDropdownMenu();
        }
        [When(@"uploads a course image")]
        public void WhenUploadsACourseImage()
        {
            _createCourseAndAppointmentPage.UploadACourse();
        }
        
        [When(@"enters course description")]
        public void WhenEntersCourseDescription()
        {
          
        }
        
        [When(@"adds meeting link")]
        public void WhenAddsMeetingLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"adds course curriculum")]
        public void WhenAddsCourseCurriculum()
        {
           
        }
        
        [When(@"adds price")]
        public void WhenAddsPrice()
        {
           
        }
        
        [When(@"adds course duration")]
        public void WhenAddsCourseDuration()
        {
            
        }
        
        [When(@"clicks publish course")]
        public void WhenClicksPublishCourse()
        {
           
        }
        
        [Then(@"the instructor has created a course and appointment")]
        public void ThenTheInstructorHasCreatedACourseAndAppointment()
        {
            
        }
    }
}
