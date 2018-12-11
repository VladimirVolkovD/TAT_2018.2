using OpenQA.Selenium.Chrome;

namespace DEV_9
{
    class Program
    {      
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://vk.com/");

            var logInPage = new LogInPage(driver, "YourEmail", "YourPassword");
            logInPage.LogIn();

            driver.Navigate().GoToUrl("https://vk.com/im");
            var messagePage = new MessagePage(driver);
            messagePage.ShowUnreadMessages();

            driver.Close();
            driver.Quit();

        }        
    }
}
