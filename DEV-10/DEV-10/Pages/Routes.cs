using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Pages
{
    /// <summary>
    /// Routes page elements.
    /// </summary>
    class Routes
    {
        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "a#logoutlink")]
        public IWebElement LogoutLink { get; set; }
    }
}