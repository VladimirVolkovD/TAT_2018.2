using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Pages;

namespace Tests
{
    [TestFixture]
    class LogInTest
    {
        static ChromeDriver _driver;
        LoginMainPage _loginPage;

        [SetUp] //before every test
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/login_main");
            _loginPage = new LoginMainPage();
            PageFactory.InitElements(_driver, _loginPage);
        }

        [TearDown]//after all tests
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        [TestCase("vladimir12.03", "djg44s6d")]
        public void CorrectLogIn(string login, string password)
        {
            var rulesPage = new RulesPage();
            var routesPage = new RoutesPage();
            PageFactory.InitElements(_driver, rulesPage);
            PageFactory.InitElements(_driver, routesPage);
            _loginPage.EnterLogin(login);
            _loginPage.EnterPassword(password);
            _loginPage.ClickLogInButton();
            rulesPage.ClickRadioButton();
            Assert.IsFalse(string.IsNullOrEmpty(routesPage.LogoutLink.Text));
        }

        [Test]
        [TestCase("vldmr12", "djg44s6d")]
        public void WrongLogIn(string login, string password)
        {
            _loginPage.EnterLogin(login);
            _loginPage.EnterPassword(password);
            _loginPage.ClickLogInButton();          
            Assert.IsTrue(_loginPage.LogInWarIcon.Enabled);
        }

        [Test]
        [TestCase("vladimir12.03", "wrong")]
        public void WrongPassword(string login, string password)
        {
            _loginPage.EnterLogin(login);
            _loginPage.EnterPassword(password);
            _loginPage.ClickLogInButton();
            Assert.IsTrue(_loginPage.PasswWarIcon.Enabled);
        }
    }
}