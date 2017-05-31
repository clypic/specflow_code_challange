using System;

namespace BddEvernote.Evernote
{
    class User
    {
        private string _existing_name = Properties.Settings.Default.ExistingUserName;
        private string _existing_pass = Properties.Settings.Default.ExistingUserPass;
        private string _nonExisting_name = Properties.Settings.Default.NonExistingUserName;
        private string _nonExisting_pass = Properties.Settings.Default.NonExistingUserPass;


        public string GetExistingName()
        {
            return _existing_name;
        }
        public string GetExistingPass()
        {
            return _existing_pass;
        }
        public string GetNonExistingName()
        {
            return _nonExisting_name;
        }
        public string GetNonExistingPass()
        {
            return _nonExisting_pass;
        }
    }
}
