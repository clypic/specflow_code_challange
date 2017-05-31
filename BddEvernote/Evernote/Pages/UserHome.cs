using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BddEvernote.Evernote.Pages
{
    using Pages;
    using System.Collections.Generic;

    class UserHome
    {
        private Common _common;
        private Helpers _helpers = new Helpers();
        private IWebDriver _driver;

        public UserHome(IWebDriver driver)
        {
            _common = new Common();
            _driver = driver;
        }
        
        public IWebElement GetAvatarButton()
        {
            IWebElement avatarButton = _driver.FindElement(By.Id("gwt-debug-AccountMenu-avatar"));
            return avatarButton;
        }

        public Boolean isAvatarButtonDisplayed()
        {
            IWebElement avatarButton = GetAvatarButton();
            return avatarButton.Displayed;
        }

        // Account Menu. By.Id("gwt-debug-AccountMenuView-root")
        public void SignOut()
        {
            IWebElement avatarButton = GetAvatarButton();
            avatarButton.Click();
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_helpers.GetTimeout()));
            var logoutButton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gwt-debug-AccountMenu-logout")));
            logoutButton.Click();
        }

        public string NoteTitleExists(string noteTitle)
        {
            //IWebDriver noteListWrapper = _driver.FindElement(By.ClassName("NotesView-ScrollWindow"));
            string xpath = String.Concat("//div[contains(text(), \"", noteTitle, "\")]");
            var noteTitleText = _driver.FindElement(By.XPath(xpath)).Text;
            return noteTitleText;
        }

        public void NewNoteClick()
        {
            IWebElement newNoteButton = _driver.FindElement(By.Id("gwt-debug-Sidebar-newNoteButton"));
            newNoteButton.Click();
        }

        public void NewNoteAddTitle(string noteTitle)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_helpers.GetTimeout()));
            var newNoteTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gwt-debug-NoteTitleView-textBox")));
            newNoteTitle.SendKeys(noteTitle);
            newNoteTitle.SendKeys(Keys.Enter);
        }

        public void NewNoteAddBody(string noteBody)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_helpers.GetTimeout()));
            var newNoteBody = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gwt-debug-NoteContentEditorView-root")));
            newNoteBody.SendKeys(noteBody);
        }

        public void NewNoteClickDone()
        {
            IWebElement doneButton = _driver.FindElement(By.Id("gwt-debug-NoteAttributes-doneButton"));
            doneButton.Click();
        }
    }
}
