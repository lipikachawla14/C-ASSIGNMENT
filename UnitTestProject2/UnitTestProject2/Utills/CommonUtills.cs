using System;
using OpenQA.Selenium;

namespace UnitTestProject2.Utills
{
    class CommonUtills : Drivers
    {

        public static Boolean click(IWebElement go)
        {
            if (go != null)
            {
                go.Click();
                return true;
            }
            else
            {
                Console.WriteLine("Null parameter found");
                return false;
            }
        }
        public static String getTitle()
        {
            return driver.Title;
        }

        public static String getmessage(IWebElement element)
        {
            return element.Text;
        }

        public static void sendkeys(IWebElement element, string key)
        {
            element.SendKeys(key);
        }




    }

}
