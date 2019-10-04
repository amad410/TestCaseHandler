// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CssTEst
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver;
        TestCaseHandler _testCaseHandler = null;

        [Test]
        public void CssTest()
        {

            driver.Navigate().GoToUrl("http://www.practiceselenium.com");

            _testCaseHandler.Invoke(() =>
            {
                driver.FindElement(By.XPath("test"));

            });

            IWebElement talkTeaMenu = driver.FindElement(By.CssSelector("[href='let-s-talk-tea.html']"));

            bool isVisible = talkTeaMenu.Displayed;

            Assert.IsTrue(isVisible, "The talk tea menu link is not displayed");
















            talkTeaMenu.Click();
            IWebElement nameInput = driver.FindElement(By.CssSelector("[name='name']"));
            nameInput.SendKeys("Antwan");

            IWebElement emailInput = driver.FindElement(By.CssSelector("[name='email']"));
            emailInput.SendKeys("antwan.maddox@agilethought.com");

            IWebElement subjectInput = driver.FindElement(By.CssSelector("[name='subject']"));
            subjectInput.SendKeys("test");

            IWebElement messageInput = driver.FindElement(By.CssSelector("[name='message']"));
            messageInput.SendKeys("test");

            IWebElement submitBtn = driver.FindElement(By.CssSelector("[value='Submit']"));
            talkTeaMenu.Click();

        }
        [Test]
        public void xpathTest()
        {
            driver.Navigate().GoToUrl("https://www.phptravels.net/");
            driver.FindElement(By.XPath("(//*[@class = 'select2-input'])[6]")).SendKeys("Tampa, United States");
            driver.FindElement(By.XPath("//*[contains(@class,'checkin')]")).SendKeys("06/09/2019");
            driver.FindElement(By.XPath("//*[contains(@class,'checkout')]")).SendKeys("26/09/2019");
            driver.FindElement(By.XPath("//*[@id = 'htravellersInput']")).SendKeys("1 Adult 0 Child");
            driver.FindElement(By.XPath("(//*[contains(@class,'search-button')])[4]//child::button")).Click();
            Assert.IsNotNull(driver.FindElements(By.XPath("//*[@id='listing']//tbody//tr")));
        }

        [SetUp]
        public void Setup()
        {
            //this all provided to me by the '.' operator for the chrome browser object I created. 
            //creating a chrome browser and opening it
            driver = new ChromeDriver();
            //maximizing the browser window
            driver.Manage().Window.Maximize();
            _testCaseHandler = new TestCaseHandler();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }



        
    }
}
