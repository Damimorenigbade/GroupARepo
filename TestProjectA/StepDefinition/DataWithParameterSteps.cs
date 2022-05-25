using System;
using TechTalk.SpecFlow;
using TestProjectA.PageObject;

namespace TestProjectA
{
    [Binding]
    public class DataWithParameterSteps
    {
        DataDrivenWithParameter dataDrivenwithparameter;
        
        public DataWithParameterSteps()
        {
            dataDrivenwithparameter = new DataDrivenWithParameter();
        }





        [Given(@"I navigate to the ""(.*)""")]
        public void GivenINavigateToThe(string url)
        {
            dataDrivenwithparameter.NavigateToWebsite(url);
        }

        [Given(@"I enter my name ""(.*)""")]
        public void GivenIEnterMyName(string name)
        {
            dataDrivenwithparameter.Enterusername(name);
        }

        [Given(@"I enter my emailaddress ""(.*)""")]
        public void GivenIEnterMyEmailaddress(string email)
        {
            dataDrivenwithparameter.EnterEmailAddress(email);
        }





        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenwithparameter.EnterPassword(password);
        }
    }
}
