using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BddEvernote.Evernote.Library
{
    class WebDriverSession
    {
        private Helpers _helpers = new Helpers();
        private string _webDriverPath = Properties.Settings.Default.DriverPathChrome;
        private IWebDriver _driver;

        public WebDriverSession()
        {
            _driver = new ChromeDriver(_webDriverPath);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_helpers.GetTimeout());
        }

        public IWebDriver GetWebDriver()
        {
            return _driver;
        }
    }
}
