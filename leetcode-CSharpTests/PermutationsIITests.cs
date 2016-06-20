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
    public class PermutationsIITests
    {
        [TestMethod()]
        public void PermuteUniqueTest()
        {
            T(new[] { 1, 1, 2 }, new[] {  new[]{1,1,2},
  new[]{1,2,1},
  new[]{2,1,1}});
        }

        void T(int[] a, IList<IList<int>> r)
        {
            r.AreSetEqual(new PermutationsII().PermuteUnique(a));
        }

    }
}