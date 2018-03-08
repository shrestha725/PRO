using MYPROJECT;

namespace MYPROJECT
{
    public class HomePage
    {
            public void Goto()
        {
            Pages.TopNavigation.Home();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Home");
        }
    }
    }

