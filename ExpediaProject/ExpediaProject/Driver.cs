using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpediaProject.CommonUtills;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExpediaProject
{
    class Driver
    {
        CommonUtilities commnutils;
        public static IWebDriver driver;
        public void InvokeDriver()
        {
            commnutils = new CommonUtilities();
            driver = new ChromeDriver();
            commnutils.Maximize();
            commnutils.OpenURL("https://www.expedia.com");
        }
        public void Close()
        {
            driver.Close();
        }
    }
}
