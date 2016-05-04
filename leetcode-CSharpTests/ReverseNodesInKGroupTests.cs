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
    public class ReverseNodesInKGroupTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            Assert.AreEqual(ListNode.Builder(new int[] { }), new ReverseNodesInKGroup().Reverse(ListNode.Builder(new int[] { })));
            Assert.AreEqual(ListNode.Builder(new int[] { 1 }), new ReverseNodesInKGroup().Reverse(ListNode.Builder(new int[] { 1 })));
            Assert.AreEqual(ListNode.Builder(new int[] { 2, 1 }), new ReverseNodesInKGroup().Reverse(ListNode.Builder(new int[] { 1, 2 })));
            Assert.AreEqual(ListNode.Builder(new int[] { 3, 2, 1 }), new ReverseNodesInKGroup().Reverse(ListNode.Builder(new int[] { 1, 2, 3 })));

        }

        [TestMethod()]
        public void ReverseKGroupTest()
        {
            Func<int[], ListNode> b = ListNode.Builder;
            Func<ListNode, int, ListNode> t = new ReverseNodesInKGroup().ReverseKGroup;
            foreach (var item in new[] {
               new {arg1= new[] { 1, 2, 3, 4, 5 } ,arg2=2,result=new [] { 2,1,4,3,5} },
               new {arg1= new[] { 1, 2, 3, 4, 5 } ,arg2=3,result=new [] { 3,2,1,4,5} },
            })
            {
                Assert.AreEqual(b(item.result), t(b(item.arg1), item.arg2));
            }
        }
    }
}