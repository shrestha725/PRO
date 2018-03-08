using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;


namespace MYPROJECT
{
    public class LoginControl
    {

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderMain_ClientCodeTextBox")]
        private IWebElement clientCodeTextField;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderMain_UsernameTextBox")]
        private IWebElement userIDTextField;

        [FindsBy(How = How.Id, Using = "PasswordTextBox")]
        private IWebElement passWordTextBox;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolderMain_btnLogin")]
        private IWebElement submitButton;


        public  void login()
        {
            //clientCodeTextField.SendKeys("998");
            clientCodeTextField.EnterText("998");
            //SeleniumGetMethos.GetText(clientCodeTextField);
            //System.Threading.Thread.Sleep(10000);
            //Assert.AreEqual(SeleniumGetMethos.GetText(clientCodeTextField), "998");
            userIDTextField.SendKeys("ashrestha@empowersoftware.com");
            passWordTextBox.SendKeys("Pti123!");
            submitButton.Click();
            //submitButton.Clicks();
        }
        public void EnterLoginInfo()
            {
               clientCodeTextField.EnterText("998");
               userIDTextField.EnterText("ashrestha@empowersoftware.com");
               passWordTextBox.EnterText("Puti123!");
                System.Threading.Thread.Sleep(10000);
                //submitButton.Clicks();
                System.Threading.Thread.Sleep(10000);
                
            Console.WriteLine(SeleniumGetMethods.GetText(userIDTextField));

        
            }




        }
    }



