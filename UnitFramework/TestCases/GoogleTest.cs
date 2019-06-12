using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace UnitFramework.TestCases
{
    [TestClass]
    public class GoogleTest
    {
        IWebDriver driver;
        String url;
        String title; 

        [TestInitialize] 
        public void setup()
        {
            driver = new ChromeDriver();
            url = "http://google.com";
            title = "Google"; 
        }

        [TestMethod]
        public void openHomePageTest()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize(); // maximizes window 
            driver.Close(); //closes window 
        }

        [TestMethod]
        public void getTitleTest()
        {
            driver.Navigate().GoToUrl(url);
            Assert.AreEqual(title, driver.Title);
            driver.Close(); //closes window 
        }

        [TestCleanup] 
        public void cleanup()
        {
            driver.Quit(); 
        }
    }
}
