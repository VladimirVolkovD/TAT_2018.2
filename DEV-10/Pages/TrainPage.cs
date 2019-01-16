using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class TrainPage
    {
        //For checking that we on the train page.
        /// <summary>Text on the train page.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:text31")]
        public IWebElement TrainText;
    }
}