using System;
using OpenQA.Selenium.Chrome;

namespace DEV_9
{
    /// <summary>
    /// Calls all methods for all tested web pages.
    /// </summary>
    class EntryPoint
    {
        static readonly ChromeDriver _driver = new ChromeDriver();
        static void Main()
        {
            try
            {
                var logInPage = new LogInPage(_driver, "YourLogin", "YourPassword");
                logInPage.LogIn();
                var messagePage = new MessagesPage(_driver);
                messagePage.GetUnreadMessages();
                messagePage.ShowMessages();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _driver.Quit();
            }
        }
    }
}