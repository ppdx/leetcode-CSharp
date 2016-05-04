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
    public class AddTwoNumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            var l1 = ListNode.Builder(new int[]{9,1,6});
            var l2 = ListNode.Builder(new int[] { 0});
            var ret = ListNode.Builder(new int[] { 9,1,6});
            Assert.AreEqual(new AddTwoNumbersSolution().AddTwoNumbers(l1, l2), ret);
        }
    }
}