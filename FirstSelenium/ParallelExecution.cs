using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
[assembly: Parallelize(Workers =2,Scope =ExecutionScope.MethodLevel)]
namespace FirstSelenium
{
    [TestClass]
    [TestCategory("Parallel Execution")]
    public class ParallelExecution
    {
        [TestMethod]
        public void ParallelExecutionTest1()
        {
            Console.WriteLine($"Execution no.1 ");
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void ParallelExecutionTest2()
        {
            Console.WriteLine($"Execution no 2");
            Thread.Sleep(3000);
        }
        [TestMethod]
      
        public void ParallelExecutionTest3()
        {
            Console.WriteLine($"Execution no. 3");
            Thread.Sleep(3000);

        }
        [TestMethod]
      
        public void ParallelExecutionTest4()
        {
            Console.WriteLine($"Execution no 4");
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void ParallelExecutionTest5()
        {
            Console.WriteLine($"Execution no 5");
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void ParallelExecutionTest6()
        {
            Console.WriteLine($"Execution no 6");
            Thread.Sleep(3000);
        }
        [TestMethod]
       // [DoNotParallelize]
        public void ParallelExecutionTest7()
        {
            Console.WriteLine($"Execution no 7");
            Thread.Sleep(3000);
        }
    }
}
