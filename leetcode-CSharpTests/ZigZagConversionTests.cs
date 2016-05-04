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
    public class ZigZagConversionTests
    {

        [TestMethod()]
        public void ConvertTest()
        {
            Assert.AreEqual("PAHNAPLSIIGYIR", new ZigZagConversion().Convert("PAYPALISHIRING", 3));
            Assert.AreEqual("AB", new ZigZagConversion().Convert("AB", 1));
        }
    }
}