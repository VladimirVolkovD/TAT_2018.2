using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    /// <summary>
    /// Login page elements.
    /// </summary>
    public class LoginMainPage
    {
        /// <summary>LogIn text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "input#login")]
        public IWebElement Login;

        /// <summary>Password text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement Password;

        /// <summary>LogIn button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExButton")]
        public IWebElement LogInButton;

        /// <summary>LogIn warning icon.</summary>
        [FindsBy(How = How.Id, Using = "login.errors")]
        public IWebElement LogInWarIcon;

        /// <summary>Password warning icon.</summary>
        [FindsBy(How = How.Id, Using = "password.errors")]
        public IWebElement PasswWarIcon;

        /// <summary>
        /// Enter login in the login box.
        /// </summary>
        /// <param name="login.">Login.</param>
        public void EnterLogin(string login)
        {            
             Login.SendKeys(login);
        }

        /// <summary>
        /// Enter password in the password box.
        /// </summary>
        /// <param name="password.">Password.</param>
        public void EnterPassword(string password)
        {
           Password.SendKeys(password);
        }

        /// <summary>
        /// Click the login button.
        /// </summary>
        public void ClickLogInButton()
        {
            LogInButton.Click();
        }
    }
}
