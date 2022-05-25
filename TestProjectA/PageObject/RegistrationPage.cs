using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestProjectA.Utilities;

namespace TestProjectA.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));
        IWebElement SignupButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));


             



        public void IClickSignUp()
        {
            SignUp.Click();
        }
        public void Enterusername()
        {
            Username.SendKeys("Dami567");
        }
        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("damilolaelizabeth1256@yahoo.com");
        }
        public void EnterPassword()
        {
            Password.SendKeys("dami12345");
        }
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }
        public void ClickSignUpButton()
        {
            SignupButton.Click();
        }
        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }





    }
}
