using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExpediaProject.PageReposistory
{
    class FlightSelectionPage : Driver
    {
        public IWebElement getFlightsButton()
        {
            return driver.FindElement(By.Id("tab-flight-tab-hp"));
        }
        public IWebElement getMultiCityLBL()
        {
            return driver.FindElement(By.Id("flight-type-multi-dest-label-hp-flight"));
        }
        public IWebElement getAddFlightOPT()
        {
            return driver.FindElement(By.Id("add-flight-leg-hp-flight"));
        }
        public IWebElement getFirstAirport()
        {
            return driver.FindElement(By.Id("flight-origin-hp-flight"));
        }
        public IWebElement getFirstDestinationAirport()
        {
            return driver.FindElement(By.Id("flight-destination-hp-flight"));
        }
        public IWebElement getSecondAirport()
        {
            return driver.FindElement(By.Id("flight-2-origin-hp-flight"));
        }
        public IWebElement getSecondDestinationAirport()
        {
            return driver.FindElement(By.Id("flight-2-destination-hp-flight"));
        }
        public IWebElement getThirdAirport()
        {
            return driver.FindElement(By.Id("flight-3-origin-hp-flight"));
        }
        public IWebElement getThirdDestinationAirport()
        {
            return driver.FindElement(By.Id("flight-3-destination-hp-flight"));
        }
        public IWebElement getFirstDate()
        {
            return driver.FindElement(By.Id("flight-departing-single-hp-flight"));
        }
        public IWebElement getSecondDate()
        {
            return driver.FindElement(By.Id("flight-2-departing-hp-flight"));
        }
        public IWebElement getThirdDate()
        {
            return driver.FindElement(By.Id("flight-3-departing-hp-flight"));
        }
        public IWebElement getTravellersValue()
        {
            return driver.FindElement(By.Id("traveler-selector-hp-flight"));
        }
        public IWebElement getSearchButton()
        {
            return driver.FindElement(By.XPath("//form[@id = 'gcw-flights-form-hp-flight']//button[@type='submit']"));
        }
        public IWebElement getAddTravellerButton()
        {
            return driver.FindElement(By.XPath("(//button[@class='uitk-step-input-button uitk-step-input-plus'])[1]"));
        }
        public IWebElement getAdultSelectorCloseButton()
        {
            return driver.FindElement(By.XPath("//div[@id='traveler-selector-hp-flight']//button[@class ='close btn-text']"));
        }
    }
}
