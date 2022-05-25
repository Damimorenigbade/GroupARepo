using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestProjectA.Utilities;

namespace TestProjectA.PageObject
{
    class DataDrivenWithParameter
    {
        public DataDrivenWithParameter()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));



        public void Enterusername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
           // Username.SendKleys(username);
        }
        public void EnterEmailAddress(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            EmailAddress.SendKeys(email + randomInt + "@yahoo.com");
           // EmailAddress.SendKeys(email);
        }
        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


    }
}
