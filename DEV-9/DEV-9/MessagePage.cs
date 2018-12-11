using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace DEV_9
{
    class MessagePage 
    {
        By DialogLocator = By.XPath("//*[@id=\"im_dialogs\"]");
        private IWebDriver driver;
        private List<IWebElement> UnreadMessages;

        public MessagePage(IWebDriver driver)
        {
            UnreadMessages = new List<IWebElement>();
            this.driver = driver;
        }

        private void FindUnreadMessages()
        {
            var unread = driver.FindElement(DialogLocator).FindElements(By.ClassName("nim-dialog_unread"));
            foreach (var i in unread)
            {
                UnreadMessages.Add(i);
            }
        }

        public void ShowUnreadMessages()
        {
            FindUnreadMessages();
            foreach (var i in UnreadMessages)
            {
                Console.WriteLine("\nUnread message:\n" + i.Text);
            }
        }      
    }
}
