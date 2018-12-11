using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_9
{
    class LogInPage 
    {
        public string Login { get; set; }
        public string Password { get; set; }
        Locators.LoginPageLocators _locator = new Locators.LoginPageLocators();
        IWebElement _loginButton;
        IWebDriver _driver;
        
        public LogInPage(IWebDriver driver, string login, string password)
        {           
            _driver = driver;
            _driver.Navigate().GoToUrl(_locator.VkPageLocator);
            WebDriverWait waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            Login = login;
            Password = password;           
            _loginButton = waiter.Until(_driver => driver.FindElement(By.Id(_locator.LoginButton)));
        }

        public void LogIn()
        {          
            _driver.FindElement(By.Id(_locator.EmailField)).SendKeys(Login);
            _driver.FindElement(By.Id(_locator.PasswordField)).SendKeys(Password);
            _loginButton.Click();
        }  
    }
}
