using OpenQA.Selenium.Chrome;

namespace DEV_9
{
    class EntryPoint
    {      
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();

            var logInPage = new LogInPage(driver, "YourEmail", "YourPassword");
            logInPage.LogIn();
            
            var messagePage = new MessagePage(driver);
            messagePage.ShowUnreadMessages();

            driver.Close();
            driver.Quit();
        }        
    }
}
