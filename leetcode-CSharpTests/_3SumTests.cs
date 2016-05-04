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
    public class _3SumTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            if (new HashSet<IList<int>>(new[] { new[] { -1, 0, 1 }, new[] { -1, -1, 2 } }).SetEquals(
                new HashSet<IList<int>>(new _3Sum().ThreeSum(new[] { -1, 0, 1, 2, -1, -4 }))))
                Assert.Fail();
            if (new HashSet<IList<int>>(new[] {new []{-5,1,4},new []{-5,2,3},new []{-3,-1,4},new []{-3,0,3},
                new []{-3,1,2},new []{-2,-2,4},new []{-2,-1,3},new []{-2,0,2},new []{-2,1,1},new []{-1,-1,2},
                new []{-1,0,1}}).SetEquals(
                new HashSet<IList<int>>(new _3Sum().ThreeSum(new[] { -1, -2, -3, 4, 1, 3, 0, 3, -2, 1, -2, 2, -1, 1, -5, 4, -3 }))))
                Assert.Fail();
        }

        [TestMethod()]
        public void ThreeSum2Test()
        {
            if (new HashSet<IList<int>>(new[] { new[] { -1, 0, 1 }, new[] { -1, -1, 2 } }).SetEquals(
                new HashSet<IList<int>>(new _3Sum().ThreeSum2(new[] { -1, 0, 1, 2, -1, -4 }))))
                Assert.Fail();
            if (new HashSet<IList<int>>(new[] {new []{-5,1,4},new []{-5,2,3},new []{-3,-1,4},new []{-3,0,3},
                new []{-3,1,2},new []{-2,-2,4},new []{-2,-1,3},new []{-2,0,2},new []{-2,1,1},new []{-1,-1,2},
                new []{-1,0,1}}).SetEquals(
                new HashSet<IList<int>>(new _3Sum().ThreeSum2(new[] { -1, -2, -3, 4, 1, 3, 0, 3, -2, 1, -2, 2, -1, 1, -5, 4, -3 }))))
                Assert.Fail();
        }
    }
}