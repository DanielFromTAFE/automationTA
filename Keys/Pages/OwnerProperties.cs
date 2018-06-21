using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Keys.Pages
{
    class OwnerProperties
    {
        internal OwnerProperties()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        private const string pageTitle = "Properties | Property Community";

        // Find "Add A Property" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[1]/div[2]/a[1]")]
        private IWebElement addAPropertyLink { get; set; }

        // Find "List A Rental" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[1]/div[2]/a[2]/span")]
        private IWebElement listARentalLink { get; set; }

        // Find "Search" box
        [FindsBy(How = How.XPath, Using = ".//*[@id='searchId']")]
        private IWebElement searchBox { get; set; }

        // Find "Search" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='search-wrap']/form/div/div/button")]
        private IWebElement searchButton { get; set; }

        // Find "Sort By" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[3]/div[2]/div/div/select")]
        private IWebElement sortByDropdown { get; set; }

        // Find "Name" in "SortBy" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[3]/div[2]/div/div/select/option[2]")]
        private IWebElement nameSelection { get; set; }

        // Find "Name(Desc)" in "SortBy" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[3]/div[2]/div/div/select/option[3]")]
        private IWebElement nameDescSelection { get; set; }

        // Find "Latest Date" in "SortBy" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[3]/div[2]/div/div/select/option[4]")]
        private IWebElement latestDateSelection { get; set; }

        // Find "Earliest Date" in "SortBy" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[3]/div[2]/div/div/select/option[5]")]
        private IWebElement earliestDateSelection { get; set; }

        // For First Property in properties populated on page

        // Find "Manage Tenant" button
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/div[4]/div[1]/div/div/div[3]/div/a")]
        private IWebElement manageTenantButton { get; set; }

        // Find "Finance" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[3]/div/div[1]")]
        private IWebElement financeButton { get; set; }

        // Find "Edit" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[3]/div/div[2]")]
        private IWebElement editButton { get; set; }

        // Find "Details" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[3]/div/div[3]")]
        private IWebElement detailsButton { get; set; }

        // Find "Add Tenant" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[2]/div/a[1]")]
        private IWebElement addTenantLink { get; set; }

        // Find "List As Rental" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[2]/div/a[2]")]
        private IWebElement listAsRentalLink { get; set; }

        // Find "Send Request" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[2]/div/a[3]")]
        private IWebElement sendRequestLink { get; set; }

        // Find "Delete(Symbol)" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[1]/i")]
        private IWebElement deleteButton { get; set; }

        // Find "Property Name"
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")]
        private IWebElement firstPropertyName { get; set; }

        // Find "Property Address Line1"
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[1]")]
        private IWebElement firstPropertyAddressLine1 { get; set; }

        // Find "Property Address Line2"
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[2]")]
        private IWebElement firstPropertyAddressLine2 { get; set; }


        //End first Property

        // Find "Page... of..." On Navigation bar control on first page
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[5]/div/ul/li[1]/a")]
        private IWebElement pageandNumberOfPagesFirstPageField { get; set; }

        // Find ">>>>" button on Navigation bar control(only when number of pages is >= 6)
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[5]/div/ul/li[9]/a")]
        private IWebElement lastPageButton { get; set; }

        // Find "Page...of..." on Navigation bar control on last page when number of pages is >= 6 and user goes to last page directly from first page
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[5]/div/ul/li[3]/a")]
        private IWebElement pageandNumberOfPagesLastPageField { get; set; }

        // Find "<<<<" button on Navigation bar when user is on last page
        [FindsBy(How = How.XPath, Using = ".//*[@id='mainPage']/div[5]/div/ul/li[1]/a")]
        private IWebElement firstPageButton { get; set; }

        // Check if on "Owner>Properties" page
        internal void isOnOwnerPropertiesPage()
        {
            Driver.isOnPage(pageTitle);
           
        }

        // Click on "Add A Property" link
        internal void cLickOnAddAPropertyLink()
        {
            try
            {

                //addAPropertyLink.Click();
                Driver.click(addAPropertyLink, "addAPropertyLink");
              Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Add A Property link clicked");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Add A Property link could not be clicked because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while clicking Add A Property link");
            }
        }

        // Click on "List A Rental" link
        internal void clickOnListARentalLink()
        {
            //listARentalLink.Click();
            Driver.click(listARentalLink, "listARentalLink");
        }

        // Click in "Search" box
        internal void clickOnSearchBox()
        {
            //searchBox.Click();
            Driver.click(searchBox);
        }

        // Click on "Search" button
        internal void clickOnSearchButton()
        {
            //searchButton.Click();
            Driver.click(searchButton);
        }

        // Search Property
        internal void searchProperty(string text)
        {
            try
            { 
            //searchBox.SendKeys(text);
            Driver.sendKeys(searchBox, "searchBox", text);
            //searchButton.Click();
            Driver.click(searchButton, "searchButton");
            Driver.wait(3);
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Data entered in Search box and Search button clicked on OwnerProperties page");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Search could not be completed on OwnerProperties page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while searching property on OwnerProperties page ");
            }

        }

        internal string addressFirstProperty(int rowNumber)
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddProperty");
                Driver.wait(2);
                if (ExcelLib.ReadData(rowNumber, "Address") != "Null")
                {
                    string address = firstPropertyName.Text + " " + firstPropertyAddressLine1.Text + " " + firstPropertyAddressLine2.Text + ", New Zealand";
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Address of first property found");
                    return address;
                }
                else
                {
                    string address = firstPropertyName.Text + " " + firstPropertyAddressLine1.Text + " " + firstPropertyAddressLine2.Text;
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Address of first property found");
                    return address;
                }
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Address of first property not found  because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while getting the address of first property");
                return null;
            }
        }

        // Click on "Sort By" dropdown
        internal void clickOnSortByDropdown()
        {
            // sortByDropdown.Click();
            Driver.click(sortByDropdown);
        }

        // Click on "Name" in "Sort By" dropdown
        internal void clickOnNameSelection()
        {
            //nameSelection.Click();
            Driver.click(nameSelection);
        }

        // Click on "Name(Desc)" in "Sort By" dropdown
        internal void clickOnNameDescSelection()
        {
            //nameDescSelection.Click();
            Driver.click(nameDescSelection);
        }

        // Click on "Latest Date" in "Sort By" dropdown
        internal void clickOnLatestDateSelection()
        {
            //latestDateSelection.Click();
            Driver.click(latestDateSelection);
        }

        // Click on "Earlist Date" in "Sort By" dropdown
        internal void clickOnEarliestDateSelection()
        {
            // earliestDateSelection.Click();
            Driver.click(earliestDateSelection);
        }

        // Click on "Manage Tenant" button
        internal void clickOnManageTenantButton()
        {
            //manageTenantButton.Click();
            Driver.click(manageTenantButton);
        }

        // Click on "Finance" button
        internal void clickOnFinanceButton()
        {
            // financeButton.Click();
            Driver.click(financeButton);
        }

        // Click on "Edit" button
        internal void clickOnEditButton()
        {
            // editButton.Click();
            Driver.click(editButton);
        }

        // Click on "Details" button
        internal void clickOnDetailsButton()
        {
            //detailsButton.Click();
            Driver.click(detailsButton);
        }

        // Click on "Add Tenant" link
        internal void clickOnAddTenantLink()
        {
            //addTenantLink.Click();
            Driver.click(addTenantLink);
        }

        // Click on "List As Rental" link
        internal void clickOnListAsRentalLink()
        {
            try
            {           
            //listAsRentalLink.Click();
            Driver.click(listAsRentalLink, "listAsRentalLink");
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "List As Rental link clicked");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "List As Rental link could not be clicked because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while clicking List As Rental link");
            }
        }

        // Click on "Send Request" link
        internal void clickOnSendRequestLink()
        {
            // sendRequestLink.Click();
            Driver.click(sendRequestLink);
        }

        // Click on "Delete(Symbol)" button
        internal void clickOnDeleteButton()
        {
            //deleteButton.Click();
            Driver.click(deleteButton);
        }

        internal void comparePropertiesForAddAProperty(int rowNumberAddProperty)
        {
            try
            {
                AddNewPropertyPropertyDetails addNewPropertyPropertyDetailsObj1 = new AddNewPropertyPropertyDetails();
                OwnerProperties ownerPropertiesObj1 = new OwnerProperties();
                Assert.AreEqual(addNewPropertyPropertyDetailsObj1.nameOfAddedProperty(rowNumberAddProperty) + " " + addNewPropertyPropertyDetailsObj1.addressOfAddedProperty(rowNumberAddProperty), ownerPropertiesObj1.addressFirstProperty(rowNumberAddProperty));
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property found matches to added property");
            }
            catch (AssertionException)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property found does not match to added property");
                Assert.Fail("Assertion Exception occured while comparing properties");
            }
            catch (Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property found could not be matched to added property because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while comparing properties");
            }
        }

        // Find total number of pages populated on Properties page
        internal int totalNumberOfPages()
        {
            try
            {

           
        
            string pageNumbers = pageandNumberOfPagesFirstPageField.Text;
            pageNumbers = pageNumbers.TrimEnd(new Char[] {'.'});
            pageNumbers = pageNumbers.Remove(0, 10);
            int totalNumberOfPages = int.Parse(pageNumbers);

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Total number of pages calculated");
                return totalNumberOfPages;
                

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Total number of pages could not be calculated because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while calculating total number of pages");
                return 0;
            }
        }

        // Go to last page
        internal void gotoLastPage(int totalNumberOfPages)
        {
            try
            {

            
                if(totalNumberOfPages>5)
                {
                    // Click on ">>>>" button
                    Driver.click(lastPageButton, "lastPageButton");
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, ">>>> button clicked");
                }
                else
                {
                    Console.WriteLine("Number of pages less than 6");
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Number of pages less than 6");
                    Assert.Pass("Passed as number of pages less than 6");
                }

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Could not goto last page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while gotoLastPage  method");
               
            }
        }

        internal void checkIfOnLastPage(int totalNumberOfPages)
        {
            try
            {

                string pageNumbers = pageandNumberOfPagesLastPageField.Text;
                pageNumbers = pageNumbers.TrimEnd(new Char[] { '.', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                pageNumbers = pageNumbers.TrimEnd(new Char[] { 'o', 'f', ' ' });
                pageNumbers = pageNumbers.TrimStart(new Char[] { 'P', 'a', 'g', 'e' });
                int lastPageNumber = int.Parse(pageNumbers);

                if (lastPageNumber == totalNumberOfPages)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Is on last page");
                }
                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Not on last page");
                    Assert.Fail("Not on last page");
                }
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Could not check if on last page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while checkIfOnLastPage method");

            }
        }

        // Go back to first page
        internal void goBackToFirstPage(int totalNumberOfPages)
        {
            try
            {


                if (totalNumberOfPages > 5)
                {
                    // Click on "<<<<" button
                    Driver.click(firstPageButton, "firstPageButton");
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "<<<< button clicked");
                }
                else
                {
                    Console.WriteLine("Number of pages less than 6");
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Number of pages less than 6");
                    Assert.Pass("Passed as total number of pages less than 6");
                }

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Could not go back to first page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while gotoFirstPage  method");

            }
        }

        internal void checkIfOnFirstPage()
        {
            try
            {

                string pageNumbers = pageandNumberOfPagesFirstPageField.Text;
                pageNumbers = pageNumbers.TrimEnd(new Char[] { '.', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                pageNumbers = pageNumbers.TrimEnd(new Char[] { 'o', 'f', ' ' });
                pageNumbers = pageNumbers.TrimStart(new Char[] { 'P', 'a', 'g', 'e' });
                int pageNumber = int.Parse(pageNumbers);

                if (pageNumber == 1)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Is on first page");
                }
                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Not on first page");
                    Assert.Fail("Not on First page");
                }
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Could not check if on first page because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while checkIfOnFirstPage method");

            }
        }
    }
}



