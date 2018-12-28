using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
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
            _driver = new ChromeDriver(); ;
            _routesPage = new RoutesPage();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
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

        //i understand that this is bullshit
        [Test]
        public void ClickCityLinks()
        {
            _routesPage.MinskDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.minskText);

            _routesPage.MinskDestination.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.minskText);

            _routesPage.BrestDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.brestText);

            _routesPage.BrestDestination.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.brestText);

            _routesPage.GomelDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.gomelText);

            _routesPage.GomelDestination.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.gomelText);

            _routesPage.GrodnoDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.grodnoText);

            _routesPage.GrodnoDestination.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.grodnoText);

            _routesPage.MogilevDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.mogilevText);

            _routesPage.MogilevDestination.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.mogilevText);

            _routesPage.VitebskDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.vitebskText);

            _routesPage.VitebskDestination.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.vitebskText);

            _routesPage.MinskDeparture.Click();
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.minskText);

            _routesPage.SwitchDirectionButton.Click();
            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.minskText);
            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.vitebskText);
        }

        [Test]
        public void ResetButton()
        {
            string date = _routesPage.DateBox.GetAttribute("value");
            _routesPage.SendDateBox("12.03.2019");
            _routesPage.SendDepartureBox(_routesPage.mogilevText);
            _routesPage.SendDestinationBox(_routesPage.minskText);
            _routesPage.ClickResetButton();
            Assert.IsEmpty(_routesPage.DepartureBox.Text);
            Assert.IsEmpty(_routesPage.DestinationBox.Text);
            Assert.AreEqual(_routesPage.DateBox.GetAttribute("value"), date);
        }
    }
}

        


    

