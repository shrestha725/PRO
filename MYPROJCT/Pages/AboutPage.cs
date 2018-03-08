using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MYPROJECT;

namespace MYPROJECT
{
    public class AboutPage
    {
        public void Goto()
        {
            Pages.TopNavigation.About();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("About");
        }
    }
}

