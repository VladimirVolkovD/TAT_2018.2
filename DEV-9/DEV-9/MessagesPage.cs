using OpenQA.Selenium;
using System;

namespace DEV_9
{
    /// <summary>
    /// Create object of messages page
    /// </summary>
    class MessagesPage 
    {        
        private IWebDriver _driver;
        IWebElement unreadMesseges;
        

        public MessagesPage(IWebDriver driver)
        {           
            _driver = driver;
            _driver.Navigate().GoToUrl(Locators.MessagesPageLocators.MessagePage);
        }

        /// <summary>
        /// Finds unread messages
        /// </summary>
        private void FindUnreadMessages()
        {
            unreadMesseges = _driver.FindElement(Locators.MessagesPageLocators.UnreadMessage);
            unreadMesseges.Click();
        }

        /// <summary>
        /// Shows unread messages
        /// </summary>
        public void ShowUnreadMessages()
        {
            FindUnreadMessages();
            IWebElement dialogElements = _driver.FindElement(Locators.MessagesPageLocators.DialogsLocator);
            var messages = dialogElements.FindElements(Locators.MessagesPageLocators.Message);

            foreach (var i in messages)
            {
                Console.WriteLine("\nFrom : " + i.FindElement(Locators.MessagesPageLocators.MessageName).Text);
                Console.WriteLine("Message : "+ i.FindElement(Locators.MessagesPageLocators.MessageText).Text);
            }
        }      
    }
}
