using MYPROJECT;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;


namespace MYPROJECT
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static AboutPage About
        {
            get { return GetPage<AboutPage>(); }
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }

        public static RegisterPage Register
        {
            get { return GetPage<RegisterPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ManageAccountPage ManageAccount
        {
            get { return GetPage<ManageAccountPage>(); }
        }

        public static LoginControl LoginEmp
        {
            get { return GetPage<LoginControl>(); }

        }

        public static LeftPanelNavigationPage LeftPanelNavigation
        {
            get { return GetPage<LeftPanelNavigationPage>(); }

        }
        public static Identification Identification
        {
            get { return GetPage<Identification>(); }
        }
        public static IherbHeaderPage IherbHeader
        {
            get { return GetPage<IherbHeaderPage>(); }

        }
        public static IhLogInPage IhLogIn
        {

            get { return GetPage<IhLogInPage>(); }

        }

        public static FacebookPage facebook
        {
            get { return GetPage<FacebookPage>(); }

        }
        public static void SwitchTo(string frame)
        {
            ((IWebDriver)Browser.Driver).SwitchTo().Frame(frame);
        }

    }
}
