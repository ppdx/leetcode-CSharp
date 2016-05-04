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
    public class RemoveElementSolutionTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            Func<int[], int, int> t = new RemoveElementSolution().RemoveElement;
            int[] t1 = new[] { 3, 2, 2, 3 };
            int val = 3;
            Assert.AreEqual(2, t(t1, val));
            Assert.IsTrue(Compare(t1, 2, new[] { 2, 2 }));
        }

        private bool Compare(int[] a, int l, int[] b)
        {
            return a.Take(l).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
    }
}