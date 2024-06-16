using PageObjLib.Pages;

namespace SauceDemo.WebPages
{
    internal class BasePage
    {
        private const string _url = "https://www.saucedemo.com";
        public static void OpenPage() => Page.GoUrl(_url);
    }
}