﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Linq;


namespace MYPROJECT
{
    public static class SeleniumGetMethods
    {

        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static string GetLabelText(this IWebElement element)
        {
            return element.Text;
        }
    }
}

