using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace BddEvernote.Evernote.Steps
{
    using Pages;

    [Binding]
    public class NotesSteps
    {
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


        [Given(@"User signed in")]
        public void GivenUserSignedIn()
        {
            _home.Navigate();
            _home.ClickSignIn();
            _signIn.User(_user.GetExistingName(), _user.GetExistingPass());
            Assert.IsTrue(_userHome.isAvatarButtonDisplayed());
        }

        [Given(@"new Note with ""(.*)"" is created")]
        public void GivenNewNoteWithIsCreated(string noteTitle)
        {
            _userHome.NewNoteClick();
            _userHome.NewNoteAddTitle(noteTitle.ToString());
            //_userHome.NewNoteAddBody("some boby text");
        }

        [Then(@"Note ""(.*)"" must be listed")]
        public void ThenNoteMustBeListed(string noteTitle)
        {
            var noteTitleText = _userHome.NoteTitleExists(noteTitle);
            Assert.IsNotEmpty(noteTitleText);
        }

        [When(@"new Note is done")]
        public void WhenNewNoteIsDone()
        {
            _userHome.NewNoteClickDone();
        }
        
        [When(@"User signed-out")]
        public void WhenNserSigned_Out()
        {
            _userHome.SignOut();
        }
        
        [When(@"User signed-in")]
        public void WhenUserSigned_In()
        {
            _home.Navigate();
            _home.ClickSignIn();
            _signIn.User(_user.GetExistingName(), _user.GetExistingPass());
            Assert.IsTrue(_userHome.isAvatarButtonDisplayed());
        }
    }
}
