using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace MYPROJECT
{
    public static class SeleniumSetMethods
    {

        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
