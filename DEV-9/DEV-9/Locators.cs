using OpenQA.Selenium;

namespace DEV_9
{
    /// <summary>
    /// Container for all locators.
    /// </summary>
    static class Locators
    {
        /// <summary>
        /// Container for login page locators.
        /// </summary>
        public static class LoginPageLocators
        {
            public static string VkPageLocator => "https://vk.com";

            public static By EmailField => By.Id("index_email");

            public static By PasswordField => By.Id("index_pass");

            public static By LoginButton => By.Id("index_login_button");
        }

        /// <summary>
        /// Container for messages page locators.
        /// </summary>
        public static class MessagesPageLocators
        {
            public static string MessagePage => "https://vk.com/im";

            public static By UnreadMessage => By.Id("ui_rmenu_unread");

            public static By DialogsLocator => By.Id("im_dialogs");

            public static By Message => By.ClassName("nim-dialog--cw");

            public static By MessageName => By.ClassName("nim-dialog--name");

            public static By MessageText => By.ClassName("nim-dialog--text-preview");
        }
    }
}
