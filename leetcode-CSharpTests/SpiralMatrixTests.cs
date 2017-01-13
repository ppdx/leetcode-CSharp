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
    public class SpiralMatrixTests
    {
        [TestMethod()]
        public void SpiralOrderTest()
        {
            new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }.AreSequenceEqual(
                new SpiralMatrix().SpiralOrder(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }));
            new[] { 1, 2 }.AreSequenceEqual(new SpiralMatrix().SpiralOrder(new int[,] { { 1 }, { 2 } }));
        }
    }
}