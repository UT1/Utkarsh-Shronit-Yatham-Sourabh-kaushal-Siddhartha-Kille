﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;





namespace SeleniumTests
{
    [TestFixture]
    public class Class29
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:52963";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TestSuperadmineditfoundpost()
        {
            driver.Navigate().GoToUrl(baseURL + "/WebForm2.aspx");
            driver.FindElement(By.Id("txtUserName")).Clear();
            driver.FindElement(By.Id("txtUserName")).SendKeys("superadmin");
            driver.FindElement(By.Id("txtpassword")).Clear();
            driver.FindElement(By.Id("txtpassword")).SendKeys("superadmin");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'FOUND POST')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Select')])[2]")).Click();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TxtEditFound")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TxtEditFound")).SendKeys("A phone has been found near tuck shop\n\nContact : Praveen");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_FileUpload1")).Clear();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_FileUpload1")).SendKeys("C:\\Users\\SHRONIT\\Desktop\\cell-phone-nokia.jpg");
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnEditFound")).Click();
            driver.FindElement(By.Id("ctl00_A1")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        private class SelectElement
        {
            private IWebElement webElement;

            public SelectElement(IWebElement webElement)
            {
                this.webElement = webElement;
            }

            internal void SelectByText(string v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
