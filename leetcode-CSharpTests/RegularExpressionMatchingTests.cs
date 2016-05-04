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
    public class RegularExpressionMatchingTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            Assert.AreEqual(false, new RegularExpressionMatching().IsMatch("aa", "a"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch("aa", "aa"));
            Assert.AreEqual(false, new RegularExpressionMatching().IsMatch("aaa", "aa"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch("aa", "a*"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch("aa", ".*"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch("ab", ".*"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch("aab", "c*a*b"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch("aaa", "ab*ac*a"));
        }

        [TestMethod()]
        public void IsMatch2Test()
        {
            Assert.AreEqual(false, new RegularExpressionMatching().IsMatch2("aa", "a"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch2("aa", "aa"));
            Assert.AreEqual(false, new RegularExpressionMatching().IsMatch2("aaa", "aa"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch2("aa", "a*"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch2("aa", ".*"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch2("ab", ".*"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch2("aab", "c*a*b"));
            Assert.AreEqual(true, new RegularExpressionMatching().IsMatch2("aaa", "ab*ac*a"));
        }
    }
}