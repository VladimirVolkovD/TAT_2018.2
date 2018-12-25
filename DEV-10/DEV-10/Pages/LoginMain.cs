using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Pages
{
    /// <summary>
    /// Login page elements.
    /// </summary>
    class LoginMain
    {
        public string passwordString = "login";
        public string loginString = "pass";   

        /// <summary>LogIn text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "input#login")]
        public IWebElement Login { get; set; }

        /// <summary>Password text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement Password { get; set; }

        /// <summary>LogIn button</summary>
        [FindsBy(How = How.ClassName, Using = "commandExButton")]
        public IWebElement LogInButton { get; set; }

        /// <summary>Root radio button for login.</summary>
        [FindsBy(How = How.CssSelector, Using = "input#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a conf")]
        public IWebElement CheckRadioButton { get; set; }
    }
}