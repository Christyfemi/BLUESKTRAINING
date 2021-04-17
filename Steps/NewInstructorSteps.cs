using FluentAssertions;
using OpenQA.Selenium;
using PrepMajorSite.Hooks;
using PrepMajorSite.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorSite.Steps
{
    [Binding]
    public class NewInstructorSteps
    {
        public IWebDriver driver = WebHook.driver;
        NewInstructorPage _newInstructorPage = new NewInstructorPage();

        [Given(@"that I navigate www\.prepmajor\.com")]
        public void GivenThatINavigateWww_Prepmajor_Com()
        {
            driver.Navigate().GoToUrl(@"https://test.prepMajor.com");
        }

        [Given(@"I click on button")]
        public void GivenIClickOnButton()
        {
            _newInstructorPage.ClickOnInstructor();
        }
        
        [Given(@"I create ""(.*)"" in the username field")]
        public void GivenICreateInTheUsernameField(string username)
        {
            _newInstructorPage.EnterOnUsername(username);
        }
        
        [Given(@"I fill in my ""(.*)"" address")]
        public void GivenIFillInMyAddress(string email)
        {
            _newInstructorPage.EnterOnEmail(email);
        }
        
        [Given(@"I create ""(.*)""")]
        public void GivenICreate(string password)
        {
            _newInstructorPage.EnterOnPassword(password);
        }
        
        [Given(@"I confirm my ""(.*)""")]
        public void GivenIConfirmMy(string pass)
        {
            _newInstructorPage.ConfirmOnPassword(pass);
        }
        
        [Given(@"I checked the use of terms box")]
        public void GivenICheckedTheUseOfTermsBox()
        {
            _newInstructorPage.CheckOnBox();
        }
        
        [Given(@"I click on the register button")]
        public void GivenIClickOnTheRegisterButton()
        {
            _newInstructorPage.RegisterOnBox();
        }
        
        [Given(@"I navigate to my www\.gmail\.com")]
        public void GivenINavigateToMyWww_Gmail_Com()
        {
            driver.Navigate().GoToUrl(@"https://mail.google.com/mail/u/0/h/1fa13of1f5b4d/");
        }
        
        [Given(@"I enter my gmail address")]
        public void GivenIEnterMyGmailAddress()
        {
            _newInstructorPage.GmailAddress();
        }
        
        [Given(@"I click next button")]
        public void GivenIClickNextButton()
        {
            _newInstructorPage.NextButtonToclick();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            _newInstructorPage.PasswordLogin();
        }
        
        [Given(@"Iclick next button again")]
        public void GivenIclickNextButtonAgain()
        {
            _newInstructorPage.NextButtonToclick();
        }
        
        [Then(@"I verify by clicking the verification link")]
        public void ThenIVerifyByClickingTheVerificationLink()
        {
            _newInstructorPage.ClickGmail();
        }

        [Then(@"The Error ""(.*)""")]
        public void ThenTheError(string alreadyUseEmail)
        {
            var actualErrrorMessageDisplayed = _newInstructorPage.EmailAlreadyInUse();
            actualErrrorMessageDisplayed.Should().Contain(alreadyUseEmail);

        }

        [Then(@"the error message should display ""(.*)""")]
        public void ThenTheErrorMessageShouldDisplay(string emailErrorMessage)
        {
            var actualErrorMessageReturned = _newInstructorPage.ErrorMessageEmail();
            actualErrorMessageReturned.Should().Contain(emailErrorMessage);

        }


    }
}
