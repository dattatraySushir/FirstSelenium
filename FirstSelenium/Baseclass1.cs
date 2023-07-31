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
    public class AssemblyClass1
    {
        //[AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            MessageBox.Show("This is Assembly initaliser");
        }
      //  [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("This is Assembly Cleanup");
        }
    }
}
