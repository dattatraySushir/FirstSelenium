using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("Generating Reports")]
    public class ExtentReportsData
    {
        const string path = "D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\Reports\\";
        [TestMethod]
        public void ExtentReportsDataTest()
        {
            ExtentReports extentReports = new ExtentReports();
            ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter(path);
            extentReports.AddSystemInfo("Organisation","TYSS");
            extentReports.AddSystemInfo("Operation OS", "Windows");
            extentReports.AttachReporter(extentHtmlReporter);

           ExtentTest  extentTest= extentReports.CreateTest("Datta");
            extentTest.Log(Status.Info, "The report is being generated and status is updated");
            extentTest.Log(Status.Warning,"This is the warning symbol");
            extentTest.Log(Status.Fatal,"The test case is fatal");
            extentTest.Pass("The test case is pass");
            extentTest.Fail("The test case is fail");

            ExtentTest extentTest1 = extentReports.CreateTest("Tejas");
            extentTest1.Log(Status.Info, "The report is being generated and status is updated");
            extentTest1.Log(Status.Warning, "This is the warning symbol for tejas");
            extentTest1.Log(Status.Fatal, "Tejas test case is fatal");
            extentTest1.Pass("The test case is pass tejas");
            extentTest1.Fail("The test case is fail of tejas");

            ExtentTest extentTest2 = extentReports.CreateTest("Veena");

            extentTest2.Log(Status.Info, "The report is being generated and status is updated");
            extentTest2.Log(Status.Warning, "This is the warning symbol");

            extentTest2.Log(Status.Fatal, "The test case is fatal for veena");

            extentTest2.Pass("The test case is pass for veena");

            extentTest2.Fail("The test case is fail for veena");

            ExtentTest extentTest3 = extentReports.CreateTest("Sushma");
            extentTest3.Log(Status.Info, "The report is being generated and status is updated");
            extentTest3.Log(Status.Warning, "This is the warning symbol for sushma");
            extentTest3.Log(Status.Fatal, "The test case is fatal sushma");
            extentTest3.Pass("The test case is pass sushma");
            extentTest3.Fail("The test case is fail sushma");


            extentReports.Flush();
            extentHtmlReporter.Stop();
            



        }
    }
}
