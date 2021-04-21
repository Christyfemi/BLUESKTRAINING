
using OpenQA.Selenium;
using PrepMajorSite.Hooks;
using System;
using System.Threading;

namespace PrepMajorSite.PageObject
{
    class NewInstructorPage
    {
        public IWebDriver driver;
        private By clickInstructor = By.XPath("//div[@class='center-unit']//span[contains(text(),'Become an Instructor')]");
        private By enterUsername = By.CssSelector("form[class='stm_lms_register_wrapper'] input[placeholder='Enter username']");
        private By enterEmail = By.XPath("//input[@placeholder='Enter your E-mail']");
        private By enterPassword = By.CssSelector("form[class='stm_lms_register_wrapper'] input[placeholder='Enter password']");
        private By confirmPassword = By.XPath("//input[@placeholder='Confirm password']");
        private By checkBox = By.XPath("//input[@name='privacy_policy']");
        private By registerBox = By.XPath("//span[normalize-space()='Register']");
        private By gmailField = By.Id("identifierId");
        private By nextButton = By.CssSelector("div[class='VfPpkd-RLmnJb']");
        private By passwordField = By.CssSelector("#password > div.aCsJod.oJeWuf > div > div.Xb9hP > input");
        private By nextButtonBox = By.XPath("//button[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']//div[@class='VfPpkd-RLmnJb']");
        private By clickGmailLink = By.CssSelector("tbody > tr > td:nth-child(2) > table:nth-child(1) > tbody > tr > td:nth-child(2) > form > table.th > tbody > tr:nth-child(1) > td:nth-child(3) > a > span");
        private By emailInUseError = By.CssSelector("#stm-lms-register > div.stm-lms-message.error");
        private By emailAlreadyUse = By.XPath("//div[@class='stm-lms-message error']");

        public NewInstructorPage()
        {

         driver = WebHook.driver;

        }

        public void ClickOnInstructor()
        {

         driver.FindElement(clickInstructor).Click();

        }
        public void EnterOnUsername(string username)
        {

         driver.FindElement(enterUsername).SendKeys(username);

        }
        public void EnterOnEmail(string email)
        {

         driver.FindElement(enterEmail).SendKeys(email);

        }
        public void EnterOnPassword(string password)
        {

         driver.FindElement(enterPassword).SendKeys(password);

        }
        public void ConfirmOnPassword(string pass)
        {

         driver.FindElement(confirmPassword).SendKeys(pass);

        }

        public void CheckOnBox()
        {

         driver.FindElement(checkBox).Click();

        }
        public void RegisterOnBox()
        {

         driver.FindElement(registerBox).Click();

        }
        public void GmailAddress()
        {
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(gmailField).SendKeys("femiadekomaya20@gmail.com");

        }

        public void NextButtonClick()
        {

         driver.FindElement(nextButton).Click();

        }

        public void PasswordLogin()
        {
           
         driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
         driver.FindElement(passwordField).SendKeys("Samantha13112012?");

        }
        public void NextButtonToclick()
        {

         driver.FindElement(nextButtonBox).Click();

        }
        public void ClickGmail()
        {
            
         driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
         driver.FindElement(clickGmailLink).Click();

        }

        public string ErrorMessageEmail()
        {
          
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        return driver.FindElement(emailInUseError).Text;

        }

        public string EmailAlreadyInUse()
        {
          
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        return driver.FindElement(emailAlreadyUse).Text;
        }


    }


}






    

