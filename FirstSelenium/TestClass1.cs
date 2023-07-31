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
    [TestCategory("AssemblyInit")]
    public class TestClass1 : BaseClassTIandTC
    {
        [TestMethod]
        public void TestMethod() {
            MessageBox.Show("This is the 1st method");

        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            MessageBox.Show("This is class initialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("This is class cleanup");
        }
        [TestMethod]
        public void TestMethod2()
        {
            MessageBox.Show("This is the 2 nd method");
        }
        

    }
}
