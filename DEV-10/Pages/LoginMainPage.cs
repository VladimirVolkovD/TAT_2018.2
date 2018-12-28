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
        public IWebElement Login { get; set; }

        /// <summary>Password text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement Password { get; set; }

        /// <summary>LogIn button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExButton")]
        public IWebElement LogInButton { get; set; }

        /// <summary>LogIn warning icon.</summary>
        [FindsBy(How = How.Id, Using = "login.errors")]
        public IWebElement LogInWarIcon{ get; set; }

        /// <summary>Password warning icon.</summary>
        [FindsBy(How = How.Id, Using = "password.errors")]
        public IWebElement PasswWarIcon { get; set; }

        /// <summary>
        /// Enter login in the login box.
        /// </summary>
        /// <param name="Login."></param>
        public void EnterLogin(string login)
        {            
             Login.SendKeys(login);
        }

        /// <summary>
        /// Enter password in the password box.
        /// </summary>
        /// <param name="Login."></param>
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