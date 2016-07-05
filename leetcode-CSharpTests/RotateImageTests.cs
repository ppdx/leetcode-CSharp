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
    public class RotateImageTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            T(new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, new[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } });

        }
        public void T(int[,] a1, int[,] r)
        {
            new RotateImage().Rotate(a1);
            Assert.IsTrue(Utility.MultidimensionalArraysCompare<int>(a1, r));
        }
    }
}