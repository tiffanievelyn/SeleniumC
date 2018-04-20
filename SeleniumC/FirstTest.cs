using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumC
{
    class FirstTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://localhost:3000/#/";
        }

        [Test]
        public void OpenUserPage()
        {
            driver.Url = "http://localhost:3000/#/";
            driver.FindElement(By.Name("btnUser")).Click();
            Assert.AreEqual(driver.Url, "http://localhost:3000/#/userprofile");
        }

        [Test]
        public void IsElementDisplayed()
        {
            driver.Url = "http://localhost:3000/#/";
            driver.FindElement(By.Name("btnUser")).Click();
            Assert.IsTrue(driver.FindElement(By.Id("login")).Displayed);
        }

        [Test]
        public void IsTextContentCorrect()
        {
            driver.Url = "http://localhost:3000/#/";
            driver.FindElement(By.Name("btnUser")).Click();
            Assert.AreEqual(driver.FindElement(By.Id("header")).Text, "User");

        }

        [Test]
        public void FailTextContent()
        {
            driver.Url = "http://localhost:3000/#/";
            driver.FindElement(By.Name("btnUser")).Click();
            Assert.AreEqual(driver.FindElement(By.Id("header")).Text, "U");
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
