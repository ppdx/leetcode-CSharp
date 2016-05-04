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
    public class LengthOfLongestSubstringTests
    {
        string[] arg =
        {
            "abcabcbb",
            "bbbbb"
        };

        private int[] res =
        {
            3,
            1
        };

        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            foreach (var item in arg.Zip(res, (arg, res) => new { arg = arg, res = res }))
            {
                Assert.AreEqual(new LengthOfLongestSubstringSolution().LengthOfLongestSubstring2(item.arg), item.res);
            }
        }
    }
}