using System;
using NUnit.Framework;
using RestApiTesting.Login;
using TechTalk.SpecFlow;

namespace RestApiTesting.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        BussinessLogic bl = new BussinessLogic();

        [When(@"new user registers itself with  (.*) and (.*)")]
        public void WhenNewUserRegistersItselfWithAnd(string p2, string p3)
        {
            bl.call();
            bl.Response();
            bl.Register(p2,p3);
        }
        
        [When(@"user registers with  (.*) and  (.*)")]
        public void WhenUserRegistersWithAnd(string p0, string p1)
        {
           bl.call();
           bl.Response();
           bl.Register(p0,p1);

        }
        
        [When(@"user sends a request on users")]
        public void WhenUserSendsARequestOnUsers()
        {
            bl.call();
            bl.Rest();
        }
        
        [Then(@"user registration is successful")]
        public void ThenUserRegistrationIsSuccessful()
        {
            Assert.IsTrue(bl.check());
        }
        
        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            Assert.IsTrue(bl.check());
        }
        
        [Then(@"user registration is unsuccesful")]
        public void ThenUserRegistrationIsUnsuccesful()
        {
            Assert.IsFalse(bl.check());
        }
        
        [Then(@"token is not generated")]
        public void ThenTokenIsNotGenerated()
        {
            Assert.IsFalse(bl.check());
        }
        
        [Then(@"user will get list of users")]
        public void ThenUserWillGetListOfUsers()
        {
            bl.userList();
        }
    }
}
