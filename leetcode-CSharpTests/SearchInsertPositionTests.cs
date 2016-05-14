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
    public class SearchInsertPositionTests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            Action<int[], int> t = (nums, target) =>
             {
                 int tmp = Array.FindIndex(nums, (i) => i >= target);
                 Assert.AreEqual(tmp < 0 ? nums.Length : tmp,
                     new SearchInsertPosition().SearchInsert(nums, target));
             };
            t(new[] { 1, 3, 5, 6 }, 5);
            t(new[] { 1, 3, 5, 6 }, 2);
            t(new[] { 1, 3, 5, 6 }, 7);
            t(new[] { 1, 3, 5, 6 }, 0);
        }
    }
}