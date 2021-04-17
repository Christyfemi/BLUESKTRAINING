using OpenQA.Selenium;
using PrepMajorSite.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrepMajorSite.PageObject
{
    class CreateCourseAndAppointmentPage
    {
        public IWebDriver driver = WebHook.driver;
        private By logIn = By.CssSelector("a[class='stm_lms_log_in'] span");
        private By userName = By.CssSelector("div[class='stm_lms_login_wrapper'] input[placeholder='Enter username']");
        private By passWord = By.CssSelector("div[class='stm_lms_login_wrapper'] input[placeholder='Enter password']");
        private By loginButton = By.CssSelector(" div[class='stm_lms_login_wrapper__actions'] a[class='btn btn-default'] span");
        private By createACourse = By.CssSelector("li[id='menu-item-2016'] a");
        private By coursefield = By.CssSelector("h1[class='stm_lms_course__title']");
        private By enterACourse = By.CssSelector("div[class='stm_lms_manage_course stm_lms_manage_course__text stm_lms_manage_course__title stm_lms_wizard_step_1 active-hint active'] input[type='text']");
        private By chooseCategory = By.CssSelector("div[class='value h6 stm_lms_phantom']");
        private By chooseCategoryTwo = By.CssSelector("select[name='category']");
        private By selectFromDropdown = By.CssSelector("select[name='category']");
        private By uploadCourse = By.CssSelector("div[class='stm_lms_course__image stm_lms_wizard_step_3'] div input[type='file']");

        public CreateCourseAndAppointmentPage()
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
        public void CreateACourseIcon()
        {
            Thread.Sleep(3000);
            driver.FindElement(createACourse).Click();
        }
        public void ClickCoursefield()
        {
            
            driver.FindElement(coursefield).Click();
        }
        public void EnterACoursefield()
        {
            Thread.Sleep(3000);
            driver.FindElement(enterACourse).SendKeys("Manual Testing");
        }
        public void ChooseCategoryField()
        {
            Thread.Sleep(3000);
            driver.FindElement(chooseCategory).Click();
        }
        public void ChooseCategoryTwo()
        {
            Thread.Sleep(3000);
            driver.FindElement(chooseCategoryTwo).Click();
        }
        public void SelectFromDropdownMenu()
        {
            Thread.Sleep(3000);
            driver.FindElement(selectFromDropdown).SendKeys("Art and Photography");
        }

        public void UploadACourse()
        {
            driver.FindElement(uploadCourse).Click();
        }

    }
}
