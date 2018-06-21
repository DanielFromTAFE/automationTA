using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Pages
{
    public class Register
    {
        internal Register()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));

        }
        //Click on SignUp Link
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[3]/a")]
        private IWebElement RegisterLink { get; set; }
       
        //Enter FirstName
        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        private IWebElement FirstName { get; set; }
       
        //Enter LastName
        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        private IWebElement LastName { get; set; }
        
        //click on Email
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }
        
        //Click on Password
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement Password { get; set; }
       
        //Choose Account Type- Here I have chosen property owner
        [FindsBy(How = How.XPath, Using = "//*[@id='roleDropdown']/option[3]")]
        private IWebElement Acctype { get; set; }

        //Accept terms and conditions
        [FindsBy(How = How.XPath, Using = "//*[@id='checkAgreement']")]
        private IWebElement terms { get; set; }

        //Click on SignUp Button
        [FindsBy(How = How.XPath, Using = "//*[@id='SignupButton']")]
        private IWebElement Registerbutton { get; set; }
        public void Navigateregister()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Register");
            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));
        }
        public void Commonsteps()
        {
            try
            {
                // RegisterLink.Click();
                Driver.click(RegisterLink, "RegisterLink");
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Register link found and clicked");
            }
            catch (Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Register link could not be clicked because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while clicking Register link");
            }
        }

        internal void register()
        {
            try
            {        
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Register");
                Commonsteps();

                Driver.wait(2);
                //Read FirstName
                //FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));
                Driver.sendKeys(FirstName, ExcelLib.ReadData(2, "FirstName"));

                //Read LastName
                //LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));
                Driver.sendKeys(LastName, ExcelLib.ReadData(2, "LastName"));

                //Read Email
                //Email.SendKeys(ExcelLib.ReadData(2, "Email"));
                Driver.sendKeys(Email, ExcelLib.ReadData(2, "Email"));

                Driver.wait(2);
                //Read Password
                // Password.SendKeys(ExcelLib.ReadData(2, "Password"));
                Driver.sendKeys(Password, ExcelLib.ReadData(2, "Password"));

                //Click on Terms and Conditions
                //terms.Click();
                Driver.click(terms);

                //Click on Signup
                //Registerbutton.Click();
                Driver.click(Registerbutton);
                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Registration form filled");
            }
            catch (Exception ex)
            {
               // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Registration form could not be filled because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while filling Registration form");
            }
        }
    }
}
