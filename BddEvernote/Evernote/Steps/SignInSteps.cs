using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BddEvernote.Evernote.Steps
{
    using Pages;
    using Library;


    [Binding]
    public class SignInSteps
    {
        string _username;
        string _password;
        Helpers _helpers = new Helpers();
        User _user = new User();
        IWebDriver _driver;
        SignIn _signIn;
        Home _home;
        UserHome _userHome;


        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver(_helpers.GetChromeDriverPath());
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_helpers.GetTimeout());
            _signIn = new SignIn(_driver);
            _home = new Home(_driver);
            _userHome = new UserHome(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }


        [Given(@"existing user")]
        public void GivenExistingUser()
        {
            _username = _user.GetExistingName();
            _password = _user.GetExistingPass();
        }

        [Given(@"non-existing user")]
        public void GivenNonExistingUser()
        {
            _username = _user.GetNonExistingName();
            _password = _user.GetNonExistingPass();
        }

        [When(@"Home page is loaded")]
        public void WhenHomePageIsLoaded()
        {
            _home.Navigate();
        }
        
        [When(@"Sign In button is clicked")]
        public void WhenSignInButtonIsClicked()
        {
            _home.ClickSignIn();
        }
        
        [When(@"enter username and click continue")]
        public void WhenEnterUsernameAndClickContinue()
        {
            _signIn.EnterUsernameAndSignIn(_username);
        }
        
        [When(@"enter password and click Sign In")]
        public void WhenEnterPasswordAndClickSignIn()
        {
            _signIn.EnterPasswordAndSignIn(_password);
        }

        [Then(@"loaded page must be User home page")]
        public void ThenLoadedPageMustBeUserHomePage()
        {
            Assert.IsTrue(_userHome.isAvatarButtonDisplayed());
            _userHome.SignOut();
        }

        [Then(@"an error is displayed on form")]
        public void ThenAnErrorIsDisplayedOnForm()
        {
            var responseText = _signIn.PasswordResponseMessage();
            Assert.AreEqual(responseText, "There is no account for the username or email you entered.");
        }

    }
}
