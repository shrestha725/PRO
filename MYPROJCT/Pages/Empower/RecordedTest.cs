using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Test
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://adfs.empowerpay.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/EmpowerSTS/FormsSignIn.aspx?ReturnUrl=%2fEmpowerSTS%2fDefault.aspx%3fwa%3dwsignin1.0%26wtrealm%3dhttp%253a%252f%252fadfs.empowerpay.com%252fadfs%252fservices%252ftrust%26wctx%3dBaseUrl%253dhttps%25253a%25252f%25252fadfs.empowerpay.com%25252fadfs%25252fls%25252f%255cwtrealm%253dhttps%25253a%25252f%25252fwww.empowerpay.com%25252fEmpower%25252fDefault.aspx%255cwreply%253dhttps%25253a%25252f%25252fwww.empowerpay.com%25252fEmpower%25252fDefault.aspx%255cwhr%253dhttps%25253a%25252f%25252fadfs.empowerpay.com%25252fEmpowerSTS%25252f%255cwctx%253drm%25253d1%252526id%25253dpassive%252526ru%25253d%2525252FEmpower%2525252F%255cId%253did-c1e78bbe-0d64-4018-b572-5f90e98cc254%26wct%3d2015-08-11T18%253a16%253a25Z%26whr%3dhttps%253a%252f%252fadfs.empowerpay.com%252fEmpowerSTS%252f&wa=wsignin1.0&wtrealm=http%3a%2f%2fadfs.empowerpay.com%2fadfs%2fservices%2ftrust&wctx=BaseUrl%3dhttps%253a%252f%252fadfs.empowerpay.com%252fadfs%252fls%252f%5cwtrealm%3dhttps%253a%252f%252fwww.empowerpay.com%252fEmpower%252fDefault.aspx%5cwreply%3dhttps%253a%252f%252fwww.empowerpay.com%252fEmpower%252fDefault.aspx%5cwhr%3dhttps%253a%252f%252fadfs.empowerpay.com%252fEmpowerSTS%252f%5cwctx%3drm%253d1%2526id%253dpassive%2526ru%253d%25252FEmpower%25252F%5cId%3did-c1e78bbe-0d64-4018-b572-5f90e98cc254&wct=2015-08-11T18%3a16%3a25Z&whr=https%3a%2f%2fadfs.empowerpay.com%2fEmpowerSTS%2f");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderMain_ClientCodeTextBox")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderMain_ClientCodeTextBox")).SendKeys("998");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderMain_UsernameTextBox")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderMain_UsernameTextBox")).SendKeys("ashrestha@empowersoftware.com");
            driver.FindElement(By.Id("PasswordTextBox")).Clear();
            driver.FindElement(By.Id("PasswordTextBox")).SendKeys("Puti123!");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolderMain_btnLogin")).Click();
            driver.FindElement(By.CssSelector("span.rpText")).Click();
            driver.FindElement(By.CssSelector("span.rpOut.rpNavigation > span.rpText")).Click();
            Thread.Sleep(10000);
            // ERROR: Caught exception [ERROR: Unsupported command [selectFrame | Home | ]]
            //driver.FindElement(By.Id("ctl19_E_Identification_FirstName")).Clear();
            driver.FindElement(By.Id("ctl19_E_Identification_FirstName")).SendKeys("ANIL");
            driver.FindElement(By.Id("ctl19_E_Identification_GenderCode_Arrow")).Click();
            driver.FindElement(By.XPath("//div[@id='ctl19_E_Identification_GenderCode_DropDown']/div/ul/li[2]/div/span[2]")).Click();
            driver.FindElement(By.Id("ctl19_E_Identification_GenderCode_Input")).Clear();
            driver.FindElement(By.Id("ctl19_E_Identification_GenderCode_Input")).SendKeys("Male");
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
