using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100000000;
            int b = 100;
            int c = a * b;
            FindMedianSortedArraysTest();
            //Console.ReadKey();
        }


        private static readonly Random Rand = new Random();

        public static void FindMedianSortedArraysTest()
        {
            for (int i = 0; i < 100000; i++)
            {
                int[] a = GenerateArray(Rand.Next(100) + 1);
                int[] b = GenerateArray(Rand.Next(100) + 1);
                new MedianOfTwoSortedArrays().FindMedianSortedArrays(a, b);
            }
        }

        private static double MedianNum(int[] a, int[] b)
        {
            List<int> list = a.Concat(b).ToList();
            list.Sort();
            if (list.Count % 2 == 0)
            {
                int k = list.Count / 2;
                return (list[k] + list[k - 1]) / 2.0;
            }
            return list[list.Count / 2];
        }

        private static int[] GenerateArray(int length)
        {
            return Enumerable.Range(0, length).Select(i => Rand.Next(100)).OrderBy(i => i).ToArray();
        }
    }
}
