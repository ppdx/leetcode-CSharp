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
    public class SearchInRotatedSortedArrayTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            Action<int[], int> t = (nums, target) =>
                Assert.AreEqual(nums.ToList().IndexOf(target),
                                new SearchInRotatedSortedArray().Search(nums, target));
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 4);
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 5);
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 6);
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 7);
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 1);
            t(new[] { 4, 5, 6, 7, 0, 1, 2 }, 2);
            t(new[] { 1 }, 0);
            t(new[] { 5, 1, 3 }, 5);
            t(new[] { 3, 1 }, 1);
        }
    }
}