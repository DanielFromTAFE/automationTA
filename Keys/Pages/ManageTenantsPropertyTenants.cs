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
    class ManageTenantsPropertyTenants
    {
        internal ManageTenantsPropertyTenants()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[2]/div[2]/span/a")]
        private IWebElement addTenantLink{ get; set; }

        // Click on "Add Tenant" link
        internal void clickOnAddTenantLink()
        {
            try
            {
                // addTenantLink.Click();
                Driver.click(addTenantLink);

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Add Tenant link clicked");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Add Tenant link could not be clicked because of Exception " + ex.ToString());
                Assert.Fail("Exception" + ex.ToString() + " occured while clicking Add Tenant link");
            }
        }
    
    }
}
