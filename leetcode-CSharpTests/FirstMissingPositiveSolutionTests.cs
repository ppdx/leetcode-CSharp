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
    public class FirstMissingPositiveSolutionTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            Action<int[], int> t =
                (a, r) => Assert.AreEqual(r, new FirstMissingPositiveSolution().FirstMissingPositive(a));
            t(new[] { 1, 2, 0 }, 3);
            t(new[] { 3, 4, -1, 1 }, 2);
            t(new[] { 1 }, 2);
        }
    }
}