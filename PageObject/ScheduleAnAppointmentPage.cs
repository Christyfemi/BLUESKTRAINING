using OpenQA.Selenium;
using PrepMajorSite.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrepMajorSite.PageObject
{
    class ScheduleAnAppointmentPage
    {
        public IWebDriver driver = WebHook.driver;
        private By logIn = By.CssSelector("a[class='stm_lms_log_in'] span");
        private By userName = By.CssSelector("div[class='stm_lms_login_wrapper'] input[placeholder='Enter username']");
        private By passWord = By.CssSelector("div[class='stm_lms_login_wrapper'] input[placeholder='Enter password']");
        private By loginButton = By.CssSelector(" div[class='stm_lms_login_wrapper__actions'] a[class='btn btn-default'] span");
        private By coursesIcon = By.XPath("//li[@id='menu-item-940']//a[normalize-space()='Courses']");
        private By searchCourses = By.Id("search-courses-input");
        private By searchButton = By.CssSelector("div[class='center-unit'] i[class='lnr lnr-magnifier']");
        private By selectCourse = By.CssSelector("img[title='Bird']");
        private By previewThisCourse = By.XPath("//a[@title='QA testing']");
        private By theLink = By.XPath("//a[contains(text(),'https://us05web.zoom.us/j/84237732769?pwd=YkZySlph')]");
        public ScheduleAnAppointmentPage()
        {
            driver = WebHook.driver;
        }

        public void LogInIcon()
        {
            driver.FindElement(logIn).Click();
        }
        public void UserNameField()
        {
            Thread.Sleep(3000);
            driver.FindElement(userName).SendKeys("Femi");
        }
        public void PassWordField()
        {
            Thread.Sleep(3000);
            driver.FindElement(passWord).SendKeys("Samantha12?");
        }
        public void LoginButtonIcon()
        {
            Thread.Sleep(3000);
            driver.FindElement(loginButton).Click();
        }
    
        public void CoursesIconClick()
        {
            Thread.Sleep(3000);
            driver.FindElement(coursesIcon).Click();
        }
        public void SearchCoursesField()
        {
            Thread.Sleep(3000);
            driver.FindElement(searchCourses).SendKeys("QA testing");
        }
        public void SearchButtonClick()
        {
            Thread.Sleep(3000);
            driver.FindElement(searchButton).Click();
        }
        public void SelectCourseDisplayed()
        {
            Thread.Sleep(3000);
            driver.FindElement(selectCourse).Click();
        }
        //public void PreviewThisCoursePage()
        //{
        //    Thread.Sleep(3000);
        //    driver.FindElement(previewThisCourse).Click();
        //}
        public void ClickTheLink()
        {
            Thread.Sleep(3000);
            driver.FindElement(theLink).Click();
        }

    }

}
