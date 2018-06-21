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
    class Dashboard
    {
        internal Dashboard()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        //Find Owner DropDown
        [FindsBy(How = How.XPath, Using = "/html/body/nav/div/ul/li[2]/a")]
        private IWebElement ownerDropDown { get; set; }

        //Find Properties in Owner DropDown
        [FindsBy(How = How.XPath, Using = "/html/body/nav/div/ul/li[2]/ul/li[1]/a")]
        private IWebElement propertiesLink { get; set; }

        internal void goToPropertiesPage()
        {
            try
            {


                //Click on Owner DropDown
                // ownerDropDown.Click();
                Driver.click(ownerDropDown, "ownerDropDown");

                //Click on Properties in Owner DropDown
                //propertiesLink.Click();
                Driver.click(propertiesLink, "propertiesLink");
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Properties link found and clicked");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Properties link could not be clicked because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while clicking property link");
            }


        }
    }
}
