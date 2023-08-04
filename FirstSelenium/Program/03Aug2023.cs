using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Program
{
    [TestClass]
    [TestCategory("03Aug Programs")]
    public class _03Aug2023
    {
        [TestMethod]
        public void SortMethod()
        {
            String str = "xzy";
            char[] ch = str.ToCharArray();
            Array.Sort(ch); 
            Console.WriteLine(new String(ch));
        }
        [TestMethod]
        public void CountEvenOdd()
        {
            int counteven = 0;
            int countodd = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    counteven++;
                }
                else
                {
                    countodd++;
                }
            }
            Console.WriteLine(counteven);
            Console.WriteLine(countodd);
        }
        [TestMethod]
        public void SwitchCase()
        {
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("your choice is one");
                    break;
                case 2:
                    Console.WriteLine("your choice is two");
                    break;
                case 3:
                    Console.WriteLine("your choice is three");
                    break;
                case 4:
                    Console.WriteLine("your choice is four");
                    break;
                case 5:
                    Console.WriteLine("your choice is five ");
                    break;

                default:
                    Console.WriteLine("enter valid ");
                    break;
            }
        }
        [TestMethod]
        public void RemoveDuplicate()
        {
            string str = "Dattatray";
            StringBuilder sb = new StringBuilder();
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                bool flag = false;
                for (int j = i + 1; j < ch.Length; j++)
                {

                    if (ch[i] == ch[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    sb.Append(ch[i]);
                }
            }
            Console.WriteLine(sb);
        }
        [TestMethod]
        public void BubbleSort()
        {
            int [] arr = { 21, 23, 12, 121, 14, 32, 65, 43 };
            int len = arr.Length;
            int temp;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i+" ");

            }
        }
        
    }
}
