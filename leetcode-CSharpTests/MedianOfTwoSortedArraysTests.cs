using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp.Tests
{
    [TestClass()]
    public class MedianOfTwoSortedArraysTests
    {
        private readonly Random _rand = new Random();

        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            for (int i = 0; i < 1000; i++)
            {
                int[] a = GenerateArray(_rand.Next(100) + 1);
                int[] b = GenerateArray(_rand.Next(100) + 1);
                Assert.AreEqual(MedianNum(a, b),
                    new MedianOfTwoSortedArrays().FindMedianSortedArrays(a, b));
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
            return list[list.Count/2];
        }

        private int[] GenerateArray(int length)
        {
            return Enumerable.Range(0, length).Select(i => _rand.Next(100)).OrderBy(i => i).ToArray();
        }
    }
}