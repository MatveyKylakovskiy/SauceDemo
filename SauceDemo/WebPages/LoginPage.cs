using PageObjLib.Factories;
using PageObjLib.Pages;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SauceDemo.WebPages
{
    internal static class LoginPage
    {
        private const string _url = "https://www.saucedemo.com";

        private static IWebElement UserNameInput() => Page.GetElement(By.Id("user-name"));
        private static IWebElement PasswordInput() => Page.GetElement(By.Name("password"));
        private static IWebElement LoginButton() => Page.GetElement(By.XPath("//input[@id='login-button']"));
        private static IWebElement LoginCredentials() => Page.GetElement(By.ClassName("login_credentials_wrap"));

    }
}
