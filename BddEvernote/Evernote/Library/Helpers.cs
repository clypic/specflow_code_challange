using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BddEvernote.Evernote
{
    class Helpers
    {
        private double _timeout = Convert.ToDouble(Properties.Settings.Default.WebDriverTimeout);
        private string _chromeDriverPath = Properties.Settings.Default.DriverPathChrome;

        public double GetTimeout()
        {
            return _timeout;
        }

        public string GetChromeDriverPath()
        {
            return _chromeDriverPath;
        }
    }
}
