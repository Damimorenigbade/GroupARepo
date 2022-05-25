using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestProjectA.PageObject;

namespace TestProjectA.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;


        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }




        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.IClickSignUp();
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.Enterusername();
        }
        
        [Given(@"I enter my emailaddress")]
        public void GivenIEnterMyEmailaddress()
        {
            registrationPage.EnterEmailAddress();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on the sign button")]
        public void WhenIClickOnTheSignButton()
        {
            registrationPage.ClickSignUpButton();
        }
        
        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}
