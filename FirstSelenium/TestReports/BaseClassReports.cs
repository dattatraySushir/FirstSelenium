using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FirstSelenium.TestReports
{
    [TestClass]
    public class BaseClassReports
    {
        public static TestContext TestContext;
        public TestContext testContext
        {
            get { return TestContext; }
            set { TestContext = value; }
        }
        const string path = "D:\\VisualStudioCode\\C#Selenium\\FirstSelenium\\FirstSelenium\\TestReports\\Reports\\";
        public static ExtentReports extentReports;
        public static ExtentHtmlReporter extentHtmlReporter;
        public static ExtentTest extentTest;

        [AssemblyInitialize]
       public static void AssemblyIniytialise(TestContext context)
        {
            TestContext = context;
           extentReports = new ExtentReports();
            extentHtmlReporter = new ExtentHtmlReporter(path);
            extentReports.AddSystemInfo("Windows OS", "Windows 11");
            extentReports.AttachReporter(extentHtmlReporter);
            extentTest = extentReports.CreateTest("datta");
            MessageBox.Show("Assembly cleanup started");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            extentReports.Flush();
            extentHtmlReporter.Stop();
            MessageBox.Show("Assembly cleanup ended");
        }
    }
}
