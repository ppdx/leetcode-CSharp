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
    public class MaximumSubarrayTests
    {
        [TestMethod()]
        public void MaxSubArrayTest()
        {
            Assert.AreEqual(6, new MaximumSubarray().MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}