using System;
using NUnit.Framework;
using REST_APITesting.Registration;
using TechTalk.SpecFlow;

namespace REST_APITesting.StepDefinitions
{
    [Binding]
    public class RestApiSteps
    {
        Login obj = new Login();

        [Given(@"user is on homepage")]
        public void GivenUserIsOnHomepage()
        {
            obj.call();
        }
        
        [When(@"user registers itself with username as (.*) and password as (.*)")]
        public void WhenUserRegistersItselfWithUsernameAsAndPasswordAs(string p0, string p1)
        {
            obj.Register(p0,p1);
        }
        
        [When(@"user sends a request on (.*)")]
        public void WhenUserSendsARequestOn(string a)
        {
            obj.Rest(a);
        }
        
        [Then(@"user registration is successful")]
        public void ThenUserRegistrationIsSuccessful()
        {
            Assert.IsTrue(obj.check());
        }
        
        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            Assert.IsTrue(obj.check());
        }
        
        [Then(@"user registration is unsuccesful")]
        public void ThenUserRegistrationIsUnsuccesful()
        {
            Assert.IsTrue(obj.check());
        }
        
        [Then(@"token is not generated")]
        public void ThenTokenIsNotGenerated()
        {
            Assert.IsFalse(obj.check());
        }
        
        [Then(@"user will get list of users")]
        public void ThenUserWillGetListOfUsers()
        {
            obj.call();
            obj.userList();
        }
    }
}
