using OpenQA.Selenium;
using System;

namespace DEV_9
{
    class MessagePage 
    {        
        private IWebDriver _driver;
        IWebElement unreadMesseges;
        Locators.MessagesPageLocators _locator = new Locators.MessagesPageLocators();

        public MessagePage(IWebDriver driver)
        {           
            _driver = driver;
            _driver.Navigate().GoToUrl(_locator.MessagePage);
        }

        private void FindUnreadMessages()
        {
            unreadMesseges = _driver.FindElement(By.Id(_locator.UnreadMessage));
            unreadMesseges.Click();
        }

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
