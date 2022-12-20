using FinalProject.Driver;
using FinalProject.Pages;
using OpenQA.Selenium;

namespace FinalProject.Test
{
    public class LoginTests
    {
        private IWebDriver driver = WebDrivers.Instance;


        LoginPage loginpage;


        [SetUp]
        public void Setup()
        {

            WebDrivers.Initialize();
            loginpage = new LoginPage();


        }

        [TearDown]

        public void Close()
        {

            WebDrivers.CleanUp();


        }

        [Test]


        public void TC01_EnterValidData_ShouldBeLogged()
        {
            loginpage.Login("standard_user", "secret_sauce");
            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(WebDrivers.Instance.Url));



        }



        [Test]
        public void TC02_EnterInvalidUserName_ShouldNotBeLoggedInOnPage()
        {
            loginpage.Login("Uros", "secret_sauce");
            Assert.That("Epic sadface: Username and password do not match any user in this service", Is.EqualTo(loginpage.UserNotLogin.Text));
        }
        [Test]
        public void TC03_EnterInvalidPassword_ShouldNotBeLoggedInOnPage()
        {
            loginpage.Login("standard_user", "Uros");
            Assert.That("Epic sadface: Username and password do not match any user in this service", Is.EqualTo(loginpage.UserNotLogin.Text));


        }

        [Test]

        public void TC04_EnterInvalidPasswordAndUsername_ShouldNotBeLoggedInOnPage()

        {
            loginpage.Login("Uros", "Uros");
            Assert.That("Epic sadface: Username and password do not match any user in this service" , Is.EqualTo(loginpage.UserNotLogin.Text));



        }

        
        [Test]
        public void TC05_EnterNoData_ShouldnotBeLogged()
        {
            loginpage.Login("", "");
            Assert.That("Epic sadface: Username is required", Is.EqualTo(loginpage.AssertMessage.Text));
        }


































    }
}
