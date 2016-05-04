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
    public class MergeKSortedListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            for (int i = 0; i < 100; i++)
            {
                ListNode[] testCase = MakeTestCase();
                ListNode[] testCaseDump = testCase.Select(l => l?.Clone()).ToArray();
                ListNode standardResult = StandardResult(testCase);
                ListNode  result = new MergeKSortedLists().MergeKLists(testCase);
                if (result != standardResult)
                {
                    Console.WriteLine("standard:{0}\nanswer:{1}", standardResult, result);
                    Assert.Fail();
                }
            }
        }
        private Random _rand = new Random();
        ListNode[] MakeTestCase()
        {
            return Enumerable.Range(0, _rand.Next(100)).Select(
                _ => ListNode.Builder(Enumerable.Range(0, _rand.Next(100)).Select(j => _rand.Next()).OrderBy(i => i))).ToArray();
        }

        ListNode StandardResult(ListNode[] ll)
        {
            return ListNode.Builder(ll.SelectMany(l => l?.ToList() ?? new int[] { }).OrderBy(i => i).ToList());
        }
    }
}