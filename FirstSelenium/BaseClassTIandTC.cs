using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FirstSelenium
{
    [TestClass]
    public class BaseClassTIandTC
    {
       // [TestInitialize]
        public void TestInitialzi()
        {
            MessageBox.Show("This is the Test Initialise");
        }
        //[TestCleanup]
        public  void TestCleanup()
        {
            MessageBox.Show("This is the Test cleanup");
        }
        [TestMethod]
        public void TestMethod3()
        {
            MessageBox.Show("This is the 3rd method of baseclass");
        }
    }
}
