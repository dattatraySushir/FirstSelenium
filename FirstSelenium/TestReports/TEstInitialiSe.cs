using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.TestReports
{
    public class TEstInitialiSe : BaseClassReports
    {
        [TestInitialize]
        public void TestInitialise()
        {
          extentTest.Log(Status.Info,testContext.TestName);

        }
        [TestCleanup]
        public void TestCleanup()
        {

        }

    }
   
}
