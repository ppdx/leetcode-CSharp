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
    public class TrappingRainWaterTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            Action<int[], int> t = (a, r) => Assert.AreEqual(r, new TrappingRainWater().Trap(a));
            t(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6);
        }
    }
}