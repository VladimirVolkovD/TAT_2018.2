using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_9
{
    /// <summary>
    /// Create object of login page
    /// </summary>
    class LogInPage 
    {
        public string Login { get; set; }
        public string Password { get; set; }
        private WebDriverWait _waiter;
        IWebElement _loginButton;
        IWebDriver _driver;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="driver">WebDriver object.</param>
        /// <param name="login">Your login.</param>
        /// <param name="password">Your password.</param>
        public LogInPage(IWebDriver driver, string login, string password)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(Locators.LoginPageLocators.VkPageLocator);
            _waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            Login = login;
            Password = password;    
        }

        /// <summary>
        /// Login into VK system.
        /// </summary>
        public void LogIn()
        {
            _loginButton = _waiter.Until(_driver => _driver.FindElement(Locators.LoginPageLocators.LoginButton));
            _driver.FindElement(Locators.LoginPageLocators.EmailField).SendKeys(Login);
            _driver.FindElement(Locators.LoginPageLocators.PasswordField).SendKeys(Password);
            _loginButton.Click();
        }  
    }
}
