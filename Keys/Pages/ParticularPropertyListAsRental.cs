using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class ParticularPropertyListAsRental
    {
        internal ParticularPropertyListAsRental()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        // Find "Back" button 
        [FindsBy(How = How.XPath, Using = ".//*[@id='main-content']/section/div[1]/div/a")]
        private IWebElement backButton { get; set; }

        // Find "Select Property" dropdown
        
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[1]/div/div/select")]
        private IWebElement selectPropertyDropdown { get; set; }

        // Find "Title" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[2]/div[1]/div[1]/div/div/input")]
        private IWebElement  titleTextbox{ get; set; }

        // Find "Moving Cost" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[2]/div[1]/div[2]/div/div/input")]
        private IWebElement movingCostTextbox{ get; set; }

        // Find "Description" textarea
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[2]/div[2]/div/textarea")]
        private IWebElement descriptionTextarea{ get; set; }

        // Find "Target Rent" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[3]/div[1]/div/input")]
        private IWebElement targetRentTextbox{ get; set; }

        // Find "Furnishing" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[3]/div[2]/div/input")]
        private IWebElement furnishingTextbox{ get; set; }

        // Find "Available Date" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[4]/div[1]/div/input")]
        private IWebElement availableDateTextbox{ get; set; }

        // Find "Ideal Tenant" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[4]/div[2]/div/input")]
        private IWebElement idealTenantTextbox{ get; set; }

        // Find "Occupants Count" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[5]/div[1]/div/input")]
        private IWebElement occupantsCountTextbox{ get; set; }

        // Find "Pets Allowed" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[5]/div[2]/div/select")]
        private IWebElement petsAllowedDropdown{ get; set; }

        // Find "Choose Files" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='file-upload']")]
        private IWebElement chooseFilesButton{ get; set; }

        // Find "Save" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[8]/div/button[1]")]
        private IWebElement saveButton{ get; set; }


        // Find "Cancel" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='add-new-property']/fieldset/div[8]/div/button[2]")]
        private IWebElement cancelButton{ get; set; }

        // Find "Yes" button on "Cancel>Confirmation"
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[3]/button[1]")]
        private IWebElement yesCancelConfirmationButton{ get; set; }

        // Find "No" button on "Cancel>Confirmation"
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[3]/button[2]")]
        private IWebElement noCancelConfirmationButton { get; set; }

        // Find "Close(Symbol)" button on "Cancel>Confirmation"
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[1]/button")]
        private IWebElement closeCancelConfirmationButton { get; set; }

        // Fill details in List As Rental fields
        internal void fillListAsRentaldetails(int rowNumber)
        {
            try
            {
                // Populate Data from Excel file
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ListAsRental");
                Driver.wait(2);

                //Fill "Title" textbox
                //titleTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Title"));
                Driver.sendKeys(titleTextbox, "titleTextbox", ExcelLib.ReadData(rowNumber, "Title"));

                //Fill "Moving Cost" textbox
                // movingCostTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "MovingCost"));
                Driver.sendKeys(movingCostTextbox, "movingCostTextbox", ExcelLib.ReadData(rowNumber, "MovingCost"));

                //Fill "Description" textarea
                // descriptionTextarea.SendKeys(ExcelLib.ReadData(rowNumber, "Description"));
                Driver.sendKeys(descriptionTextarea, "descriptionTextarea", ExcelLib.ReadData(rowNumber, "Description"));

                //Fill "Target Rent" textbox
                //targetRentTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "TargetRent"));
                Driver.sendKeys(targetRentTextbox, "targetRentTextbox", ExcelLib.ReadData(rowNumber, "TargetRent"));

                //Fill "Furnishings" textbox
                // furnishingTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Furnishing"));
                Driver.sendKeys(furnishingTextbox, "furnishingTextbox", ExcelLib.ReadData(rowNumber, "Furnishing"));

                //Fill "Avialable Date" textbox
                //availableDateTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "AvailableDate"));
                Driver.sendKeys(availableDateTextbox, "availableDateTextbox", ExcelLib.ReadData(rowNumber, "AvailableDate"));

                //Fill "Ideal Tenant" textbox
                //idealTenantTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "IdealTenant"));
                Driver.sendKeys(idealTenantTextbox, "idealTenantTextbox", ExcelLib.ReadData(rowNumber, "IdealTenant"));

                //Fill "Occupants Count" textbox
                //occupantsCountTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "OccupantsCount"));
                Driver.sendKeys(occupantsCountTextbox, "occupantsCountTextbox", ExcelLib.ReadData(rowNumber, "OccupantsCount"));

                //Select from "Pets Allowed" dropdown
                //new SelectElement(petsAllowedDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "PetsAllowed"));
                Driver.selectFromDropdownByText(petsAllowedDropdown, "petsAllowedDropdown", ExcelLib.ReadData(rowNumber, "PetsAllowed"));

                //Click on "Save" button
                //saveButton.Click();
                Driver.click(saveButton, "saveButton");

                // Accept Alert
                try
                {
                    Driver.driver.SwitchTo().Alert().Accept();
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Do you want to list the property as rental alert Accepted");
                }
                catch (Exception ex)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Do you want to list the property as rental alert could not be Accepted because of Exception " + ex.ToString());
                    Assert.Fail("Exception " + ex.ToString() +" occured while acceptiong alert in filling List As Rental details");
                }
              
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "List As Rental Details filled");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "List As Rental  Details could not be filled completely because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while filling List As Rental details");
            }
        }

        // Find Title of property listed as rental
        internal string titleOfListedProperty(int rowNumber)
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ListAsRental");
                Driver.wait(2);

              
                    string title = ExcelLib.ReadData(rowNumber, "Title");
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Title of listed property found");
                    return title;
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Title of listed property not found because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while finding address of listed property");
                return null;
            }

        }

        // Find address of property listed as rental
        internal string addressOfListedProperty(int rowNumber)
        {
            try
           {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ListAsRental");
                Driver.wait(2);
                string location =  selectPropertyDropdown.Text;
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Address of listed property found");
                return location;
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Address of listed property not found because of Exception " + ex.ToString());
                Assert.Fail("Exception" + ex.ToString() + " occured while getting the address of listed property");
                return null;
            }
        }
    }
}

