using PageObjLib.Factories;
using PageObjLib.Pages;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SauceDemo.WebPages
{
    internal static class LoginPage
    {
        private const string _url = "https://www.saucedemo.com";

        private static Dictionary<string, string> LoginCredentials = new()
        {
            {"standard", "standard_user"},
            {"locked", "locked_out_user"},
            {"problem", "problem_user"},
            {"performance", "performance_glitch_user"},
            {"error", "error_user"},
            {"visual", "visual_user"}
        };

        private static IWebElement UserNameInput() => Page.GetElement(By.Id("user-name"));
        private static IWebElement PasswordInput() => Page.GetElement(By.Name("password"));
        private static IWebElement LoginButton() => Page.GetElement(By.XPath("//input[@id='login-button']"));
        
        private static IWebElement PasswordForAll() => Page.GetElement(By.XPath("//*[text()='Password for all users:']"));
        private static IWebElement LoginLogo() => Page.GetElement(By.CssSelector(".login_logo"));
        private static IWebElement We() => Page.GetElement(By.Id("login_credentials"));

        public static bool Elements()
        {   
            Page.GoUrl(_url);
            var df = We().Text;
            Console.WriteLine(df);
            return UserNameInput() != null;

        }
    }
}
