using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("NavigationMethods")]
    public class NavigationMethods
    {
       // [TestMethod]
        public void BackProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.XPath("//a[text()='About']")).Click();
            driver.Navigate().Back();
        }

       /// [TestMethod]
        public void RefreshProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            driver.Navigate ().Refresh();   
        }
       // [TestMethod]
        public void ForwardProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.XPath("//a[text()='About']")).Click();
            Console.WriteLine("It will getting backward");
            driver.Navigate().Back();
            Thread.Sleep(3000);
            Console.WriteLine("It is perform forward scenario");
            driver.Navigate().Forward();
        }
      //  [TestMethod]
        public void GoToUrlProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("The application is getting open");
        }
    }
}
