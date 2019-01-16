using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using Pages;
using System;

namespace Tests
{
    [TestFixture]
    public class Routes
    {
        ChromeDriver _driver;
        RoutesPage _routesPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _routesPage = new RoutesPage();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/rp/schedule");
            PageFactory.InitElements(_driver, _routesPage);
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void ElectronicRegistration()
        {
            Assert.AreEqual(_routesPage.CheckBoxElectronicRegistration.Enabled, true);
        }

        [Test]
        [TestCase("12.03.2016")]
        [TestCase("12.03.3016")]
        public void WrongDate(string date)
        {
            _routesPage.SendDateBox(date);
            _routesPage.ClickContinueButton();
            Assert.IsTrue(_routesPage.DateWarIcon.Enabled);
        }

        [Test]
        [TestCase("БРЕСТ-ЦЕНТРАЛЬНЫЙ", "ВИТЕБСК-ПАССАЖИРСКИЙ")]
        [TestCase("Осиповичи-1", "Барановичи")]
        public void CorrectFields(string departure, string destination)
        {
            var trainPage = new TrainPage();
            PageFactory.InitElements(_driver, trainPage);
            _routesPage.SendDepartureBox(departure);
            _routesPage.SendDestinationBox(destination);
            _routesPage.ClickContinueButton();
            Assert.IsTrue(trainPage.TrainText.Enabled);
        }

        [Test]
        [TestCase("strange", "name")]
        [TestCase("", "")]
        public void WrongOrEmptyStationsName(string departure, string destination)
        {
            _routesPage.SendDepartureBox(departure);
            _routesPage.SendDestinationBox(destination);
            _routesPage.ClickContinueButton();
            Assert.IsTrue(_routesPage.DestinationWarIcon.Enabled);
            Assert.IsTrue(_routesPage.DepartureWarIcon.Enabled);
        }
        
        [Test]
        public void ClickDepartureLinks()
        {
            foreach (var route in _routesPage.DepartureAvailableRouteArray())
            {
                route.Click();
                var expected = route.Text;
                var result = _routesPage.DepartureBox.GetAttribute("value");
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void ClickDestinationLinks()
        {
            foreach (IWebElement route in _routesPage.ArrivalSuggestRouteArray())
            {
                route.Click();
                var expected = route.Text;
                var result = _routesPage.DestinationBox.GetAttribute("value");
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void ResetButton()
        {
            string date = _routesPage.DateBox.GetAttribute("value");
            _routesPage.SendDateBox("12.03.2019");
            _routesPage.SendDepartureBox("it's doesn't' matter");
            _routesPage.SendDestinationBox("this text will be disappear from this box");
            _routesPage.ClickResetButton();
            Assert.IsEmpty(_routesPage.DepartureBox.Text);
            Assert.IsEmpty(_routesPage.DestinationBox.Text);
            Assert.AreEqual(_routesPage.DateBox.GetAttribute("value"), date);
        }
    }
}