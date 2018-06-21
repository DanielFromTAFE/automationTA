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
    class AddNewPropertyFinanceDetails
    {

        internal AddNewPropertyFinanceDetails()
        {
            PageFactory.InitElements( this, new RetryingElementLocator(Driver.driver, TimeSpan.FromSeconds(Driver.defaultTimeout)));
        }

        // Find "Purchase Price" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[1]/div[1]/div/input")]
        private IWebElement purchasePriceTextbox { get; set; }

        // Find "Mortgage" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[1]/div[2]/div/input")]
        private IWebElement mortgageTextbox { get; set; }

        // Find "Home Value" textbox
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[2]/div[1]/div/input")]
        private IWebElement homeValueTextbox { get; set; }

        // Find "Home Value Type" dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[2]/div[2]/div/select")]
        private IWebElement homeValueTypeDropdown { get; set; }

        // Find "Add Repayments" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[5]/div/a")]
        private IWebElement addRepaymentsLink { get; set; }

        // Find "Amount" textbox in "Repayments" 
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[4]/div/div/div[1]/div/div[1]/input")]
        private IWebElement amountRepaymentsTextbox { get; set; }

        // Find "Frequency" dropdown in "Repayments"
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[4]/div/div/div[1]/div/div[2]/select")]
        private IWebElement frequencyRepaymentsDropdown { get; set; }

        // Find "Start Date" textbox in "Repayments"
        [FindsBy(How = How.XPath, Using = ".//*[@id='payment-start-date']")]
        private IWebElement startDateRepaymentsTextbox { get; set; }

        // Find "End Date" textbox in "Repayments"
        [FindsBy(How = How.XPath, Using = ".//*[@id='payment-end-date']")]
        private IWebElement endDateRepaymentsTextbox { get; set; }

        // Find "Remove(Symbol)" button in "Repayments"
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[4]/div/div/div[2]/div/div[3]/span/i")]
        private IWebElement removeRepaymentsButton { get; set; }

        // Find "Add Expenses" link
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[8]/div/a")]
        private IWebElement addExpensesLink { get; set; }

        // Find "Amount" textbox in "Expenses"
        [FindsBy(How = How.XPath, Using = ".//*[@id='Text1']")]
        private IWebElement amountExpensesTextbox{ get; set; }

        // Find "Description" textbox in "Expenses"
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[7]/div/div/div[2]/input")]
        private IWebElement descriptionExpensesTextbox{ get; set; }

        // Find "Date" textbox in "Expenses"
        [FindsBy(How = How.XPath, Using = ".//*[@id='expense-date']")]
        private IWebElement dateExpensesTextbox{ get; set; }

        // Find "Remove(Symbol)" button in "Expenses"
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[7]/div/div/div[4]/span/i")]
        private IWebElement removeExpensesButton{ get; set; }

        // Find "Previous" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[9]/div/button[1]")]
        private IWebElement previousButton{ get; set; }

        // Find "Next" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[9]/div/button[3]")]
        private IWebElement nextButton{ get; set; }

        // Find "Save" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[9]/div/button[2]")]
        private IWebElement saveButton{ get; set; }

        // Find "Cancel" button
        [FindsBy(How = How.XPath, Using = ".//*[@id='financeSection']/div[9]/div/input")]
        private IWebElement cancelButton{ get; set; }

        // Find "Yes" button on "Cancel>Confirmation" pop-up
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[3]/button[1]")]
        private IWebElement yesCancelButton{ get; set; }

        // Find "No" button on "Cancel>Confirmation" pop-up
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[3]/button[2]")]
        private IWebElement noCancelButton { get; set; }

        // Find "Close(Symbol)" button on "Cancel>Confirmation" pop-up
        [FindsBy(How = How.XPath, Using = ".//*[@id='myModal']/div/div/div[1]/button")]
        private IWebElement closeCancelButton { get; set; }

        // Fill "Finance Details"
        internal void fillFinanceDetails(int rowNumber)
        {
            try
            {

            
                // Populate Data from Excel file
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddProperty");
                Driver.wait(2);

                // Fill "Purchase Price" textbox
                // purchasePriceTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "PurchasePrice"));
                Driver.sendKeys(purchasePriceTextbox, "purchasePriceTextbox", ExcelLib.ReadData(rowNumber, "PurchasePrice"));

                // Fill "Mortgage" textbox
                // mortgageTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "Mortgage"));
                Driver.sendKeys(mortgageTextbox, "mortgageTextbox", ExcelLib.ReadData(rowNumber, "Mortgage"));

                // Fill "Home Value" textbox
                //homeValueTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "HomeValue"));
                Driver.sendKeys(homeValueTextbox, "homeValueTextbox", ExcelLib.ReadData(rowNumber, "HomeValue"));

                // Select from "Home Value Type" dropdown
                // new SelectElement(homeValueTypeDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "HomeValueType"));
                Driver.selectFromDropdownByText(homeValueTypeDropdown, "homeValueTypeDropdown", ExcelLib.ReadData(rowNumber, "HomeValueType"));

                // Click on "Add Repayments" link
                //addRepaymentsLink.Click();
                Driver.click(addRepaymentsLink, "addRepaymentsLink");

                // Fill "Amount" textbox in "Repayments"
                //amountRepaymentsTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "AmountRepayments"));
                Driver.sendKeys(amountRepaymentsTextbox, "amountRepaymentsTextbox", ExcelLib.ReadData(rowNumber, "AmountRepayments"));

                // Select from "frequency" dropdown
                // new SelectElement(frequencyRepaymentsDropdown).SelectByText(ExcelLib.ReadData(rowNumber, "FrequencyRepayments"));
                Driver.selectFromDropdownByText(frequencyRepaymentsDropdown, "frequencyRepaymentsDropdown", ExcelLib.ReadData(rowNumber, "FrequencyRepayments"));

                // Fill "Start Date" textbox in "Repayments"
                //startDateRepaymentsTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "StartDateRepayments"));
                Driver.sendKeys(startDateRepaymentsTextbox, "startDateRepaymentsTextbox", ExcelLib.ReadData(rowNumber, "StartDateRepayments"));

                // Fill "End Date" textbox in "Repayments"
                // endDateRepaymentsTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "EndDateRepayments"));
                Driver.sendKeys(endDateRepaymentsTextbox, "endDateRepaymentsTextbox", ExcelLib.ReadData(rowNumber, "EndDateRepayments"));

                // Click on "Add Expenses" link
                // addExpensesLink.Click();
                Driver.click(addExpensesLink, "addExpensesLink");

                // Fill "Amount" textbox in "Expenses"
                //amountExpensesTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "AmountExpenses"));
                Driver.sendKeys(amountExpensesTextbox, "amountExpensesTextbox", ExcelLib.ReadData(rowNumber, "AmountExpenses"));

                // Fill "Description" textbox in "Expenses"
                //descriptionExpensesTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "DescriptionExpenses"));
                Driver.sendKeys(descriptionExpensesTextbox, "descriptionExpensesTextbox", ExcelLib.ReadData(rowNumber, "DescriptionExpenses"));

                // Fill "Date" textbox in "Expenses"
                //dateExpensesTextbox.SendKeys(ExcelLib.ReadData(rowNumber, "DateExpenses"));
                Driver.sendKeys(dateExpensesTextbox, "dateExpensesTextbox", ExcelLib.ReadData(rowNumber, "DateExpenses"));

                // Click in Description text box to make calender disappear
                Driver.click(descriptionExpensesTextbox, "descriptionExpensesTextbox");

                // Click on "Save" button
                //saveButton.Click();
                Driver.click(saveButton, "saveButton");

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Finance Details filled");

            }
            catch (Exception ex)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Finance Details could not be filled completely because of Exception " + ex.ToString());
                Assert.Fail("Exception " + ex.ToString() + " occured while filling Finance Details");
            }

        }
    }
}
