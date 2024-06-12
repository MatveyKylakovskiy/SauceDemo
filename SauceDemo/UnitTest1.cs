using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjLib.Factories;
using SauceDemo.DriverChrom;
using SauceDemo.WebPages;

namespace SauceDemo
{
    public class Tests
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
           driver = NewDriver.GetDrivers();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        [Test]
        public void Test1()
        { 
            driver.Navigate().GoToUrl("https://www.saucedemo.com");

            IWebElement dr = driver.FindElement(By.Id("user-name"));

            Assert.IsTrue(dr != null);
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");

            IWebElement dr = driver.FindElement(By.Id("user-name"));

            Assert.IsTrue(dr != null);
        }

        /*[Test]
        public void Test3()
        {


            LoginPage.Elements();

            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            NewDriver.GetDrivers().Navigate().GoToUrl("https://www.saucedemo.com");

            IWebElement dr = NewDriver.GetDrivers().FindElement(By.Id("user-name"));

            Assert.IsTrue(dr != null);
        }*/

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}