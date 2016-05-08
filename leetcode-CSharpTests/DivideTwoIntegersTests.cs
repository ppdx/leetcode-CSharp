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
    public class DivideTwoIntegersTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            t(1234, 234);
            t(-2147483648, 2);
        }

        void t(int a, int b)
        {
            try
            {
                Assert.AreEqual(a / b, new DivideTwoIntegers().Divide(a, b));
            }
            catch (Exception)
            {
                Assert.AreEqual(int.MaxValue, new DivideTwoIntegers().Divide(a, b));
            }
        }
    }
}