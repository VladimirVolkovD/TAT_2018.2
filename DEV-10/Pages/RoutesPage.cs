using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Pages
{
    /// <summary>
    /// Routes page elements.
    /// </summary>
    public class RoutesPage
    {
        IList<IWebElement> _timeCell = new List<IWebElement>();

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.Id, Using = "logoutlink")]
        public IWebElement LogoutLink;

        /// <summary>Departure Box.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a textDepStat")]
        public IWebElement DepartureBox;

        /// <summary>Departure warning icon.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message1")]
        public IWebElement DepartureWarIcon;

        /// <summary>Destination box.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a textArrStat")]
        public IWebElement DestinationBox;

        /// <summary>Destination warning icon.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message2")]
        public IWebElement DestinationWarIcon;

        /// <summary>Switch direction button.</summary>
        [FindsBy(How = How.CssSelector,Using ="#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed6176b")]
        public IWebElement SwitchDirectionButton;

        /// <summary>Arrival suggest routes array of elements.</summary>
        public IList<IWebElement> ArrivalSuggestRouteArray() =>
            RoutesInputBlockElements(7).FindElements(By.TagName("a"));

        /// <summary>Departure available routes array of elements.</summary>
        public IList<IWebElement> DepartureAvailableRouteArray() =>
            RoutesInputBlockElements(3).FindElements(By.TagName("a"));

        /// <summary>Used for finding available Routes.///</summary>
        [FindsBy(How = How.ClassName, Using = "fields")]
        private IWebElement _routesInputBlock;

        private IWebElement RoutesInputBlockElements(int n)
        {
            IList<IWebElement> routesInputBlockElements = _routesInputBlock.FindElements(By.TagName("td"));
            return routesInputBlockElements[n];
        }

        /// <summary>Departure available routes.</summary>
        public IWebElement DepartureAvailableRoute(int n)
        {
            IList<IWebElement> departureSuggestRoute = RoutesInputBlockElements(3).FindElements(By.TagName("a"));
            return departureSuggestRoute[n];
        }

        /// <summary>Date box.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a dob")]
        public IWebElement DateBox;

        /// <summary>Warning icon if wrong date inputed.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message3")]
        public IWebElement DateWarIcon;

        /// <summary>Box witn time cells.</summary>
        [FindsBy(How = How.ClassName, Using = "time")]
        private IWebElement timeBoxes;

        /// <summary>Check box for electronic registration.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a onlyER")]
        public IWebElement CheckBoxElectronicRegistration;

        /// <summary>Continue button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExButton")]
        public IWebElement ContinueButton;

        /// <summary>Reset button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExRedButton")]
        public IWebElement ResetButton;

        /// <summary>Departure Time Boxes.</summary>
        public IWebElement TimeBox(int cellNumber)
        {
            _timeCell = timeBoxes.FindElements(By.TagName("a"));
            return _timeCell[cellNumber];
        }

        ///<summary> Send date to the date box.</summary>
        /// <param name="date.">Date.</param>
        public void SendDateBox(string date)
        {
            DateBox.SendKeys(date);
        }

        ///<summary>Click continue button.</summary>
        public void ClickContinueButton()
        {
            ContinueButton.Click();
        }

        ///<summary>Click reset button.</summary>
        public void ClickResetButton()
        {
            ResetButton.Click();
        }

        ///<summary>Send date to the departure box.</summary>
        /// <param name="station.">Name of the station.</param>
        public void SendDepartureBox(string station)
        {
            DepartureBox.SendKeys(station);
        }

        ///<summary>Send date to the destination box.</summary>
        /// <param name="station.">Name of the station.</param>
        public void SendDestinationBox(string station)
        {
            DestinationBox.SendKeys(station);
        }
    }
}