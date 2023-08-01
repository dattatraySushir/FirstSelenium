using FirstSelenium.ObjectRepository;
using FirstSelenium.TestScripts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstSelenium.GenericLibraries
{
    public class Baseclass
    {
       public  IWebDriver driver;
        [TestInitialize]
        public void OpenBrowser()
        {
        driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.actitime.com/login.do";
            WebDriverUtility webDriverUtility = new WebDriverUtility();
            webDriverUtility.WaitForElementImplicitly(driver);
            /*FetchDataFromExcel excelfetch = new FetchDataFromExcel();
            string username = excelfetch.ExcelDataFectch("Acti", 0, 0);
            string password = excelfetch.ExcelDataFectch("Acti", 1, 0);
            LoginPage loginpage = new LoginPage(driver);
            loginpage.login(username, password);
            loginpage.ClickCheckbox();
            loginpage.ClickLoginButton();*/
        }


        [TestCleanup]
        public void Logout()
        {
            HomePage homePage = new HomePage(driver);
            //WebDriverUtility wdu = new WebDriverUtility();
           // wdu.WaitForElementVisible(driver,homePage.GetLogoutButton());
            Thread.Sleep(3000);
            homePage.ClickLogout();
            driver.Close();
            driver.Dispose();
        }
    }
}
