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
    public class SearchForARangeTests
    {
        [TestMethod()]
        public void SearchRangeTest()
        {
            Action<int[], int> t = (nums, target) =>
             {
                 int[] r = new SearchForARange().SearchRange(nums, target);
                 Assert.AreEqual(Array.IndexOf(nums, target), r[0]);
                 Assert.AreEqual(Array.LastIndexOf(nums, target), r[1]);
             };
            t(new[] { 5, 7, 7, 8, 8, 10 }, 8);
            t(new[] { 5, 7, 7, 8, 8, 10 }, 5);
            t(new[] { 5, 7, 7, 8, 8, 10 }, 8);
            t(new[] { 5, 7, 7, 8, 8, 10 }, 8);
            t(new[] { 5, 7, 7, 8, 8, 10 }, 0);
            t(new[] { 5, 7, 7, 8, 8, 10 }, 10);
            t(new[] { 2, 2 }, 3);
            t(new[] { 1, 2, 3 }, 2);

        }
    }
}