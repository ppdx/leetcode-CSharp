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
    public class StringToIntegerAtoiTests
    {
        [TestMethod()]
        public void MyAtoiTest()
        {
            Assert.AreEqual(2147483647, new StringToIntegerAtoi().MyAtoi("9223372036854775809"));
            Assert.AreEqual(2147483647,new StringToIntegerAtoi().MyAtoi("2147483647"));
            Assert.AreEqual(2147483647, new StringToIntegerAtoi().MyAtoi("2147483648"));
            Assert.AreEqual(0, new StringToIntegerAtoi().MyAtoi(""));
            Assert.AreEqual(-12, new StringToIntegerAtoi().MyAtoi("  -0012a42"));
            Assert.AreEqual(0, new StringToIntegerAtoi().MyAtoi("       "));
            Assert.AreEqual(-2147483648, new StringToIntegerAtoi().MyAtoi("-2147483648"));
            Assert.AreEqual(-2147483647, new StringToIntegerAtoi().MyAtoi("-2147483647"));
            Assert.AreEqual(-2147483648, new StringToIntegerAtoi().MyAtoi("-2147483649"));
            Assert.AreEqual(2147483647, new StringToIntegerAtoi().MyAtoi("    10522545459"));
        }
    }
}