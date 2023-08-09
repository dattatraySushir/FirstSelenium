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
    public class _06Aug2023
    {
        [TestMethod]
        public void ReverseString()
        {
            String str = "nayan";
            String rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char ch = str.ElementAt(i);
                rev = rev + ch;
            }
            Console.WriteLine(rev);
            if (str.Equals(rev))
            {
                Console.WriteLine("The provided string is pallindrome");
            }
            else
            {
                Console.WriteLine("The provided string is not  a pallindrome");
            }
        }
        [TestMethod]
        public void  FindSumOfDigits()
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
        public void FindMaximumNumbers()
        {
            String[] s = { "ab", "abc", "bd", "abcd", "abcde" };
            String maxLength = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > maxLength.Length)
                {
                    maxLength = s[i];
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length == maxLength.Length)
                {
                    Console.WriteLine(s[i] + " ");
                }
            }

        }
        [TestMethod]
        public void AdditionOfArrays()
        {
            int[] a = { 4, 2, 5, 1, 3 };
            int[] b = { 3, 1, 6, 4 };
            int length = a.Length;
            if (a.Length < b.Length)
            {
                length = b.Length;
            }
            for (int i = 0; i < length; i++)
            {
                try
                {
                    Console.WriteLine(a[i] + b[i] + " ");
                }
                catch (Exception e)
                {
                    if (a.Length < b.Length)
                    {
                        Console.WriteLine(b[i]);
                    }
                    else
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }
        [TestMethod]
        public void FindVowels()
        {
            string s = "India";
            String str = s.ToLower();
            String a = "aeiou";

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (str.ElementAt(i) == a.ElementAt(j))
                    {
                        count++;
                        break;
                    }

                }
                if (count > 1)
                {
                    Console.WriteLine(str.ElementAt(i) + " " + count);
                }
            }
        }
    }
}
