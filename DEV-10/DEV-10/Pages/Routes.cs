using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Tests.Pages
{
    /// <summary>
    /// Routes page elements.
    /// </summary>
    class Routes
    {
        public string brestText = "БРЕСТ-ЦЕНТРАЛЬНЫЙ";
        public string vitebskText = "ВИТЕБСК-ПАССАЖИРСКИЙ";
        public string grodnoText = "ГРОДНО";
        public string gomelText = "ГОМЕЛЬ";
        public string mogilevText = "МОГИЛЁВ-1";
        public string minskText = "МИНСК-ПАССАЖИРСКИЙ"; 
        IList<IWebElement> timeCell = new List<IWebElement>();

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "a#logoutlink")]
        public IWebElement LogoutLink { get; set; }

        /// <summary>Box witn time cells.</summary>
        [FindsBy(How = How.ClassName, Using = "time")]
        private IWebElement timeBoxes;

        /// <summary>Departure Time Boxes.</summary>
        public IWebElement TimeBox(int cellNumber)
        {  
            timeCell = timeBoxes.FindElements(By.TagName("a"));
            return timeCell[cellNumber];
        }

        /// <summary>Check box for electronic registration.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a onlyER")]
        public IWebElement CheckBoxElectronicRegistration { get; set; }
       

        /// <summary>Minskd departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a textDepStat")]
        public IWebElement DepartureBox { get; set; }

        /// <summary>Minskd departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a textArrStat")]
        public IWebElement DestinationBox { get; set; }

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6176b")]
        public IWebElement SwitchDirectionButton { get; set; }

        /// <summary>Minskd departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61701\\3a 0\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6173d")]
        public IWebElement MinskDeparture { get; set; }

        /// <summary>Minsk destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed614a5\\3a 0\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61451")]
        public IWebElement MinskDestination { get; set; }

        /// <summary>Gomel departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61701\\3a 1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6173d")]
        public IWebElement GomelDeparture { get; set; }

        /// <summary>Gomel destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed614a5\\3a 1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61451")]
        public IWebElement GomelDestination { get; set; }

        /// <summary>Brest departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61701\\3a 2\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6173d")]
        public IWebElement BrestDeparture { get; set; }

        /// <summary>Brest destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed614a5\\3a 2\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61451")]
        public IWebElement BrestDestination { get; set; }

        /// <summary>Vitebsk departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61701\\3a 3\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6173d")]
        public IWebElement VitebskDeparture { get; set; }

        /// <summary>Vitebsk destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed614a5\\3a 3\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61451")]
        public IWebElement VitebskDestination { get; set; }

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61701\\3a 4\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6173d")]
        public IWebElement MogilevDeparture { get; set; }

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed614a5\\3a 4\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61451")]
        public IWebElement MogilevDestination { get; set; }

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61701\\3a 5\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed6173d")]
        public IWebElement GrodnoDeparture { get; set; }

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NGMO80ABJ9NPD12001_\\3a form1\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed614a5\\3a 5\\3a ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61451")]
        public IWebElement GrodnoDestination { get; set; }
    }
}