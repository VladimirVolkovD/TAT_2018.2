using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class RulesPage
    {
        /// <summary>Root radio button for login.</summary>
        [FindsBy(How = How.CssSelector, Using = "input#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a conf")]
        public IWebElement CheckRadioButton;

        /// <summary>
        /// Click the check radio button.
        /// </summary>
        public void ClickRadioButton()
        {
            CheckRadioButton.Click();
        }
    }
}
