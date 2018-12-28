using System;
using NUnit.Framework;
using Logick;

namespace Tests
{
    [TestFixture]
    class LogInTest:Test
    {
         LogIn LogIn = new LogIn(driver);

        [Test]
        public void CorrectLogIn()
        {             
            if (LogIn.CorrectLogin("vladimir12.03", "djg44s6d"))
            {
                throw new Exception();
            }
        }

        [Test]
        public void WrongLogIn()
        {
            LogIn.WrongLogin("strangelogintext", "wrong");            
        }

        [Test]
        public void WrongPassword()
        {
            LogIn.WrongPassword("vladimir12.03", "wrong");           
        }
    }

    [TestFixture]
    class RoutesTest : Test
    {
        Routes routes = new Routes(driver);

        [Test]
        public void ElectronicRegistration()
        {
            routes.ElectronicRegistration(driver);
        }

        [Test]
        public void TimeBox()
        {
            routes.TimeBox();
        }

        [Test]
        public void ClickCity()
        {
            routes.ClickCityLinks();
        }
    }
}
            
        


       
        

    
