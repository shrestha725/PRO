using MYPROJECT.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace MYPROJECT
{
    public class LeftPanelNavigationPage
    {
        [FindsBy(How = How.XPath, Using = "html/body/form/div[4]/div/div/table/tbody/tr[2]/td/div[1]/div/table/tbody/tr/td[1]/div/table/tbody/tr/td[2]/div/table/tbody/tr[2]/td/div/span/div/div/ul/li[1]/a/span/span[2]")]
        private IWebElement employeeProfileLink;

        //[FindsBy(How = How.XPath, Using ="html/body/form/div[4]/div/div/table/tbody/tr[2]/td/div[1]/div/table/tbody/tr/td[1]/div/table/tbody/tr/td[2]/div/table/tbody/tr[2]/td/div/span/div/div/ul/li[1]/div/ul/li[1]/a/span/span[2]")]
        //private IWebElement IdnetificationBtn;
        private IWebElement IdentificationBtn = Browser.Driver.FindElement(By.XPath("html/body/form/div[4]/div/div/table/tbody/tr[2]/td/div[1]/div/table/tbody/tr/td[1]/div/table/tbody/tr/td[2]/div/table/tbody/tr[2]/td/div/span/div/div/ul/li[1]/div/ul/li[1]/a/span/span[2]"));

        [FindsBy(How = How.Id, Using = "ctl19_E_Identification_GenderCode_Input")]
        private IWebElement genderTextField;
        ////[FindsBy(How = How.Id, Using = "ctl19_E_Identification_FirstName")]
        ////private IWebElement firstName;
       // private IWebElement firstName = Browser.Driver.FindElement(By.Id("ctl19_E_Identification_FirstName"));

        
        
        
        
        
       public void EmployeeProfileClick()
        {
            employeeProfileLink.Click();
        }

        public void IdentificationClick()
        {
           IdentificationBtn.Click();
            
        }
        //public void SelectDropDownForGender(string gender)
        //{
           
        //    genderTextField.SelectDropDown(gender);

        //}

        //public void EnterFirstName(string fName)
        //{
        //    //firstName.EnterText(fName);
        //    firstName.SendKeys(fName);

        //}

    }
}
