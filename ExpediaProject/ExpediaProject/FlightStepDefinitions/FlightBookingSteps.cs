using System;
using ExpediaProject.BusinessLogic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ExpediaProject.FlightStepDefinitions
{
    [Binding]
    public class FlightBookingSteps
    {
        FlightBL flbl;
        [Given(@"I am on flight booking page")]
        public void GivenIAmOnFlightBookingPage()
        {
            flbl = new FlightBL();
           Assert.IsTrue(flbl.CheckTitle("Expedia Travel: Search Hotels, Cheap Flights, Car Rentals & Vacations"));
        }
        
        [Given(@"Click user clicks on Flight section")]
        public void GivenClickUserClicksOnFlightSection()
        {
            Assert.IsTrue(flbl.clickFlights());
        }
        
        [When(@"I select multi-select")]
        public void WhenISelectMulti_Select()
        {
            Assert.IsTrue(flbl.clickMultiCity());
        }
        
        [Then(@"click on Add another flight")]
        public void ThenClickOnAddAnotherFlight()
        {
            Assert.IsTrue(flbl.AddFlight());
        }
        
        [Then(@"Search for flights between different airports (.*),(.*),(.*) on dates (.*),(.*),(.*)  for (.*)  adults")]
        public void ThenSearchForFlightsBetweenDifferentAirportsOnDatesForAdults(string FirstStation, string SecondStation, string ThirdStation, string FirstDate, string SecondDate, string ThirdDate, string number)
        {
            Assert.IsTrue(flbl.fillupFlightData(FirstStation, SecondStation, ThirdStation, FirstDate, SecondDate, ThirdDate, number));
        }
        
        [Then(@"click on Search option")]
        public void ThenClickOnSearchOption()
        {
            Assert.IsTrue(flbl.ClickSearch());
        }
        
        [Then(@"verify tht the data entered is correct")]
        public void ThenVerifyThtTheDataEnteredIsCorrect()
        {
            Assert.IsTrue(flbl.verifyEntry());
        }
        
        [Then(@"select First flight")]
        public void ThenSelectFirstFlight()
        {
            flbl.SelectFlights();
        }
        
        [Then(@"Total Price must be equal to (.*) multiplied fare of single person")]
        public void ThenTotalPriceMustBeEqualToMultipliedFareOfSinglePerson(string number)
        {
            Assert.IsTrue(flbl.verifyTotal());
        }
    }
}
