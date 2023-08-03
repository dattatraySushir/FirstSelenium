using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstSelenium.TestScripts.Today
{
    [TestClass]
    [TestCategory("Regression")]
 
    public class PriorityyClasses
    {
        [TestMethod]
        [Priority(0)]
        public void M1()
        {
            Console.WriteLine("The first method is executed");
            Thread.Sleep(3000);
        }
        [TestMethod]
        [Priority(0)]
        public void M2()
        { 
            Console.WriteLine("The second method is executed");
            Thread.Sleep(3000);
        }
        [TestMethod]
        [TestCategory("Methods"), Priority(1)]
        public void M3()
        { 
            Console.WriteLine("The third method is executed");
            Thread.Sleep(3000);
        }
        [TestMethod]
        [Priority(0)]
        public void M4()
        { 
            Console.WriteLine("The fourth method is executed");
            Thread.Sleep(3000);
        }

    }
}
