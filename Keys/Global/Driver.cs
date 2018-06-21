using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Global
{
    public static class Driver
    {

        public static IWebDriver driver { get; set; }
        //public ExtentTest test { get; set; }
        public const int defaultTimeout = 5;
        #region WaitforElement 

        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(time));

        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }
        #endregion

        //#region FindElement Extentsion
        //public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        //{
        //    if (timeoutInSeconds > 0)
        //    {
        //        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        //        return wait.Until(drv => drv.FindElement(by));
        //    }
        //    return driver.FindElement(by);
        //}
        //#endregion

        #region Element Present
        public static bool isElementPresent(By by)
        {
            try
            {
                Driver.driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        #endregion

        #region Element Displayed/Present for PageFactory
        public static bool isElementDisplayed(IWebElement element)
        {
            try
            {
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => element.Displayed);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        #endregion

        #region Extention of Click for PageFactory
        public static void click(IWebElement element)
        {
            try
            {
              
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(ExpectedConditions.ElementToBeClickable(element)).Click();
            }
            catch (StaleElementReferenceException)
            {
                try
                {
                    // simply retry finding the element in the refreshed DOM
                    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(ExpectedConditions.ElementToBeClickable(element)).Click();
                }
                catch(Exception ex)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Exception " + ex.ToString() + " occured while clicking Element identified by " + element);
                    Assert.Fail("Exception " + ex.ToString() + " occured while clicking " + element);
                }
               
            }
            catch (WebDriverTimeoutException)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Element identified by " + element + " was not clickable after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail("TimeoutException while clicking " + element);
            }
            catch(Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Exception " + ex.ToString() + " occured while clicking Element identified by " + element);
                Assert.Fail("Exception " + ex.ToString() +" occured while clicking " + element);
            }

        }
        #endregion

        #region Extention of Click for PageFactory with element name for better reporting
        public static void click(IWebElement element, string elementName)
        {
            try
            {

                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(ExpectedConditions.ElementToBeClickable(element)).Click();
            }
            /*  catch (NoSuchElementException)
              {
                  Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Element identified by " + element + " was not found ");
                  Assert.Fail("NoSuchElementException while clicking " + element);
              } */
            catch (StaleElementReferenceException)
            {
                try
                {
                    // simply retry finding the element in the refreshed DOM
                    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(ExpectedConditions.ElementToBeClickable(element)).Click();
                }
                catch (Exception ex)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Exception " + ex.ToString() + " occured while clicking Element identified by " + elementName);
                    Assert.Fail("Exception " + ex.ToString() + " occured while clicking " + elementName);
                }

            }
            catch (WebDriverTimeoutException)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Element identified by " + elementName + " was not clickable after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail("TimeoutException while clicking " + elementName);
            }
            catch (Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Exception " + ex.ToString() + " occured while clicking Element identified by " + elementName);
                Assert.Fail("Exception " + ex.ToString() + " occured while clicking " + elementName);
            }

        }
        #endregion



        #region Extention of SendKeys for PageFactory

        public static void sendKeys(IWebElement element, string valueToType)
        {
            try
            {
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));

                element.Clear();
                element.SendKeys(valueToType);
            }
            catch (Exception ex) when ( ex is WebDriverTimeoutException)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform SendKeys on element identified by " + element.ToString() + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while sendKeys on " + element.ToString());
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                try
                {
                    // find element again and retry
                    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));
                    element.Clear();
                    element.SendKeys(valueToType);
                }
                catch(Exception ex1)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform SendKeys on element identified by " + element.ToString() + " after " + ( defaultTimeout*2).ToString() + " seconds");
                    Assert.Fail(ex1.ToString() + " occured while sendKeys on " + element.ToString());
                }
            }
            catch(Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform SendKeys on element identified by " + element.ToString() + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while sendKeys on " + element.ToString());
            }
        }


        #endregion

        #region Extention of SendKeys for PageFactory with element name for better reporting

        public static void sendKeys(IWebElement element, string elementName, string valueToType)
        {
            try
            {
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));

                element.Clear();
                element.SendKeys(valueToType);
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform SendKeys on element identified by " + elementName + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while sendKeys on " + elementName);
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                try
                {
                    // find element again and retry
                    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));
                    element.Clear();
                    element.SendKeys(valueToType);
                }
                catch (Exception ex1)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform SendKeys on element identified by " + elementName + " after " + (defaultTimeout * 2).ToString() + " seconds");
                    Assert.Fail(ex1.ToString() + " occured while sendKeys on " + elementName);
                }
            }
            catch (Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform SendKeys on element identified by " + elementName + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while sendKeys on " + elementName);
            }
        }


        #endregion

        #region SelectElement.SelectByText Extension for PageFactory
        public static void selectFromDropdownByText(IWebElement element, string text) 
        {
            try
            {
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));
                new SelectElement(element).SelectByText(text);
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform Select on element identified by " + element.ToString() + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while selecting from " + element.ToString());
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                try
                {
                    // find element again and retry
                    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));
                    new SelectElement(element).SelectByText(text);
                }
                catch (Exception ex1)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform Select on element identified by " + element.Text + " after " + (defaultTimeout * 2).ToString() + " seconds");
                    Assert.Fail(ex1.ToString() + " occured while Selecting from " + element.ToString());
                }
            }
            catch (Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform Select on element identified by " + element.ToString() + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while selecting from " + element.ToString());
            }            
        }

        #endregion

        #region SelectElement.SelectByText Extension for PageFactory with element name for better reporting
        public static void selectFromDropdownByText(IWebElement element, string elementName, string text)
        {
            try
            {
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));
                new SelectElement(element).SelectByText(text);
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform Select on element identified by " + elementName + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while selecting from " + elementName);
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                try
                {
                    // find element again and retry
                    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(defaultTimeout)).Until(d => (element.Displayed && element.Enabled));
                    new SelectElement(element).SelectByText(text);
                }
                catch (Exception ex1)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform Select on element identified by " + elementName + " after " + (defaultTimeout * 2).ToString() + " seconds");
                    Assert.Fail(ex1.ToString() + " occured while Selecting from " + elementName);
                }
            }
            catch (Exception ex)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Could not perform Select on element identified by " + elementName + " after " + defaultTimeout.ToString() + " seconds");
                Assert.Fail(ex.ToString() + " occured while selecting from " + elementName);
            }
        }

        #endregion

        #region On Page
        public static void isOnPage(string pageTitle)
        {
            try
            {
                Thread.Sleep(5000);    // Use page load methods later
                Assert.AreEqual(pageTitle, Driver.driver.Title);
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Navigated to " + pageTitle + " page ");
                
            }
            catch (AssertionException)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Not on " + pageTitle +" page");
                Assert.Fail("Assertion Exception occured while checking User is on" +pageTitle);  
            }
            
        }
        #endregion

    }


}
