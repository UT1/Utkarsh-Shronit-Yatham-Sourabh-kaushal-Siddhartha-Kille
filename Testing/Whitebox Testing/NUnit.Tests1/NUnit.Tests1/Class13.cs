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
    public class Class13
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
        public void TestDeleteEventPost()
        {
            driver.Navigate().GoToUrl(baseURL + "/WebForm2.aspx");
            driver.FindElement(By.Id("txtUserName")).Clear();
            driver.FindElement(By.Id("txtUserName")).SendKeys("ss");
            driver.FindElement(By.Id("txtpassword")).Clear();
            driver.FindElement(By.Id("txtpassword")).SendKeys("ss");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'EVENT POST')])[3]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Delete')])[4]")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
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
