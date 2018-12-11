using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_9
{
    class LogInPage 
    {
        public string Login { get; set; }
        public string Password { get; set; }
        By _elementEmail = By.Id("index_email");
        By _elementPassword = By.Id("index_pass");
        WebDriverWait waiter;
        IWebElement _loginButton;
        IWebDriver _driver;
        
        public LogInPage(IWebDriver driver, string login, string password)
        {           
            this._driver = driver;
            Login = login;
            Password = password;
            waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(30)); ;
            _loginButton = waiter.Until(_driver => driver.FindElement(By.Id("index_login_button")));
        }

        public void LogIn()
        {
            _driver.FindElement(_elementEmail).SendKeys(Login);
            _driver.FindElement(_elementPassword).SendKeys(Password);
            _loginButton.Click();
        }  
    }
}
