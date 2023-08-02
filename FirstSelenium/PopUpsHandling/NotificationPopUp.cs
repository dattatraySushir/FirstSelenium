using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.PopUpsHandling
{
    [TestClass]
    [TestCategory("PopUp HAndling")]
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
        [TestMethod]
        public void HandleAlertPopUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://the-internet.herokuapp.com/";
            driver.FindElement(By.XPath("//a[text()='JavaScript Alerts']")).Click();
            driver.FindElement(By.XPath("//button[text()='Click for JS Alert']")).Click();
            IAlert alt = driver.SwitchTo().Alert();
            alt.Accept();
        }
        [TestMethod]
        public void AuthenticationPopUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://the-internet.herokuapp.com/digest_auth";
           // driver.FindElement(By.XPath("//a[text()='Basic Auth']")).Click();
            IAlert alt =driver.SwitchTo().Alert();
            //we use this method to send the credentials to the alert pop up.
          //  alt.SetAuthenticationCredentials("admin","admin");
        }
        [TestMethod] 
        public void AuthenticationPopUp1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //providing the login credentials in the url only we can handle the authentication popup.
            driver.Url = "https://admin:admin@the-internet.herokuapp.com/basic_auth";
        }
    }
}
