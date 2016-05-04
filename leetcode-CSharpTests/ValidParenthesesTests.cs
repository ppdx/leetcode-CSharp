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
    public class ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            Assert.AreEqual(Invoke("["), false);
            Assert.AreEqual(Invoke("]"), false);
            Assert.AreEqual(Invoke("[]"), true);
            Assert.AreEqual(Invoke("[()]"), true);
            Assert.AreEqual(Invoke("[{]}"), false);
        }

        private bool Invoke(string s)
        {
            return new ValidParentheses().IsValid(s);
        }
    }
}