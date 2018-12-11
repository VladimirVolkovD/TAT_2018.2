namespace DEV_9
{
    /// <summary>
    /// Container for all locators
    /// </summary>
    class Locators
    {
        /// <summary>
        /// Container for login page locators
        /// </summary>
        public class LoginPageLocators
        {
            public string VkPageLocator
            {
                get { return "https://vk.com"; }
            }

            public string EmailField
            {
                get { return "index_email"; }
            }

            public string PasswordField
            {
                get { return "index_pass"; }
            }

            public string LoginButton
            {
                get { return "index_login_button"; }
            }
        }

        /// <summary>
        /// Container for messages page locators
        /// </summary>
        public class MessagesPageLocators
        {
            public string MessagePage
            {
                get { return "https://vk.com/im"; }
            }

            public string UnreadMessage
            {
                get { return "ui_rmenu_unread"; }
            }

            public string DialogsLocator
            {
                get { return "im_dialogs"; }                
            }        
            
            public string Message
            {
                get { return "nim-dialog--cw"; }
            }

            public string MessageName
            {
                get { return "nim-dialog--name"; }
            }

            public string MessageText
            {
                get { return "nim-dialog--text-preview"; }
            }
        }
    }
}
