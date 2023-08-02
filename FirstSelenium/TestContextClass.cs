using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("Test Context")]
    public  class DataDrivernCsvFile
    {
        public static TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }

        }
        [AssemblyInitialize]
        public static void Method(TestContext _testContext)
        {
            testContext = _testContext;
        }
        [AssemblyCleanup]
        public static void Method2()
        {
            
        }
        [TestMethod]
        [TestCategory("Test Context"), Priority(0)]
        
        public void Test()
        {
            if(TestContext.Properties["Browser"].Equals("Chrome"))
            {
                IWebDriver driver = new ChromeDriver();
            }
            else
            {
                Assert.Fail("Enter the valid browser name");
            }
            TestContext.WriteLine(TestContext.TestName+" ");
            TestContext.WriteLine(TestContext.Properties["Browser"].ToString());
        }
    }
}
