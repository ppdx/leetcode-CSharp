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
    public class PalindromeNumberTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            Assert.AreEqual(true, new PalindromeNumber().IsPalindrome(121));
            Assert.AreEqual(true, new PalindromeNumber().IsPalindrome(11));
            Assert.AreEqual(false, new PalindromeNumber().IsPalindrome(10));
        }
    }
}