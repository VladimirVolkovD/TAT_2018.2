using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Pages; 

namespace Logick
{
    public class LogIn
    {
        ChromeDriver _driver;
        LoginMainPage _loginMain;

        public LogIn(ChromeDriver driver)
        {
            _driver = driver;
            _loginMain = new LoginMainPage();
        }

        void SetUp()
        {
           _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/login_main");
           PageFactory.InitElements(_driver, _loginMain);
        }

        void Login(string login, string password)
        {
            _loginMain.EnterLogin(login);
            _loginMain.EnterPassword(password);
            _loginMain.ClickLogInButton();
        }

        public bool CorrectLogin(string login,string password)
        {
            SetUp();
            Login(login, password);
            var rules = new RulesPage();
            var routes = new RoutesPage();            
            PageFactory.InitElements(_driver, rules);
            PageFactory.InitElements(_driver, routes);           
            rules.ClickRadioButton();

            return (string.IsNullOrEmpty(routes.LogoutLink.Text));
        }

        public void WrongLogin(string login, string password)
        {
            SetUp();
            Login(login, password);
            Assert.AreEqual(string.IsNullOrEmpty(_loginMain.LogInWarIcon.Text),false);
        }

        public void WrongPassword(string login, string password)
        {
            SetUp();
            Login(login, password);
            Assert.AreEqual(string.IsNullOrEmpty(_loginMain.PasswWarIcon.Text),false);
        }       
    }
}
