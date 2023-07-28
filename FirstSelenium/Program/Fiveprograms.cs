using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Program
{
    [TestClass]
    [TestCategory("Programs")]
    public class Program1
    {
        [TestMethod]

        public void AppendTheZerosAtLast()
        {
            int[] a = { 0, 1, 0, 2, 0, 5, 0, 8, 0, 6 };
            int m = 0;
            int len=a.Length-1;
            int[] b = new int[len];
            for(int i=0; i<len; i++)
            {
                if (a[i] != 0)
                {
                    b[m++] = a[i];
                }
            }
            for(int i=0; i<b.Length;i++)
            {
                Console.Write(b[i]+" ");
            }
        }
        [TestMethod]
        public void AdditionOfArrays()
        {
            int[] a = { 4, 2, 5, 1, 3 };
            int[] b = { 3, 1, 6, 4 };
            int len = a.Length;
            if(a.Length<b.Length)
            {
                len= b.Length;
            }
            for (int i=0; i<len;i++)
            {
                try
                {
                    Console.Write(a[i] + b[i] + " ");
                }catch (Exception) {
                if(a.Length<b.Length) 
                    {
                        Console.WriteLine(b[i]+" ");
                            
                            
                     }
                else { 
                        Console.WriteLine(a[i]+" "); 
                    }
                }
            }
        }
    }
}
