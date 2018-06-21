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
    class AddNewPropertyPropertyDetails
    {
        internal AddNewPropertyPropertyDetails()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        // Find "Property Name" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[1]/div/input")]
        private IWebElement propertyNameTextbox { get; set; }

        // Find "Property Type" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select")]
        private IWebElement propertyTypeDropdown { get; set; }

        /* // Find "Affordable Housing" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[1]")]
         private IWebElement affordableHousingSelection { get; set; }

         // Find "Section and Property" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[2]")]
         private IWebElement sectionAndPropertySelection { get; set; }

         // Find "Senior Housing" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[3]")]
         private IWebElement seniorHousingSelection { get; set; }

         // Find "Short-Term Rental" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[4]")]
         private IWebElement shortTermRentalSelection { get; set; }

         // Find "Student Housing" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[5]")]
         private IWebElement studentHousingSelection { get; set; }

         // Find "Vacation Property" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[6]")]
         private IWebElement vacationPropertySelection { get; set; }

         // Find "Car park" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[7]")]
         private IWebElement carParkSelection { get; set; }

         // Find "Development Site" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[8]")]
         private IWebElement developmentSiteSelection { get; set; }

         // Find "Hotel/Leisure" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[9]")]
         private IWebElement hotelLeisureSelection { get; set; }

         // Find "Industrial" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[10]")]
         private IWebElement industrialSelection { get; set; }

         // Find "Office" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[11]")]
         private IWebElement officeSelection { get; set; }

         // Find "Retail" in "Property Type" dropdown
         [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[1]/div[2]/div/select/option[12]")]
         private IWebElement retailSelection { get; set; }
         */

        // Find "Search Address" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='autocomplete']")]
        private IWebElement searchAddressTextbox { get; set; }

        // Find result from autosuggest
        [FindsBy(How = How.XPath, Using = "html/body/div[2]/div")]
        private IWebElement selectAddress { get; set; }


        // Find "Number" textbox
        [FindsBy(How = How.CssSelector, Using = "#street_number")]
        private IWebElement numberTextBox { get; set; }

        // Find "Street" textbox
        [FindsBy(How = How.CssSelector, Using = "#route")]
        private IWebElement streetTextbox { get; set; }

        // Find "Suburb" textbox
        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > input:nth-child(2)")]
        private IWebElement suburbTextbox { get; set; }

        // Find "District" textbox
        [FindsBy(How = How.CssSelector, Using = "div.col-md-4:nth-child(2) > div:nth-child(1) > input:nth-child(2)")]
        private IWebElement districtTextbox { get; set; }

        // Find "PostCode" textbox
        [FindsBy(How = How.CssSelector, Using = "div.col-md-4:nth-child(3) > div:nth-child(1) > input:nth-child(2)")]
        private IWebElement postCodeTextbox { get; set; }

        // Find "Region" textbox
        [FindsBy(How = How.CssSelector, Using = "div.col-md-6:nth-child(4) > div:nth-child(1) > input:nth-child(2)")]
        private IWebElement regionTextbox { get; set; }


        // Find "Description" textfield
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[2]/div[2]/div/textarea")]
        private IWebElement descriptionTextfield { get; set; }

        // Find "Year built" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[3]/div[1]/div/input")]
        private IWebElement yearBuiltTextbox { get; set; }

        // Find "Target Rent" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[3]/div[2]/div/input")]
        private IWebElement targetRentTextbox { get; set; }

        // Find "Rent Type" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[3]/div[3]/div/select")]
        private IWebElement rentTypeDropdown { get; set; }

        /*
        // Find "Weekly" in "Rent Type" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[3]/div[3]/div/select/option[1]")]
        private IWebElement weeklySelection { get; set; }

        // Find "Fortnightly" in "Rent Type" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[3]/div[3]/div/select/option[2]")]
        private IWebElement fortnightlySelection { get; set; }

        // Find "Monthly" in "Rent Type" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[3]/div[3]/div/select/option[3]")]
        private IWebElement monthlySelection { get; set; }
        */

        // Find "Land Area" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[4]/div[1]/div/input")]
        private IWebElement landAreaTextbox { get; set; }

        // Find "Floor Area" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[4]/div[2]/div/input")]
        private IWebElement floorAreaTextbox { get; set; }

        // Find "Bedrooms" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[5]/div[1]/div/input")]
        private IWebElement bedroomsTextbox { get; set; }

        // Find "Bathrooms" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[5]/div[2]/div/input")]
        private IWebElement bathroomsTextbox { get; set; }

        // Find "Carparks" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[6]/div[1]/div/input")]
        private IWebElement carparksTextbox { get; set; }

        // Find "Owner Occupied" checkbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[6]/div[2]/div/input")]
        private IWebElement ownerOccupiedCheckbox { get; set; }

        // Find "Choose Files" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='file-upload']")]
        private IWebElement chooseFilesButton { get; set; }

        // Find "Next" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[9]/div/button[1]")]
        private IWebElement nextButton { get; set; }

        // Find "Cancel" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='property-details']/div[9]/div/button[2]")]
        private IWebElement cancelButton { get; set; }

        // Find "Yes" button on Confirmation alert for cancel
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[3]/button[1]")]
        private IWebElement yesButton { get; set; }

        // Find "No" button on Confirmation alert for cancel
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[3]/button[2]")]
        private IWebElement noButton { get; set; }

        // Find "Close(Symbol)" button on Confirmation alert for cancel
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[1]/button")]
        private IWebElement closeButton { get; set; }

        internal void fillPropertyDetails(int rowNumber)
        {
            try
            {

                // Populate Data from Excel file
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddProperty");
                Driver.wait(2);

                // Fill Property Name
                //propertyNameTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "PropertyName"));
                Driver.sendKeys(propertyNameTextbox, "propertyNameTextbox", ExcelLib.ReadData(rowNumber, "PropertyName"));

                // Select Option from Property Type dropdown
                // new SelectElement(propertyTypeDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "PropertyType"));
                Driver.selectFromDropdownByText(propertyTypeDropdown, "propertyTypeDropdoewn", ExcelLib.ReadData(rowNumber, "PropertyType"));
                if (ExcelLib.ReadData(rowNumber, "Address") != "Null")
                {
                    // Fill "Search Address" textbox
                    //searchAddressTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Address"));
                    Driver.sendKeys(searchAddressTextbox, "searchAddressTextbox", ExcelLib.ReadData(rowNumber, "Address"));
                    Driver.wait(3);

                    // Select Address to  autocomplete
                    //selectAddress.Click();
                    Driver.click(selectAddress, "selectAddress");
                }
                else
                {
                    // Fill Number
                    //numberTextBox.SendKeys(ExcelLib.ReadData(rowNumber, "Number"));
                    Driver.sendKeys(numberTextBox, "numberTextBox", ExcelLib.ReadData(rowNumber, "Number"));

                    // Fill Street
                    //streetTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Street"));
                    Driver.sendKeys(streetTextbox, "streetTextbox", ExcelLib.ReadData(rowNumber, "Street"));

                    // Fill Suburb
                    //suburbTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Suburb"));
                    Driver.sendKeys(suburbTextbox, "suburbTextbox", ExcelLib.ReadData(rowNumber, "Suburb"));

                    // Fill District
                    //districtTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "District"));
                    Driver.sendKeys(districtTextbox, "districtTextbox", ExcelLib.ReadData(rowNumber, "District"));

                    // Fill "PostCode"
                    //postCodeTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "PostCode"));
                    Driver.sendKeys(postCodeTextbox, "postCodeTextbox", ExcelLib.ReadData(rowNumber, "PostCode"));

                    // Fill Region
                    //regionTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Region"));
                    Driver.sendKeys(regionTextbox, "regionTextbox", ExcelLib.ReadData(rowNumber, "Region"));
                }

                // Fill Description
                //descriptionTextfield.SendKeys(ExcelLib.ReadData(rowNumber, "Description"));
                Driver.sendKeys(descriptionTextfield, "descriptionTextfield", ExcelLib.ReadData(rowNumber, "Description"));

                // Fill Year Built
                //yearBuiltTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "YearBuilt"));
                Driver.sendKeys(yearBuiltTextbox, "yearBuiltTextbox", ExcelLib.ReadData(rowNumber, "YearBuilt"));

                // Fill Target Rent
                // targetRentTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "TargetRent"));
                Driver.sendKeys(targetRentTextbox, "targetRentTextbox", ExcelLib.ReadData(rowNumber, "TargetRent"));

                // Select Rent Type
                // new SelectElement(rentTypeDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "RentType"));
                Driver.selectFromDropdownByText(rentTypeDropdown, "rentTypeDropdown", ExcelLib.ReadData(rowNumber, "RentType"));

                // Fill Land Area
                // landAreaTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "LandArea"));
                Driver.sendKeys(landAreaTextbox, "landAreaTextbox", ExcelLib.ReadData(rowNumber, "LandArea"));

                // Fill Floor Area
                //floorAreaTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "FloorArea"));
                Driver.sendKeys(floorAreaTextbox, "floorAreaTextbox", ExcelLib.ReadData(rowNumber, "FloorArea"));

                // Fill BedRooms
                // bedroomsTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Bedrooms"));
                Driver.sendKeys(bedroomsTextbox, "bedroomsTextbox", ExcelLib.ReadData(rowNumber, "Bedrooms"));

                // Fill Bathrooms
                //bathroomsTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Bathrooms"));
                Driver.sendKeys(bathroomsTextbox, "bathroomsTextbox", ExcelLib.ReadData(rowNumber, "Bathrooms"));

                // Fill Carparks
                // carparksTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Carparks"));
                Driver.sendKeys(carparksTextbox, "carparksTextbox", ExcelLib.ReadData(rowNumber, "Carparks"));

                // Check Owner Occupied checkbox
                if (ExcelLib.ReadData(rowNumber, "OwnerOccupied") == "Yes")
                {
                    //ownerOccupiedCheckbox.Click();
                    Driver.click(ownerOccupiedCheckbox, "ownerOccupiedCheckbox");
                }

                // Click on "Next" button
                // nextButton.Click();
                Driver.click(nextButton, "nextButton");

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property Details filled");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property Details could not be filled completely because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() +"  occured while filling Property Details");
            }           
            
        }

        internal string addressOfAddedProperty(int rowNumber)
        {
            try
            {
               ExcelLib.PopulateInCollection(Base.ExcelPath, "AddProperty");
               Driver.wait(2);

               if (ExcelLib.ReadData(rowNumber, "Address") != "Null")
               {
                // return Address
                string address = ExcelLib.ReadData(rowNumber, "Address");
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Address of added property found");
                return address;
               }
               else
               {
                // return Address
                string address = ExcelLib.ReadData(rowNumber, "Number") + " " + ExcelLib.ReadData(rowNumber, "Street") + "," + " " + ExcelLib.ReadData(rowNumber, "Suburb") + "," + " " + ExcelLib.ReadData(rowNumber, "District");
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Address of added property found");
                return address;
               }
                

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Address of added property not found because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while getting address of added property");
                return null;
            }

        }

        internal string nameOfAddedProperty(int rowNumber)
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddProperty");
                Driver.wait(2);

                string propertyName = ExcelLib.ReadData(rowNumber, "PropertyName");
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Name of added property found");
                return propertyName;
            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Name of added property not found because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while getting the name of added property");
                return null;
            }
         }

      


     }

}

