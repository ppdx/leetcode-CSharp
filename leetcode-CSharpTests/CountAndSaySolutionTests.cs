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
    public class CountAndSaySolutionTests
    {
        [TestMethod()]
        public void CountAndSayTest()
        {
            var result = new[] { "1", "11", "21", "1211", "111221" };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], new CountAndSaySolution().CountAndSay(i + 1));
            }
        }
    }
}