using FirstSelenium.GenericLibraries;
using FirstSelenium.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
       // [TestMethod]
        public void LoginToApp1()
        {
            LoginPage loginpage= new LoginPage(driver);
            loginpage.FillUsername();
            loginpage.FillPassword();
            loginpage.ClickCheckbox();
            loginpage.ClickLoginButton();
        }

    }
}
