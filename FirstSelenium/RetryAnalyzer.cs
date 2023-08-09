using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    [TestClass]
    [TestCategory("RetryAnalyzerTesting")]
    public class RetryAnalyzer
    {
        [TestMethod]
        [TestCategory("RetryAnalyzerTesting")]
        public static void RetryAnalyzerTest(object methodname,int maxtry)
        {
            int count = 0;
            bool flag = false;
            while (count < maxtry)
            {
                if(methodname.Equals(true)) 
                {
                    flag = true;
                    break;
                }
                else
                {
                    count++;
                }
               
            }
            if(flag=false)
            {
                count++;
            }
        }
        [TestMethod]
        [TestCategory("RetryAnalyzerTesting")]
        public static bool RetryAnalyzerTest1() 
        {
        int a=1, b=2;
            int sum = a + b;
            bool flag = false;
            if (sum < 2)
            {
                flag = true;
                Console.WriteLine("The wrong statement");
            }
            else { Console.WriteLine("Writhe the correct value"); }
            return flag;

        }
        [TestMethod]
        [TestCategory("RetryAnalyzerTesting")]
        public static void Method1()
           
        {
            object o = RetryAnalyzer.RetryAnalyzerTest1();
            RetryAnalyzer.RetryAnalyzerTest(o,3);
        }
    }
   
}
