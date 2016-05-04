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
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            Assert.AreEqual(321, new ReverseInteger().Reverse(123));
            Assert.AreEqual(-321, new ReverseInteger().Reverse(-123));
            Assert.AreEqual(0, new ReverseInteger().Reverse(1000000003));
            Assert.AreEqual(0, new ReverseInteger().Reverse(-2147483648));
        }
    }
}