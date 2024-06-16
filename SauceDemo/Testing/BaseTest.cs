using PageObjLib.Factories;
using PageObjLib.Pages;
using SauceDemo.WebPages;
using Xunit;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace SauceDemo.Tests
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp() => BasePage.OpenPage();

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
            Driver.QuitWait();
            Page.QuitActions();
        }
    }
}
