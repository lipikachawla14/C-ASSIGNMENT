using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExpediaProject.CommonUtills
{
    class CommonUtilities : Driver
    {

        public void Maximize()
        {
            driver.Manage().Window.Maximize();
            deleteCookies();
        }
        public void OpenURL(String url)
        {
            driver.Url = url;
            driver.Navigate();
        }
        public bool CheckTitle(String title)
        {
            return title.Equals(driver.Title);
        }
        public void click(IWebElement element)
        {
            element.Click();
        }
        public void TypeText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        public String getText(IWebElement element)
        {
            return element.GetAttribute("innerHTML");
        }
        public String getValue(IWebElement element)
        {
            return element.GetAttribute("value");
        }
        public void wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void deleteCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }
        public void switchWindow()
        {
            driver.SwitchTo().Window(windowHandle());
        }
        public String windowHandle()
        {
            return driver.WindowHandles[0];
        }
        public double getFare(IWebElement e)
        {

            String totalText = e.GetAttribute("innerHTML");
            String[] Price = totalText.Split('$');
            return double.Parse(Price[1]);
        }
        public void SwitchTabs()
        {
            ArrayList tabs = new ArrayList(driver.WindowHandles);
            driver.SwitchTo().Window((String)tabs[1]);

        }
        public double getFare1(IWebElement e)
        {
            return double.Parse(e.GetAttribute("data-exact-price"));
        }

    }
    }
