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
    [TestCategory("Report ScreenShot")]
    public class ScreenSHotReports
    {
        [TestMethod]
        public void WebScreenShot()
        {
            IWebDriver driver = new ChromeDriver();

        }
    }
}
