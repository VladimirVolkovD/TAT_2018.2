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

        [SetUp] //before every test
        public void SetUp()
        {
            _driver.Navigate().GoToUrl("https://poezd.rw.by");
        }

        [OneTimeTearDown]//after all tests
        public void OneTimeTearDown()
        {            
            _driver.Quit();
        }

        [Test]
        public void LogIn()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginMain loginMain = new LoginMain();
            Routes routes = new Routes();
            PageFactory.InitElements(_driver, loginMain);
            PageFactory.InitElements(_driver, routes);
            
            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/login_main");
            
            loginMain.Password.SendKeys(loginMain.passwordString);
            loginMain.Login.SendKeys(loginMain.loginstring);
            loginMain.LogInButton.Click();
            loginMain.CheckRadioButton.Click();

            if (string.IsNullOrEmpty(routes.LogoutLink.Text))
            {
                throw new Exception();
            }
        }

        [Test]
        public void Itinerary()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            LogIn();
            Routes routes = new Routes();
            PageFactory.InitElements(_driver, routes);

            routes.MinskDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.minskText);

            routes.MinskDestination.Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.minskText);

            routes.BrestDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.brestText);

            routes.BrestDestination.Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.brestText);

            routes.GomelDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.gomelText);

            routes.GomelDestination.Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.gomelText);

            routes.GrodnoDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.grodnoText);

            routes.GrodnoDestination.Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.grodnoText);

            routes.MogilevDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.mogilevText);

            routes.MogilevDestination.Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.mogilevText);

            routes.VitebskDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.vitebskText);

            routes.VitebskDestination .Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.vitebskText);

            routes.MinskDeparture.Click();
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.minskText);

            routes.SwitchDirectionButton.Click();
            Assert.AreEqual(routes.DestinationBox.GetAttribute("value"), routes.minskText);
            Assert.AreEqual(routes.DepartureBox.GetAttribute("value"), routes.vitebskText);
        }

        [Test]
        public void TimeBox()
        {
            LogIn();
            Routes routes = new Routes();
            PageFactory.InitElements(_driver, routes);
            for(int i =0; i < 20 ; i+=4)
            {
                routes.TimeBox(0).Click();
                routes.TimeBox(i).Click();
                routes.TimeBox(i+5).Click();
            }            
        }

        [Test]
        public void ElectronicRegistrationRadioButtonClick()
        {
            LogIn();
            Routes routes = new Routes();
            PageFactory.InitElements(_driver, routes);
            routes.CheckBoxElectronicRegistration.Click();
            System.Threading.Thread.Sleep(1000);
            routes.CheckBoxElectronicRegistration.Click();
        }
    }
}