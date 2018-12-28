using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Pages;

namespace Logick
{
    public class Routes
    {
        ChromeDriver _driver;
        RoutesPage _routesPage;

        public Routes(ChromeDriver driver)
        {
            _driver = driver;
            _routesPage = new RoutesPage();
        }

        void SetUp()
        {
            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/rp/schedule");
            PageFactory.InitElements(_driver, _routesPage);
        }

        public void ElectronicRegistration(ChromeDriver driver)
        {
            SetUp();
            PageFactory.InitElements(driver, _routesPage);
            Assert.AreEqual(_routesPage.CheckBoxElectronicRegistration.Enabled,true);
        }

        public void TimeBox()
        {
            SetUp();          
            PageFactory.InitElements(_driver, _routesPage);
            for (int i = 0; i < 20; i += 4)
            {
                _routesPage.TimeBox(0).Click();
                _routesPage.TimeBox(i).Click();
                _routesPage.TimeBox(i + 5).Click();
            }
        }

        public void ClickCityLinks()
        {
            SetUp();
            PageFactory.InitElements(_driver, _routesPage);
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
    }
}
