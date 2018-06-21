using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class OwnerRentalProperties
    {
        internal OwnerRentalProperties()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        // Page Title
        private const string pageTitle = "Rental Listings";

        // Find "Search" box
        [FindsBy(How = How.XPath, Using = ".//*[@id='searchId']")]
        private IWebElement searchBox { get; set; }

        // Find "Search" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='search-wrap']/form/div/div/button")]
        private IWebElement searchButton { get; set; }

        // Find "Sort By" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div[2]/div[2]/div/div/select")]
        private IWebElement sortByDropdown { get; set; }

        // First Property Start


        // Find "Title" 
        [FindsBy(How = How.XPath, Using = ".//*[@id='searchId']")]
        private IWebElement firstPropertyTitle { get; set; }

        // Find "Location" line1 
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div[3]/div[1]/div/div[1]/div[2]/div[2]/div[2]/span[1]")]
        private IWebElement firstPropertyLocationLine1 { get; set; }

        // Find "Location" line2
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div[3]/div[1]/div/div[1]/div[2]/div[2]/div[2]/span[2]")]
        private IWebElement firstPropertyLocationLine2 { get; set; }

        // Check if on this page
        internal void isOnOwnerRentalPropertiesPage()
        {
            Driver.isOnPage(pageTitle);

        }


        // Search for a property using search box
        internal void searchProperty(string text)
        {
            try
            {
                // Enter data in "Search" textbox
                // searchBox.SendKeys(text);
                Driver.sendKeys(searchBox, "searchBox", text);

                // Click on "Search" button
                //searchButton.Click();
                Driver.click(searchButton, "searchButton");

                Thread.Sleep(3000);
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Data entered in Search box and Search button clicked on OwnerRentalProperties page");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Search could not be completed on OwnerRentalProperties page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while searching property on OwnerRentalProperties page ");
            }
        }


        // Sort properties from "Sort By" dropdown
        internal void selectfromSortByDropdown(string text)
        {
            try
            {
                // Select option from "Sort By" dropdown
                //new SelectElement(sortByDropdown).SelectByText(text);
                Driver.selectFromDropdownByText(sortByDropdown, "sortByDropdown", text);

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, text + " selected from Sort By dropdown on OwnerRentalProperties page");
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, text + " not selected from Sort By droplown on OwnerRentalProperties page because of Exception " + ex.ToString());
                Assert.Fail("Exception" + ex.ToString() + "  occured while selecting " + text + " from Sort By on OwnerRentalProperties page");
            }
        }

        // Find Address of First Property in properties populated on this page
        internal string locationFirstProperty()
        {
             try
            {
            string location = firstPropertyTitle.Text + " " + firstPropertyLocationLine1.Text + " " + firstPropertyLocationLine2.Text;
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Location of first property found on OwnerRentalProperties page");
            return location;
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Location of first property not found on OwnerRentalProperties page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while getting the location of first property on OwnerRentalProperties page");
                return null;
            }
        }

        // Compare properties for List As Rental
        internal void comparePropertiesForListAsRental(string addressOfListedProperty)
        {
            try
            {
                ParticularPropertyListAsRental particularPropertyListAsRentalObj1 = new ParticularPropertyListAsRental();
                OwnerRentalProperties ownerRentalPropertiesObj1 = new OwnerRentalProperties();
                

                bool b = addressOfListedProperty.Contains(ownerRentalPropertiesObj1.locationFirstProperty());
                if (b)
                {
                   Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property found matches to property listed as rental");

                }
                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property found does not match to property listed as rental");
                }
            }
            catch (Exception ex)
            {

               Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property not listed as rental because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while comparing properties for List As Rental");
            }
        }

    }

}
