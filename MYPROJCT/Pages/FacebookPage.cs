using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;


namespace MYPROJECT
{
    public class FacebookPage
    {
        private IWebElement monthF= Browser.Driver.FindElement(By.Id("month"));

        public void selectMonth(string valueM)
        {
            monthF.SelectDropDown(valueM);
            Console.WriteLine(monthF.GetTextFromDDL());

        }

        public void GetSelectedMonthF()
        {

            monthF.GetTextFromDDL();
        }

            
            }
}
