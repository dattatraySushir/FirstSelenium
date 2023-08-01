using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Attributes
{
    [TestClass]
    public class TimeoutAttribute1
    {
        [TestMethod]
        [TestCategory("Timeout"),Owner("Datta")]
        [Timeout(1000)]
        public void TimeOuts()
        {
            Console.WriteLine("The message of timeout is printed");
        }
    }
}
