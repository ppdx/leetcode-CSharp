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
    public class SwapNodesInPairsTests
    {
        [TestMethod()]
        public void SwapPairsTest()
        {
            Assert.AreEqual(ListNode.Builder(new[] { 2, 1, 4, 3 }), 
                new SwapNodesInPairs().SwapPairs(ListNode.Builder(new[] { 1, 2, 3, 4 })));
        }
    }
}