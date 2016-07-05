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
    public class PowXNTests
    {
        [TestMethod()]
        public void MyPowTest()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                double x = rand.NextDouble();
                int n = rand.Next();
                Assert.AreEqual(Math.Pow(x, n), new PowXN().MyPow(x, n));
            }
            Assert.AreEqual(1, new PowXN().MyPow(1.00000, -2147483648));
        }
    }
}