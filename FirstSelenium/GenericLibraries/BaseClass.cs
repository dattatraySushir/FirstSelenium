using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.GenericLibraries
{
    public class Baseclass
    {
       public IWebDriver driver;
        [TestInitialize]
        public void LoginToApp()
        {
        driver=new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
        }
        [TestCleanup]
        public void Logout()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
