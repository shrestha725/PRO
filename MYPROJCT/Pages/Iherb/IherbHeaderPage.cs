using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace MYPROJECT
{
    public class IherbHeaderPage
    {
        [FindsBy(How = How.LinkText, Using = "Worlds Best Value")]
        public IWebElement WorldsBestValueLnk;

        public IWebElement NewAndroidAppLnk = Browser.Driver.FindElement(By.LinkText("New Android App"));
        public IWebElement NewLnk = Browser.Driver.FindElement(By.LinkText("New"));
        public IWebElement SuperSpecialsLnk = Browser.Driver.FindElement(By.LinkText("Super Specials!"));
        public IWebElement TrialsLnk= Browser.Driver.FindElement(By.LinkText("Trials"));
        public IWebElement AugustVIPSpecialLnk= Browser.Driver.FindElement(By.LinkText("August VIP Special!"));
        public IWebElement OffInternationalLnk= Browser.Driver.FindElement(By.LinkText("95% Off International"));
        public IWebElement InputSearchInput= Browser.Driver.FindElement(By.Id("txtSearch"));
        public IWebElement SearchBtn= Browser.Driver.FindElement(By.Id("searchBtn"));
        public IWebElement SignInLnk= Browser.Driver.FindElement(By.Id("sign-in"));
        public IWebElement MyAccountButton= Browser.Driver.FindElement(By.Id("my-account-button"));
        public IWebElement CartQtyImg= Browser.Driver.FindElement(By.Id("cart-qty"));
        public IWebElement BrandsLnk = Browser.Driver.FindElement(By.LinkText("Brands"));
        public IWebElement SupplementsLnk= Browser.Driver.FindElement(By.LinkText("Supplements"));
        public IWebElement HerbsLnk= Browser.Driver.FindElement(By.LinkText("Herbs"));
        public IWebElement BathLnk = Browser.Driver.FindElement(By.LinkText("Bath"));
        public IWebElement BeautyLnk = Browser.Driver.FindElement(By.LinkText("Beauty"));
        public IWebElement GroceryLnk = Browser.Driver.FindElement(By.LinkText("Grocery"));
        public IWebElement BabyLnk = Browser.Driver.FindElement(By.LinkText("Baby"));
        public IWebElement SportsLnk = Browser.Driver.FindElement(By.LinkText("Sports"));
        public IWebElement HomePetsLnk = Browser.Driver.FindElement(By.LinkText("Home & Pets"));
        public IWebElement ConditionsLnk = Browser.Driver.FindElement(By.LinkText("Conditions"));
        //private IWebElement Lbl = Browser.Driver.FindElement(By.XPath("html/body/div[3]/div[1]/div[1]/div[2]/form/div[2]/div[1]"));

 public void WorldsBestValue()
        {
            WorldsBestValueLnk.Click();
        }

 public void NewAndroidApp()
        {
            NewAndroidAppLnk.Clicks();
        }

 public void New()
        {
            NewLnk.Clicks();
        } 
 public void SuperSpecials()
            {

            SuperSpecialsLnk.Clicks();
            }  

 public void Trials()
            {

            TrialsLnk.Clicks();
            }  
 public void AugustVIPSpecial()
            {

            AugustVIPSpecialLnk.Clicks();
            }  
public void OffInternational()
            {

            OffInternationalLnk.Clicks();
            }
        public void EnterInputSearch(string value)
        {
            InputSearchInput.EnterText(value);

        }  
 public void Search()
            {
            SearchBtn.Clicks();
           

            }  
 public void SignIn()
            {
            SignInLnk.Clicks();
            
            }  
 public void MyAccount()
            {
            MyAccountButton.Clicks();

            }  
 public void CartQty()
            {

            CartQtyImg.Clicks();
            }  
 public void Brands()
            {
            BrandsLnk.Clicks();

            }  
 public void Supplements()
            {
            SupplementsLnk.Clicks();

            }  
 public void Herbs()
            {

            HerbsLnk.Clicks();
            }  
 public void Bath()
            {
            BathLnk.Clicks();

            }  
 public void Beauty()
            {

            BeautyLnk.Clicks();
            }  
 public void Grocery()
            {

            GroceryLnk.Clicks();
            }  
 public void Baby()
            {
            BabyLnk.Clicks();

            }  
public void Sports()
            {
            SportsLnk.Clicks();

            }  
public void HomePets()
            {

            HomePetsLnk.Clicks();
            }  
 public void Conditions()
            {
            ConditionsLnk.Clicks();

            }  

    }
}
