using FirstSelenium.GenericLibraries;
using FirstSelenium.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.TestScripts
{
    [TestClass]
    public class LoginTest : Baseclass
    {

       
        [TestMethod]
       // [DataTestMethod]
      //  [DataRow("admin","manager")]
       // [DataRow("trainee", "trainee")]
        public void LoginToApp1()
        {
            FetchDataFromExcel excelfetch = new FetchDataFromExcel();
            string username = excelfetch.ExcelDataFectch("Acti", 0, 0);
            string password = excelfetch.ExcelDataFectch("Acti", 1, 0);
            LoginPage loginpage= new LoginPage(driver);
            loginpage.login(username, password);
            loginpage.ClickCheckbox();
            loginpage.ClickLoginButton();
           
        }

    }
}
