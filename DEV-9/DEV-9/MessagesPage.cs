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
        Locators.MessagesPageLocators _locator = new Locators.MessagesPageLocators();

        public MessagesPage(IWebDriver driver)
        {           
            _driver = driver;
            _driver.Navigate().GoToUrl(_locator.MessagePage);
        }

        /// <summary>
        /// Finds unread messages
        /// </summary>
        private void FindUnreadMessages()
        {
            unreadMesseges = _driver.FindElement(By.Id(_locator.UnreadMessage));
            unreadMesseges.Click();
        }

        /// <summary>
        /// Shows unread messages
        /// </summary>
        public void ShowUnreadMessages()
        {
            FindUnreadMessages();
            IWebElement dialogElements = _driver.FindElement(By.Id(_locator.DialogsLocator));
            var messages = dialogElements.FindElements(By.ClassName(_locator.Message));

            foreach (var i in messages)
            {
                Console.WriteLine("\nFrom : " + i.FindElement(By.ClassName(_locator.MessageName)).Text);
                Console.WriteLine("Message : "+ i.FindElement(By.ClassName(_locator.MessageText)).Text);
            }
        }      
    }
}
