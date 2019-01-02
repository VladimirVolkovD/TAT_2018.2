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
        public string brestText = "БРЕСТ-ЦЕНТРАЛЬНЫЙ";
        public string vitebskText = "ВИТЕБСК-ПАССАЖИРСКИЙ";
        public string grodnoText = "ГРОДНО";
        public string gomelText = "ГОМЕЛЬ";
        public string mogilevText = "МОГИЛЁВ-1";
        public string minskText = "МИНСК-ПАССАЖИРСКИЙ"; 
        IList<IWebElement> timeCell = new List<IWebElement>();

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.Id, Using = "logoutlink")]
        public IWebElement LogoutLink { get; set; }

        /// <summary>Departure Box.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a textDepStat")]
        public IWebElement DepartureBox { get; set; }

        /// <summary>Departure warning icon.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message1")]
        public IWebElement DepartureWarIcon { get; set; }

        /// <summary>Destination box.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a textArrStat")]
        public IWebElement DestinationBox { get; set; }

        /// <summary>Destination warning icon.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message2")]
        public IWebElement DestinationWarIcon { get; set; }
        
        /// <summary>Switch direction button.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed6176b")]
        public IWebElement SwitchDirectionButton { get; set; }

        /// <summary>Minskd departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61701\\3a 0\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61727")]
        public IWebElement MinskDeparture { get; set; }

        /// <summary>Minsk destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614a5\\3a 0\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614bb")]
        public IWebElement MinskDestination { get; set; }

        /// <summary>Gomel departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61701\\3a 1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61727")]
        public IWebElement GomelDeparture { get; set; }

        /// <summary>Gomel destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614a5\\3a 1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614bb")]
        public IWebElement GomelDestination { get; set; }

        /// <summary>Brest departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61701\\3a 2\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61727")]
        public IWebElement BrestDeparture { get; set; }

        /// <summary>Brest destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614a5\\3a 2\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614bb")]
        public IWebElement BrestDestination { get; set; }

        /// <summary>Vitebsk departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61701\\3a 3\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed6173d")]
        public IWebElement VitebskDeparture { get; set; }

        /// <summary>Vitebsk destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614a5\\3a 3\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614bb")]
        public IWebElement VitebskDestination { get; set; }

        /// <summary>Mogilev departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61701\\3a 4\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61727")]
        public IWebElement MogilevDeparture { get; set; }

        /// <summary>Mogilev destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614a5\\3a 4\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614bb")]
        public IWebElement MogilevDestination { get; set; }

        /// <summary>Grodno departure link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61701\\3a 5\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed61727")]
        public IWebElement GrodnoDeparture { get; set; }

        /// <summary>Grodno destination link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614a5\\3a 5\\3a ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed614bb")]
        public IWebElement GrodnoDestination { get; set; }

        /// <summary>Logout link.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a dob")]
        public IWebElement DateBox { get; set; }

        /// <summary>Warning icon if wrong date inputed.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message3")]
        public IWebElement DateWarIcon { get; set; }

        /// <summary>Box witn time cells.</summary>
        [FindsBy(How = How.ClassName, Using = "time")]
        private IWebElement timeBoxes;

        /// <summary>Unpessed Time Box </summary>
        [FindsBy(How = How.ClassName, Using = "time_ch")]
        public IList<IWebElement> TimeBoxUnpressed;        

        /// <summary>Check box for electronic registration.</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1\\3a onlyER")]
        public IWebElement CheckBoxElectronicRegistration { get; set; }

        /// <summary>Continue button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExButton")]
        public IWebElement ContinueButton { get; set; }

        /// <summary>Reset button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExRedButton")]
        public IWebElement ResetButton { get; set; }

        /// <summary>Departure Time Boxes.</summary>
        public IWebElement TimeBox(int cellNumber)
        {
            timeCell = timeBoxes.FindElements(By.TagName("a"));
            return timeCell[cellNumber];
        }

        /// <summary>Departure Time Boxes.</summary>
        public void ClickTimeBox(int cellNumber)
        {
            timeCell[cellNumber].Click();
        }

        /// <summary>Click the electronic registration box.</summary>
        public void ClickElectronicRegistrationBox()
        {
            CheckBoxElectronicRegistration.Click();
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
            ContinueButton.Click() ;
        }

        ///<summary>Click reset button.</summary>
        public void ClickResetButton()
        {
            ResetButton.Click();
        }

        ///<summary>Send date to the departure box.</summary>
        /// <param name="station.">Name of station.</param>
        public void SendDepartureBox(string station)
        {
            DepartureBox.SendKeys(station);
        }

        ///<summary>Send date to the destination box.</summary>
        /// <param name="station.">Name of station.</param>
        public void SendDestinationBox(string station)
        {
            DestinationBox.SendKeys(station);
        }
    }
}
