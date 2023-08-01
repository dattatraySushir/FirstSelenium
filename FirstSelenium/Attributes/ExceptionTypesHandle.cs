using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Attributes
{
    [TestClass]
    [TestCategory("Exception")]
    public class ExceptionTypesHandle
    {
        [TestMethod]
        [TestCategory("Exception")]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExceptionTypesHandleTest()
        {
            string[] name = {"datta","tejas","veena","sushma"};
            for(int i=0; i<=name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            
        }
    }
}
