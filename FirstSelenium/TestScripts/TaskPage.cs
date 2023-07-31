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
    public class TaskPage : Baseclass
    {
        [TestMethod]
        public void TaskHome()
        {
           // Assert.AreEqual("actiTIME -  Enter Time-Track", title, "Page title is not match");
            HomePage homepage = new HomePage(driver);
            homepage.ClickTasks();

        }
    }
}
