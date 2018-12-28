using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests
{
    public abstract class Test
    {
        public static ChromeDriver driver = new ChromeDriver();

        [SetUp] //before every test
        public void SetUp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://poezd.rw.by");
        }

        [OneTimeTearDown]//after all tests
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
