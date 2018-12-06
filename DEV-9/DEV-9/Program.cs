using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            var elementEmail = driver.FindElement(By.Id("email"));
            var elementPassword = driver.FindElement(By.Id("pass"));
            var loginButton = driver.FindElement(By.PartialLinkText("Вход"));  
          
            elementEmail.SendKeys("davolotir@providier.com");
            elementPassword.SendKeys("%3#FCXLDD2");
            loginButton.Click();

            driver.Navigate().GoToUrl("https://www.facebook.com/messages/");           
        }
    }
}
