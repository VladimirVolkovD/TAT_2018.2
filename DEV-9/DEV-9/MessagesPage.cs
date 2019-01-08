using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace DEV_9
{
    /// <summary>
    /// Create object of messages page.
    /// </summary>
    class MessagesPage 
    {        
        private IWebDriver _driver;
        private IWebElement _unreadMesseges;
        private ReadOnlyCollection<IWebElement>_messages;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="driver">WebDriver object.</param>
        public MessagesPage(IWebDriver driver)
        {           
            _driver = driver;
            _driver.Navigate().GoToUrl(Locators.MessagesPageLocators.MessagePage);
        }

        /// <summary>
        /// Finds unread messages.
        /// </summary>
        private void FindUnreadMessages()
        {
            _unreadMesseges = _driver.FindElement(Locators.MessagesPageLocators.UnreadMessage);
            _unreadMesseges.Click();
        }

        /// <summary>
        /// Get unread messages.
        /// </summary>
        public void GetUnreadMessages()
        {
            FindUnreadMessages();
            var dialogElements = _driver.FindElement(Locators.MessagesPageLocators.DialogsLocator);
            _messages = dialogElements.FindElements(Locators.MessagesPageLocators.Message);
        }

        /// <summary>
        /// Shows unread messages.
        /// </summary>
        public void ShowMessages()
        {
            foreach (var i in _messages)
            {
                Console.WriteLine("\nFrom : " + i.FindElement(Locators.MessagesPageLocators.MessageName).Text);
                Console.WriteLine("Message : " + i.FindElement(Locators.MessagesPageLocators.MessageText).Text);
            }
        }
    }
}
