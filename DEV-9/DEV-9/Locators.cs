using OpenQA.Selenium;

namespace DEV_9
{
    /// <summary>
    /// Container for all locators
    /// </summary>
    static class Locators
    {
        /// <summary>
        /// Container for login page locators
        /// </summary>
        public static class LoginPageLocators
        {
            public static string VkPageLocator
            {
                get { return "https://vk.com"; }
            }

            public static By EmailField
            {
                get { return By.Id("index_email"); }
            }

            public static By PasswordField
            {
                get { return By.Id("index_pass"); }
            }

            public static By LoginButton
            {
                get { return By.Id("index_login_button"); }
            }
        }

        /// <summary>
        /// Container for messages page locators
        /// </summary>
        public static class MessagesPageLocators
        {
            public static string MessagePage
            {
                get { return "https://vk.com/im"; }
            }

            public static By UnreadMessage
            {
                get { return By.Id("ui_rmenu_unread"); }
            }

            public static By DialogsLocator
            {
                get { return By.Id("im_dialogs"); }                
            }        
            
            public static By Message
            {
                get { return By.ClassName("nim-dialog--cw"); }
            }

            public static By MessageName
            {
                get { return By.ClassName("nim-dialog--name"); }
            }

            public static By MessageText
            {
                get { return By.ClassName("nim-dialog--text-preview"); }
            }
        }
    }
}
