using System.Runtime.InteropServices;
using MYPROJECT.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace MYPROJECT
{
    public class Identification
    {
        //[FindsBy(How = How.XPath, Using = "html/body/form/div[4]/div[2]/div[2]/table/tbody/tr[1]/td/div/table/tbody/tr[2]/td/div[2]/div[1]/div[1]/div/span/table/tbody/tr[3]/td[9]/div/table/tbody/tr/td[1]/input")]
        //private IWebElement genderTextField;

        [FindsBy(How = How.Id, Using = "ctl19_E_Identification_GenderCode_Input")]
        private IWebElement genderTextField;

        [FindsBy(How = How.Id, Using = "ctl19_E_Identification_FirstName")]

        //[FindsBy(How = How.XPath, Using = "html/body/form/div[4]/div[2]/div[2]/table/tbody/tr[1]/td/div/table/tbody/tr[2]/td/div[2]/div[1]/div[1]/div/span/table/tbody/tr[2]/td[3]/input")]
        private IWebElement firstName;
       

//  public void SelectDropDownForGender(string gender)

//{
//    //
//    //Assert.AreEqual(SeleniumGetMethos.GetText(firstName), "Anil");

//    //SeleniumGetMethos.GetTextFromDDL(genderTextField);
//    //Assert.AreEqual(SeleniumGetMethos.GetTextFromDDL(firstName), "Female");
//    genderTextField.SelectDropDown(gender);



//}

  public void EnterFirstName(string fName)
  {
      //ReadOnlyCollection<IWebElement> webElements = Driver.FindElements(By.CssSelector("input, select, textarea, a, button"))//and keep adding

//then do a simple count. The trick here is the selector and you need to make sure you are adding all the tag names are being used in your application
//webElements.Count();
     
      //firstName.EnterText(fName);
      firstName.SendKeys(fName);
 
  }
     

}

}
