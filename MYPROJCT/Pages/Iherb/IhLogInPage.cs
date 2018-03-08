using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using System.Text;
using System.Collections.Generic;


namespace MYPROJECT
{
    public class IhLogInPage
    {
        
        public IWebElement EmailTxt = Browser.Driver.FindElement(By.Id("UserNameReg"));
        public IWebElement ConfEmailTxt = Browser.Driver.FindElement(By.Id("Email"));
        public IWebElement PassWordTxt = Browser.Driver.FindElement(By.Id("PasswordReg"));
        public IWebElement ConfirmPasswordTxt = Browser.Driver.FindElement(By.Id("ConfirmPassword"));
        public IWebElement CreateAccountBtn = Browser.Driver.FindElement(By.CssSelector("div.signinRow > input[name=\"save\"]"));
        //private IWebElement YesSendMeRadBtn = Browser.Driver.FindElement(By.Id("rademailPref"));
        public IWebElement YesSendMeRadBtn = Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[2]/div[2]/input"));
        public IWebElement NoRadBtn = Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[7]/input"));
        //private IWebElement label = Browser.Driver.FindElement(By.ClassName("labels"));
        public IWebElement EmailAddressLbl = Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[2]/div[1]"));
        public IWebElement ConfirmEmailAddressLbl= Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[3]/div[1]"));
        public IWebElement PasswordLbl= Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[4]/div[1]"));
        public IWebElement ConfirmPasswordLbl= Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[5]/div[1]"));

        //private IWebElement SignInLnk = Browser.Driver.FindElement(By.Id("sign-in"));


        //private IWebElement SignInTxt = Browser.Driver.FindElement(By.ClassName("Sign In"));


        //private IWebElement UserNameTxt = Browser.Driver.FindElement(By.Id("UserNameReg"));
        //private IWebElement UserNameTxt = Browser.Driver.FindElement(By.Id("UserNameReg"));




        //public void SignIn()
        //{
        //    SignInLnk.Clicks();

        //}



        //public void Goto()
        //{
        //    Pages.IhLogIn.SignIn();

        //}

        public bool IsAt()
        {
            return Browser.Title.Contains("Login");
        }

        public void FillNewUserInfo(List<Datacollection> data)
        {
            ExcelUtils.PopulateInCollection(@"C:\Users\ashrestha\Desktop\DataTable.xlsx");

            //EmailTxt.EnterText(data[1]."Email Address");
            EmailTxt.EnterText("shrestha725@yahoo.com");
            ConfEmailTxt.EnterText("shrestha725@yahoo.com");
            PassWordTxt.EnterText("Test123!");
            ConfirmPasswordTxt.EnterText("Test123!");
            YesSendMeRadBtn.Clicks();
            NoRadBtn.Clicks();
            try
            {
                Assert.AreEqual(EmailTxt.GetText(), "shrestha725@yahoo.com");
                Console.WriteLine("my expected result->"+EmailTxt.GetText());
            }
            catch
            {

                Console.WriteLine("Assertion is incorrect: ");
            }
            
        }
        public void VerifyEnteredText()
        {
            EmailTxt.GetText();
            Assert.AreEqual(EmailTxt.GetText(),"Anil");
           
        }
        public void verifyLabel()
        {
            //var coll = label.FindElements(By.TagName("label"));
            //foreach (var lab in coll)
            //{


            //    Console.WriteLine(label);
            //}


            //IWebElement kabel = Browser.Driver.FindElement(By.Id)


            //List<IWebElement> list = label;

            //for (int i = 0; i < list.size; i++)
            //{

            //list.get(i).getText();
            //    string y = label.GetText();
            //Console.WriteLine(y);

            //System.out.println(myTestDriver.findElement(By.className("email-label")).getText());

            Console.WriteLine(EmailAddressLbl.GetLabelText());
            Console.WriteLine(ConfirmEmailAddressLbl.GetLabelText());
            Console.WriteLine(PasswordLbl.GetLabelText());
            Console.WriteLine(ConfirmPasswordLbl.GetLabelText());
            
            Console.ReadLine();
        }
           

        }



    }

