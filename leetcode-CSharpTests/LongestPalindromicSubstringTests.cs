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
    public class LongestPalindromicSubstringTests
    {
        private readonly string[] _testCase =
        {
            "a",
            "abacdd",
            "bb",
        };

        private string[] _result =
        {
            "a",
            "aba",
            "bb",
        };

        [TestMethod()]
        public void LongestPalindromeTest()
        {
            for (int i = 0; i < _testCase.Length; i++)
            {
                Assert.AreEqual(_result[i],
                    new LongestPalindromicSubstring().LongestPalindrome(_testCase[i]));
            }
        }
    }
}