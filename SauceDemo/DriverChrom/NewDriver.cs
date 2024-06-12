using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.DriverChrom
{
    internal  class NewDriver
    {
        private static IWebDriver? _driver;

        public static IWebDriver GetDrivers()
        {
            if (_driver == null)
            {
              _driver = new ChromeDriver();
            }

            return _driver;
        }

        public static void Quit()
        {
            _driver?.Quit();

        }
    }
}
