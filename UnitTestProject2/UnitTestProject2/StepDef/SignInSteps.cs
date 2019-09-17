using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UnitTestProject2.Pages;

namespace UnitTestProject2.StepDef
{
    [Binding]
    public class SignInSteps : Drivers
    {
        HomePage hp = new HomePage();
        [Given(@"user is on homepage")]
        public void GivenUserIsOnHomepage()
        {
            InitBrowser("Chrome");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
            Assert.IsTrue(hp.verifyPage(), "My Store");
        }

        [When(@"user clicks on signinbutton")]
        public void WhenUserClicksOnSigninbutton()
        {
            hp.click();
        }

        [Then(@"user provides username as (.*) and password as (.*) in fields")]
        public void ThenUserProvidesAndInFields(string username, string password)
        {
            hp.details(username, password); 

        }

        [Then(@"clicks on  signin")]
        public void ThenClicksOnSignin()
        {
            hp.select();
        }

        [Then(@"error message is displayed (.*)")]
        public void ThenErrorMessageIsDisplayed(string p0)
        {
            Assert.AreEqual(p0, hp.error_msg());
            
        }



    }
}
