using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace BddEvernote.Evernote.Pages
{
    class Home
    {
        private Common _common;
        private IWebDriver _driver;

        public Home(IWebDriver driver)
        {
            _common = new Common();
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(_common.evernoteUrl);
        }

        public IWebElement SignInButton()
        {
            return _driver.FindElement(By.LinkText("Sign In"));
        }

        public void ClickSignIn()
        {
            SignInButton().Click();
        }
    }
}
