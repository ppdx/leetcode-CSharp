using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace leetcode_CSharp.Tests
{
    [TestClass()]
    public class MultiplyStringsTests
    {
        [TestMethod()]
        public void MultiplyTest()
        {
            Action<string, string> t = (a, b) =>
                Assert.AreEqual((BigInteger.Parse(a) * BigInteger.Parse(b)).ToString(),
                                 new MultiplyStrings().Multiply(a, b));
            t("0", "0");
            t("6632134512315464321346546879631316832", "864123727643923187694564398798756398456394856043985270");
        }
    }
}
