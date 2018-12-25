using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Tests.Pages;

namespace Tests
{
    [TestFixture]
    class PoezdRwTests
    {
        ChromeDriver _driver = new ChromeDriver();

        [OneTimeTearDown] 
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LogIn()
        {           
            LoginMain loginMain = new LoginMain();
            Routes routes = new Routes();
            PageFactory.InitElements(_driver, loginMain);
            PageFactory.InitElements(_driver, routes);

            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/login_main?lang=ru");  
            loginMain.Password.SendKeys(loginMain.loginString);
            loginMain.Login.SendKeys(loginMain.passwordString);            
            loginMain.LogInButton.Click();
            loginMain.CheckRadioButton.Click();
          
            if (string.IsNullOrEmpty(routes.LogoutLink.Text))
            {
                throw new Exception();
            }
        }
    }
}
