using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class SignInSteps
    {
        [Given(@"user is on home page")]
        public void GivenUserIsOnHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"user clicks on signin button")]
        public void WhenUserClicksOnSigninButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"user is on myaccount page")]
        public void ThenUserIsOnMyaccountPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
