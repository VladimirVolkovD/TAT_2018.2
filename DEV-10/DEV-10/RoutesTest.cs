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
            _routesPage.SendDataBox(date);
            _routesPage.ClickContinueButton();
            Assert.IsTrue(_routesPage.DateWarIcon.Enabled);
        }

        [Test]       
        public void CorrectFields()
        {
            var trainPage = new TrainPage();
            PageFactory.InitElements(_driver, trainPage);
            _routesPage.SendDepartureBox(_routesPage.mogilevText);
            _routesPage.SendDestinationBox(_routesPage.minskText);
            _routesPage.ClickContinueButton();
            Assert.IsTrue(trainPage.TrainText.Enabled);
        }

        [Test]
        [TestCase("strange","name")]
        [TestCase("", "")]
        public void WrongOrEmptyStationsName(string departure,string destination)
        {
            _routesPage.SendDepartureBox(departure);
            _routesPage.SendDestinationBox(destination);
            _routesPage.ClickContinueButton();
            Assert.IsTrue(_routesPage.DestinationWarIcon.Enabled);
            Assert.IsTrue(_routesPage.DepartureWarIcon.Enabled);
        }  

        //        public void TimeBox()
        //        {
        //            SetUp();
        //            PageFactory.InitElements(_driver, _routesPage);
        //            for (int i = 0; i < 20; i += 4)
        //            {
        //                _routesPage.TimeBox(0).Click();
        //                _routesPage.TimeBox(i).Click();
        //                _routesPage.TimeBox(i + 5).Click();
        //            }
        //        }

        //        public void ClickCityLinks()
        //        {
        //            SetUp();
        //            PageFactory.InitElements(_driver, _routesPage);
        //            _routesPage.MinskDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.minskText);

        //            _routesPage.MinskDestination.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.minskText);

        //            _routesPage.BrestDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.brestText);

        //            _routesPage.BrestDestination.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.brestText);

        //            _routesPage.GomelDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.gomelText);

        //            _routesPage.GomelDestination.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.gomelText);

        //            _routesPage.GrodnoDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.grodnoText);

        //            _routesPage.GrodnoDestination.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.grodnoText);

        //            _routesPage.MogilevDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.mogilevText);

        //            _routesPage.MogilevDestination.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.mogilevText);

        //            _routesPage.VitebskDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.vitebskText);

        //            _routesPage.VitebskDestination.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.vitebskText);

        //            _routesPage.MinskDeparture.Click();
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.minskText);

        //            _routesPage.SwitchDirectionButton.Click();
        //            Assert.AreEqual(_routesPage.DestinationBox.GetAttribute("value"), _routesPage.minskText);
        //            Assert.AreEqual(_routesPage.DepartureBox.GetAttribute("value"), _routesPage.vitebskText);
        //        }
        //    }
        //}
    }
}
