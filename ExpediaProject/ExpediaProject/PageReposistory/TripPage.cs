using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExpediaProject.PageReposistory
{
    class TripPage : Driver
    {
        public IWebElement getSelectButton()
        {
            return driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//button"));
        }
        public IWebElement getPrice()
        {
            return driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//span[@class = 'full-bold no-wrap']"));
        }
        public IWebElement getDepart1()
        {
            return driver.FindElement(By.Id("departure-airport-1"));
        }
        public IWebElement getArrival1()
        {
            return driver.FindElement(By.Id("arrival-airport-1"));
        }
        public IWebElement getDepart2()
        {
            return driver.FindElement(By.Id("departure-airport-2"));
        }
        public IWebElement getArrival2()
        {
            return driver.FindElement(By.Id("arrival-airport-2"));
        }
        public IWebElement getDepart3()
        {
            return driver.FindElement(By.Id("departure-airport-3"));
        }
        public IWebElement getArrival3()
        {
            return driver.FindElement(By.Id("arrival-airport-3"));
        }
        public IWebElement getDate1()
        {
            return driver.FindElement(By.Id("departure-date-1"));
        }
        public IWebElement getDate2()
        {
            return driver.FindElement(By.Id("departure-date-1"));
        }
        public IWebElement getDate3()
        {
            return driver.FindElement(By.Id("departure-date-3"));
        }
        public IWebElement getTotalFare()
        {
            return driver.FindElement(By.XPath("(//div//span[@class = 'tripTotalPrice hidden'])[1]"));

        }

    }
}
