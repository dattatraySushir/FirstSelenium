using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    public class DataDrivenTest
    {
        [TestMethod]
        [TestCategory("DataDrivenTest")]
        [DataTestMethod]
        [DataRow("https://demo.actitime.com/login.do")]
        [DataRow("https://www.flipkart.com/")]
        [DataRow("https://www.google.com/")]
        public void DataDrivenTestMethod(string url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            Console.WriteLine(driver.Title);
            driver.Close();
            driver.Dispose();
        }
        [TestMethod]
        [Ignore]
        public void Ignore()
        {

        }
    }
}
