using OpenQA.Selenium;
using PrepMajorSite.Hooks;
using PrepMajorSite.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorSite.Steps
{
    [Binding]
    public class AsInstructorSteps

    {
        public IWebDriver driver = WebHook.driver;
        ScheduleAnAppointmentPage _scheduleAnAppointmentPage = new ScheduleAnAppointmentPage();


        [Given(@"an instructor navigates test\.prepmajor\.com")]
        public void GivenAnInstructorNavigatesTest_Prepmajor_Com()
        {
            driver.Navigate().GoToUrl(@"https://test.prepMajor.com");
        }
        
        [When(@"the instructor logs in")]
        public void WhenTheInstructorLogsIn()
        {
            _scheduleAnAppointmentPage.LogInIcon();
        }
        [When(@"the instructor enter username")]
        public void WhenTheInstructorEnterUsername()
        {
            _scheduleAnAppointmentPage.UserNameField();
        }
        [When(@"the instructor enter password")]
        public void WhenTheInstructorEnterPassword()
        {
            _scheduleAnAppointmentPage.PassWordField();
        }
        [When(@"the instructor click log in button")]
        public void WhenTheInstructorClickLogInButton()
        {
            _scheduleAnAppointmentPage.LoginButtonIcon();
        }

        [When(@"clicks on my courses")]
        public void WhenClicksOnMyCourses()
        {
            _scheduleAnAppointmentPage.CoursesIconClick();
        }
        [When(@"I search a prefer course")]
        public void WhenISearchAPreferCourse()
        {
            _scheduleAnAppointmentPage.SearchCoursesField();
        }
        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _scheduleAnAppointmentPage.SearchButtonClick();
        }

        [When(@"selects a preferred course")]
        public void WhenSelectsAPreferredCourse()
        {
            _scheduleAnAppointmentPage.SelectCourseDisplayed();
        }
        [When(@"I select preview the course")]
        //public void WhenISelectPreviewTheCourse()
        //{
        //    _scheduleAnAppointmentPage.PreviewThisCoursePage();
        //}
        [Then(@"I click the link")]
        public void ThenIClickTheLink()
        {
            _scheduleAnAppointmentPage.ClickTheLink();
        }
    }
}
