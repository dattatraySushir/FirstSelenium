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
            extentTest.Pass("The test case is pass");
            extentTest.Fail("The test case is fail");
            extentReports.Flush();
            extentHtmlReporter.Stop();
            



        }
    }
}
