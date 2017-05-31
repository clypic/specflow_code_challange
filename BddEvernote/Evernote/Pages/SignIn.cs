using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BddEvernote.Evernote.Pages
{
    class SignIn
    {
        private Common _common;
        private Helpers _helpers = new Helpers();
        private IWebDriver _driver;
        

        public SignIn(IWebDriver driver)
        {
            _common = new Common();
            _driver = driver;
        }

        public void Navigate()
        {
            string fullUrl = String.Concat(_common.evernoteUrl, "/Login.action");
            _driver.Navigate().GoToUrl(fullUrl);
        }

        public IWebElement GetUsernameInputField()
        {
            var usernameInputField = _driver.FindElement(By.Id("username"));
            return usernameInputField;
        }

        public IWebElement GetPasswordInputField()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_helpers.GetTimeout()));
            var passwordInputField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
            return passwordInputField;
        }

        public void EnterUsername(string username)
        {
            IWebElement usernameInputField = GetUsernameInputField();
            usernameInputField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            IWebElement passwordInputField = GetPasswordInputField();
            passwordInputField.SendKeys(password);
        }

        public void ClickSignInButton()
        {
            IWebElement signInButton = _driver.FindElement(By.Id("loginButton"));
            signInButton.Click();
        }


        public void EnterUsernameAndSignIn(string username)
        {
            EnterUsername(username);
            ClickSignInButton();
        }

        public void EnterPasswordAndSignIn(string password)
        {
            EnterPassword(password);
            ClickSignInButton();
        }

        public void User(string username, string password)
        {
            EnterUsernameAndSignIn(username);
            EnterPasswordAndSignIn(password);
        }

        public string PasswordResponseMessage()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_helpers.GetTimeout()));
            var responseMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("responseMessage")));
            var responseMessageText = responseMessage.Text;
            return responseMessageText;
        }

        

    }
}
