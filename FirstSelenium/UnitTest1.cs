using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("Practice")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("practise")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            driver.FindElement(By.Id("APjFqb")).Click();
            String dvr = driver.Title;
            Console.WriteLine(dvr);
        }
        [TestMethod]
        [TestCategory("PracticeFirst2")]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.Id("APjFqb")).Click();
            String dvr = driver.Title;
            Console.WriteLine(dvr);
            driver.FindElement(By.Id("APjFqb")).SendKeys("Datta Sushir");

        }
    }

}
