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
    public class MergeTwoSortedListsTests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            Func<ListNode, ListNode, ListNode> func = new MergeTwoSortedLists().MergeTwoLists;

            Assert.AreEqual(ListNode.Builder(new[] { 0 }), func(null, ListNode.Builder(new[] { 0 })));

        }
    }
}