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
    class AddNewPropertyTenantDetails
    {
        internal AddNewPropertyTenantDetails()
        {
            PageFactory.InitElements(this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        // Find "Tenant Email" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[1]/div[1]/div/input")]
        private IWebElement tenantEmailTextbox { get; set;}

        // Find "Is Main Tenant" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[1]/div[2]/div/select")]
        private IWebElement isMainTenantDropdown { get; set;}

        // Find "First Name" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[2]/div[1]/div/input")]
        private IWebElement firstNameTextbox { get; set;}

        // Find "Last Name" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[2]/div[2]/div/input")]
        private IWebElement lastNameTextbox { get; set;}

        // Find "Start Date" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[3]/div[1]/div/input")]
        private IWebElement  startDateTextbox{ get; set;}

        // Find "End Date" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[3]/div[2]/div/input")]
        private IWebElement endDateTextbox{ get; set;}

        // Find "Rent Amount" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[4]/div[1]/input")]
        private IWebElement rentAmountTextbox{ get; set;}

        // Find "Payment Frequency" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[4]/div[2]/div/select")]
        private IWebElement paymentFrequencyDropdown { get; set;}

        // Find "Payment Start Date" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[5]/div[1]/div/input")]
        private IWebElement paymentStartDateTextbox{ get; set;}

        // Find "Payment Due Date" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[5]/div[2]/div/select")]
        private IWebElement paymentDueDateDropdown{ get; set;}

        // Find "Add New Liability" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='LiabilityDetail']/div/div/a")]
        private IWebElement addNewLiabilityLink{ get; set;}

        // Find "Liability Name" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='LiabilityDetail']/div/div/table/tbody/tr/td[1]/select")]
        private IWebElement liabilityNameDropdown{ get; set;}

        // Find "Amount" text box
        [FindsBy(How = How.XPath, Using = ".//*[@id='LiabilityDetail']/div/div/table/tbody/tr/td[2]/input")]
        private IWebElement amountLiabilityTextbox{ get; set;}

        // Find "Save" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[8]/div/button[2]")]
        private IWebElement saveButton{ get; set;}

        internal void fillTenantDetails(int rowNumber)
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddTenant");
                Driver.wait(2);



                // Fill "Tenant Email" textbox
                // tenantEmailTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "TenantEmail"));
                Driver.sendKeys(tenantEmailTextbox, "tenantEmailTextbox", ExcelLib.ReadData(rowNumber, "TenantEmail"));


                // Select "Is Main Tenant" dropdown
               // new SelectElement(isMainTenantDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "IsMainTenant"));
                Driver.selectFromDropdownByText(isMainTenantDropdown, "isMainTenantDropdown", ExcelLib.ReadData(rowNumber, "IsMainTenant"));


                // Fill "First Name" textbox
                //firstNameTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "FirstName"));
                Driver.sendKeys(firstNameTextbox, "firstNameTextbox", ExcelLib.ReadData(rowNumber, "FirstName"));

                // Fill "Last Name' textbox
                //lastNameTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "LastName"));
                Driver.sendKeys(lastNameTextbox, "lastNameTextbox", ExcelLib.ReadData(rowNumber, "LastName"));

                // Fill "Start Date" textbox
                //startDateTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "StartDate"));
                Driver.sendKeys(startDateTextbox, "startDateTextbox", ExcelLib.ReadData(rowNumber, "StartDate"));

                // Fill "End Date" textbox
                //endDateTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "EndDate"));
                Driver.sendKeys(endDateTextbox, "endDateTextbox", ExcelLib.ReadData(rowNumber, "EndDate"));


                // Fill "Rent Amount" textbox
                //rentAmountTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "RentAmount"));
                Driver.sendKeys(rentAmountTextbox, "rentAmountTextbox", ExcelLib.ReadData(rowNumber, "RentAmount"));

                // Select from "Payment Frequency" dropdown
                //new SelectElement(paymentFrequencyDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "PaymentFrequency"));
                Driver.selectFromDropdownByText(paymentFrequencyDropdown, "paymentFrequencyDropdown", ExcelLib.ReadData(rowNumber, "PaymentFrequency"));

                // Fill "Payment Start Date" textbox
                //paymentStartDateTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "PaymentStartDate"));
                Driver.sendKeys(paymentStartDateTextbox, "paymentStartDateTextbox", ExcelLib.ReadData(rowNumber, "PaymentStartDate"));

                // Select from "Payment Due Date" dropdown
                //new SelectElement(paymentDueDateDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "PaymentDueDate"));
                Driver.selectFromDropdownByText(paymentDueDateDropdown, "paymentDueDateDropdown", ExcelLib.ReadData(rowNumber, "PaymentDueDate"));

                // Click on "Add New Liability" link
                //addNewLiabilityLink.Click();
                Driver.click(addNewLiabilityLink, "addNewLiabilityLink");

                // Select from "Liability Name" dropdown
                //new SelectElement(liabilityNameDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "LiabilityName"));
                Driver.selectFromDropdownByText(liabilityNameDropdown, "liabilityNameDropdown", ExcelLib.ReadData(rowNumber, "LiabilityName"));

                // Fill "Amount"
                //amountLiabilityTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "AmountLiability"));
                Driver.sendKeys(amountLiabilityTextbox, "amountLiabilityTextbox", ExcelLib.ReadData(rowNumber, "AmountLiability"));

                // Click on "Save" button
                //saveButton.Click();
                Driver.click(saveButton, "saveButton");

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Tenant Details filled");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Tenants Details could not be filled completely because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while filling Tenants Details");
            }


        }
    }
}










