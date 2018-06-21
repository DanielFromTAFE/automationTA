using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Global
{
    class Login 
    {
        // Initializing the web elements 
        internal Login()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }

        // Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement PassWord { get; set; }

        // Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[3]/button[1]")]
        private IWebElement loginButton { get; set; }

        internal void LoginSuccessfull()
        {
            try
            {        
                // Populating the data from Excel
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Login");
                // Navigating to Login page using value from Excel
                Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));

                // Sending the username 
                //Email.SendKeys(ExcelLib.ReadData(2, "Email"));
                Driver.sendKeys(Email, "Email", ExcelLib.ReadData(2, "Email"));
                
                // Sending the password
                //PassWord.SendKeys(ExcelLib.ReadData(2, "Password"));
                Driver.sendKeys(PassWord, "PassWord", ExcelLib.ReadData(2, "Password"));

                // Clicking on the login button
                //loginButton.Click();
                Driver.click(loginButton, "loginButton");

               // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successfull");
            }
            catch (Exception ex)
            {
                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login failed because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while logging in");
            }
        }


    }
}
