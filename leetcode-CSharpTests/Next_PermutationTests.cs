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
    public class Next_PermutationTests
    {
        [TestMethod()]
        public void NextPermutationTest()
        {
            Action<int[], int[]> t = (a, b) =>
            {
                new Next_Permutation().NextPermutation(a);
                Utility.AreSequenceEqual(b, a);
            };
            t(new[] { 1, 2, 3 }, new[] { 1, 3, 2 });
            t(new[] { 3, 2, 1 }, new[] { 1, 2, 3 });
            t(new[] { 1, 1, 5 }, new[] { 1, 5, 1 });
            t(new[] { 1, 3, 2 }, new[] { 2, 1, 3 });
            t(new[] { 2, 3, 1 }, new[] { 3, 1, 2 });

        }
    }
}