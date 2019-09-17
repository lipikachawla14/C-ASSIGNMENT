using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2
{
    public class Drivers
    {
        public static IWebDriver driver;

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    if (driver == null)
                    {
                        driver = new ChromeDriver();

                    }
                    break;


            }
        }


    }
}




