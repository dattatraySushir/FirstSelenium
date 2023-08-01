using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Attributes
{
    [TestClass]
    [TestCategory("Priority")]
    public  class PrioritiesClass
    {
        [TestMethod]
        [Priority(2)]
        public void Method1()
        {
            Console.WriteLine("The method 1 is executed from priority class");
        }
        [TestMethod]
        [Priority(0)]
        public void Method2() 
        {
            Console.WriteLine("The method 2 is executed form the priority class"); 
        }
        [TestMethod, Priority(3)]
        public void Method3()
        {
            Console.WriteLine("The method 3 is executed form the priority class");
        }
    }
    [TestClass]
    [TestCategory("Alphabets Categeory")]
    public class Alphabets1
    {
        [TestMethod]
        [Priority(1)]
        public void A() {
            Console.WriteLine("A method is executed from alphabets");

        }
        [TestMethod]
        [Priority(0)]
        public void B() {
            Console.WriteLine("B method is executed form the aplphabets class");
        }
        [TestMethod]
        [Priority(2)]
        public void C()
        {
            Console.WriteLine("C method is executed from the alphabets class");
        }
        [TestMethod]
        [Priority(3)]
        public void D()
        {
            Console.WriteLine("D method is executed form the alphabets class");
        } 
    }
}
