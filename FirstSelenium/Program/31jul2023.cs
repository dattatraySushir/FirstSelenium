using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium.Program
{
    [TestClass]
    [TestCategory("Programs31")]
    public class _31jul2023
    {
        [TestMethod]
        public void Program1()
        {
            String[] s = { "ab", "abc", "bd", "abcd", "abcde" };
            String minLength = s[0];
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i].Length < minLength.Length)
                {
                    minLength = s[i];
                }

            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length == minLength.Length)
                {
                    Console.WriteLine(s[i] + " ");
                }
            }
        }
        [TestMethod]
        public void Program2()
        {
            String s = "a11b12c3";
            int sum = 0;
            int tsum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s.ElementAt(i);
                if (ch > '0' && ch <= '9')
                {
                    int n = s.ElementAt(i) - 48;
                    tsum = tsum * 10 + n;

                }
                else
                {
                    sum = sum + tsum;
                    tsum = 0;
                }
            }
            sum = sum + tsum;
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void Program3()
        {
            String s = "a2b1d3";
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) > '0' && s.ElementAt(i) <= '9')
                {
                    sum = sum + (s.ElementAt(i) - 48);
                }
            }
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void Program4()
        {
            String s = "nayan";
            String rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s.ElementAt(i);
            }
            if (rev.Equals(s))
            {
                Console.WriteLine("The string is palindrome");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome");
            }
        }
        [TestMethod]
        public void Program5()
        {
            String s = "Testing";
            int l = s.Length;
            String str = "";
            char[] ch = s.ToCharArray();
            for (int i = 0; i < l; i++)
            {
                for (int j = 1; j < l; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        str = str + ch[j];
                    }
                }
            }
            String d = s.Replace(str, "");
            Console.WriteLine(d);
        }
    }
    
}
