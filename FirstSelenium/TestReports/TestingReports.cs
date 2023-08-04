using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.TestReports
{
    [TestClass]
    [TestCategory("Basereports")]
    public class TestingReports :TEstInitialiSe
    {
        [TestMethod]
        public void TestReports()
        {
            extentTest = extentReports.CreateTest(testContext.TestName);
            extentTest.Log(Status.Info, "This is the test method");
           // Console.WriteLine("This is the test method");
        }
        [TestMethod]
        public void SecoNdMethod()
        {
            extentTest = extentReports.CreateTest(testContext.TestName);
            extentTest.Warning("This is the 2nd method");
            //Console.WriteLine("This is the 2nd method");
        }
        [TestMethod]
        public void Thirdmethod()
        {
            extentTest = extentReports.CreateTest(testContext.TestName);
            extentTest.Info("This is the third method");
            //Console.WriteLine("This is the third method");
        }
    }
}
