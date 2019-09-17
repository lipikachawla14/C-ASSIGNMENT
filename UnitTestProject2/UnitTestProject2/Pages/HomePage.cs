using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2.Pages
{
    class HomePage : Drivers
    {
        private string button = "header_user_info";
        private string buttonclick = "//button[@name='SubmitLogin']";
        private string error = "//div[@class='alert alert-danger']//ol//li";
        private string password = "//input[@id='passwd']";
        private string email = "//input[@id='email']";
        public bool verifyPage()
        {
            return true;
        }

       public void click()
        {
            IWebElement loginButton = driver.FindElement(By.ClassName(button));
            Utills.CommonUtills.click(loginButton);
        }
        public bool select()
        {
            IWebElement login = driver.FindElement(By.XPath(buttonclick));
            Utills.CommonUtills.click(login);
            return true;
        }

        public bool details(string abc, string xyz)
        {
            IWebElement passwordinput = driver.FindElement(By.XPath(password));
            Utills.CommonUtills.sendkeys(passwordinput,xyz);
            IWebElement emailinput = driver.FindElement(By.XPath(email));
            Utills.CommonUtills.sendkeys(emailinput, abc);
            return true;
            
        }

        public string error_msg()
        {
            IWebElement msg = driver.FindElement(By.XPath(error));
             return Utills.CommonUtills.getmessage(msg);
        }



    }
}
