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
    public class PermutationsTests
    {
        [TestMethod()]
        public void PermuteTest()
        {
            T(new[] { 1, 2, 3 }, new[] {   new[]{1,2,3},
  new[]{1,3,2},
  new[]{2,1,3},
  new[]{2,3,1},
  new[]{3,1,2},
  new[]{3,2,1}});
        }

        void T(int[] a, IList<IList<int>> r)
        {
            r.AreSetEqual(new Permutations().Permute(a));
        }
    }
}