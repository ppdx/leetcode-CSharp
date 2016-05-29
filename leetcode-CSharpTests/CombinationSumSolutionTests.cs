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
    public class CombinationSumSolutionTests
    {
        [TestMethod()]
        public void CombinationSumTest()
        {
            Action<int[], int, IList<IList<int>>> t = (a1, a2, r) =>
              {

                  Assert.IsTrue(new CombinationSumSolution().CombinationSum(a1, a2).Sort().Zip(r.Sort(), (l1, l2) => l1.SequenceEqual(l2)).All(_ => _));
              };
            t(new[] { 2, 3, 6, 7 }, 7, new[] { new[] { 7 }, new[] { 2, 2, 3 } });
        }

    }
}