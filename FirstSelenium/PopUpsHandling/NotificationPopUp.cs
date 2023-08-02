using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.PopUpsHandling
{
    [TestClass]
    public class NotificationPopUp
    {
        [TestMethod]
        public void HandlePopUp()

        {
            //to handle the browser notification popup we use the chromeoptions class.
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");

            // we pass the chromeoptions class reference to the chromedriver constructor.
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            driver.Url = "http://demo.guru99.com/popup.php";


        }
    }
}
